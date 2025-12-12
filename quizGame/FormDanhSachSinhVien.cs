using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Z.Dapper.Plus;
using System.Data.SqlClient;
using Dapper;

namespace quizGame
{
    public partial class FormDanhSachSinhVien : Form
    {
        public FormDanhSachSinhVien()
        {
            InitializeComponent();
        }

        DataTableCollection tableCollection;
        public string connectionString = @"Server = DESKTOP-0TUPAG2\QUANGTRUNG; Database = dbDanhSachSinhVien; User Id = sa; Password = 1easygame;";

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataTable dt = tableCollection[cboSheet.SelectedIndex];
            //dataGridView1.DataSource = dt;
            //if (dt != null)
            //{
            //    List<Students> students = new List<Students>();
            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        Students student = new Students();
            //        student.STT = dt.Rows[i]["STT"].ToString();
            //        student.MSSV = dt.Rows[i]["MSSV"].ToString();
            //        student.HoVaTen = dt.Rows[i]["Họ và tên"].ToString();
            //        student.Diem = Convert.ToInt32(dt.Rows[i]["Điểm"]);
            //        students.Add(student);
            //    }
            //    table1BindingSource.DataSource = students;
            //}
            //dataGridView1.DataSource = table1BindingSource;

            // Kiểm tra xem người dùng đã chọn một sheet
            if (cboSheet.SelectedIndex >= 0)
            {
                // Lấy DataTable từ sheet đã chọn
                DataTable dt = tableCollection[cboSheet.SelectedIndex];
                if (dt != null)
                {
                    // Gán trực tiếp DataTable làm nguồn dữ liệu cho DataGridView
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh(); // Làm mới DataGridView để đảm bảo dữ liệu hiển thị
                    MessageBox.Show("Dữ liệu đã được hiển thị lên DataGridView.");
                }
                else
                {
                    MessageBox.Show("Sheet không có dữ liệu.");
                }
            }
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel (.xlsx)|*.xlsx|Excel (.xls)|*.xls" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilename.Text = openFileDialog.FileName;
                    using(var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true}
                            });
                            tableCollection = result.Tables;
                            cboSheet.Items.Clear();
                            foreach(DataTable table in  tableCollection)
                            {
                                cboSheet.Items.Add(table.TableName);
                            }
                        }
                    }
                }
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            try
            {
                connectionString = @"Server = DESKTOP-0TUPAG2\QUANGTRUNG; Database = dbDanhSachSinhVien; User Id = sa; Password = 1easygame;";
                DapperPlusManager.Entity<Students>().Table("Table_1");
                List<Students> students = table1BindingSource.DataSource as List<Students>;
                if (students != null)
                {
                    using (IDbConnection db = new SqlConnection(connectionString))
                    {
                        // Kiểm tra xem bảng có dữ liệu hay không
                        int rowCount = db.ExecuteScalar<int>("SELECT COUNT(*) FROM Table_1");

                        if (rowCount == 0)
                        {
                            // Bảng chưa có dữ liệu, thêm toàn bộ sinh viên mới vào
                            foreach (var student in students)
                            {
                                db.Execute("INSERT INTO Table_1 (STT, MSSV, HoVaTen, Diem) VALUES (@STT, @MSSV, @HoVaTen, @Diem)",
                                    new { student.STT, student.MSSV, student.HoVaTen, student.Diem });
                            }
                            MessageBox.Show("Thêm sinh viên lần đầu thành công!");
                        } 
                        else
                        {
                            //db.BulkInsert(student);
                            int currentTimes = GetNumberOfDiemColumns(db);
                            string newDiemColumn = $"DiemLan{currentTimes + 1}";
                            AddColumnIfNotExists(db, newDiemColumn);
                            foreach (var student in students)
                            {
                                // Kiểm tra sinh viên có tồn tại trong cơ sở dữ liệu không dựa trên MSSV
                                var existingStudent = db.QueryFirstOrDefault<Students>(
                                    "SELECT * FROM Table_1 WHERE MSSV = @MSSV",
                                    new { student.MSSV });

                                if (existingStudent != null)
                                {
                                    // Nếu sinh viên đã tồn tại, cập nhật điểm vào cột mới
                                    db.Execute($"UPDATE Table_1 SET {newDiemColumn} = @Diem WHERE MSSV = @MSSV",
                                        new { student.Diem, student.MSSV });
                                }
                                else
                                {
                                    // Nếu MSSV không khớp, bỏ qua dòng đó
                                    MessageBox.Show($"Sinh viên với MSSV {student.MSSV} không tồn tại. Không thể thêm điểm.");
                                }
                            }
                        }
                    }
                }
                MessageBox.Show("Successful!!");
                txtFilename.Clear();
                cboSheet.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetNumberOfDiemColumns(IDbConnection db)
        {
            string query = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Table_1' AND COLUMN_NAME LIKE 'DiemLan%'";
            return db.QuerySingle<int>(query);
        }

        private void AddColumnIfNotExists(IDbConnection db, string columnName)
        {
            string checkColumnQuery = $"IF NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Table_1' AND COLUMN_NAME = '{columnName}') " +
                                      $"ALTER TABLE Table_1 ADD {columnName} INT NULL";
            db.Execute(checkColumnQuery);
        }

        private void FormDanhSachSinhVien_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Đảm bảo làm mới DataTable từ cơ sở dữ liệu
            string query = "SELECT * FROM Table_1"; // Truy vấn tất cả dữ liệu từ bảng
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                // Xóa tất cả dữ liệu cũ trong Dataset
                this.dbDanhSachSinhVienDataSet.Clear();

                // Đặt AutoGenerateColumns thành true để tự động tạo cột từ dữ liệu
                dataGridView1.AutoGenerateColumns = true;

                // Đổ dữ liệu từ SQL vào DataTable
                adapter.Fill(dataTable);

                // Thiết lập DataSource cho DataGridView
                dataGridView1.DataSource = dataTable;
            }
        }
    }
}
