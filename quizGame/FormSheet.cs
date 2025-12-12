using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using System.IO;
using Dapper;
using System.Text.RegularExpressions;
using Color = System.Drawing.Color;
using static Google.Apis.Sheets.v4.SheetsService;
using ClosedXML.Excel;

namespace quizGame
{
    public partial class FormSheet : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-0TUPAG2\QUANGTRUNG;Initial Catalog=db_DSSV_1;User ID=sa; Password=1easygame");
        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static readonly string ApplicationName = "Google Sheets API .NET Quickstart";
        static SheetsService service;
        private int saveCount;
        public FormSheet()
        {
            InitializeComponent();
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            saveCount = getCurrentSaveCount(connection) + 1;
            LoadTableNamesFromSQL();
        }

        public class GoogleSheetsReader
        {
            public static void InitializeGoogleSheets()
            {
                GoogleCredential credential;
                using (var stream = new FileStream("credential.json", FileMode.Open, FileAccess.Read))
                {
                    credential = GoogleCredential.FromStream(stream).CreateScoped(Scopes);
                }
                service = new SheetsService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });
            }
            public static List<string> GetSheetNames(string spreadsheetId)
            {
                SpreadsheetsResource.GetRequest request = service.Spreadsheets.Get(spreadsheetId);
                Spreadsheet spreadsheet = request.Execute();

                List<string> sheetNames = new List<string>();

                foreach (var sheet in spreadsheet.Sheets)
                {
                    sheetNames.Add(sheet.Properties.Title);
                }

                return sheetNames;
            }

            public static IList<Sheet> GetSheetList(string spreadsheetId)
            {
                Spreadsheet spreadsheet = service.Spreadsheets.Get(spreadsheetId).Execute();
                return spreadsheet.Sheets;
            }

            public static IList<IList<object>> ReadEntries(string spreadsheetId, string sheetName)
            {
                var range = $"{sheetName}!A1:C";
                SpreadsheetsResource.ValuesResource.GetRequest request = service.Spreadsheets.Values.Get(spreadsheetId, range);
                ValueRange response = request.Execute();
                IList<IList<object>> values = response.Values;

                return values;
            }
        }

        public class DatabaseHandler
        {
            private void addNewColumn(SqlConnection connection, string columnName, string tableName)
            {
                if (string.IsNullOrEmpty(tableName))
                {
                    MessageBox.Show("Vui lòng chọn bảng hợp lệ.");
                    return;
                }
                string checkColumnQuery = $@"
                    IF NOT EXISTS (SELECT * FROM sys.columns
                    WHERE Name = N'{columnName}' AND Object_ID = Object_ID (N'{tableName}'))
                    BEGIN
                        ALTER TABLE {tableName} ADD {columnName} INT
                    END";

                using (SqlCommand command = new SqlCommand(checkColumnQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            public void InsertData(IList<IList<object>> data, string scoreColumn, string tableName)
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-0TUPAG2\QUANGTRUNG;Initial Catalog=db_DSSV_1;User ID=sa; Password=1easygame"))
                {
                    connection.Open();
                    addNewColumn(connection, scoreColumn, tableName);

                    foreach (var row in data)
                    {
                        if (row.Count > 0)
                        {
                            string cmdText = $@"
                                IF EXISTS (SELECT 1 FROM {tableName} WHERE MSSV = @MSSV)
                                BEGIN
                                    UPDATE {tableName} SET {scoreColumn} = @Diem WHERE MSSV = @MSSV
                                END
                                ELSE
                                BEGIN
                                    INSERT INTO {tableName} (MSSV, HoVaTen, {scoreColumn}) 
                                    VALUES (@MSSV, @HoVaTen, @Diem)
                                END";

                            using (SqlCommand cmd = new SqlCommand(cmdText, connection))
                            {
                                cmd.Parameters.AddWithValue("@MSSV", row[0]);
                                cmd.Parameters.AddWithValue("@HoVaTen", row[1]);
                                cmd.Parameters.AddWithValue("@Diem", row.Count > 2 && !string.IsNullOrEmpty(row[2]?.ToString()) ? row[2] : DBNull.Value);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            string spreadsheetId = txtSheetLink.Text;
            string selectedSheet = cbo_Sheet.SelectedItem.ToString();

            if (string.IsNullOrEmpty(spreadsheetId) || string.IsNullOrEmpty(selectedSheet))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }

            if (string.IsNullOrEmpty(selectedSheet))
            {
                MessageBox.Show("Vui lòng chọn một sheet từ danh sách.");
                return;
            }

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            GoogleSheetsReader.InitializeGoogleSheets();
            IList<IList<object>> data = GoogleSheetsReader.ReadEntries(spreadsheetId, selectedSheet);

            if (data != null && data.Count > 0)
            {
                var headers = data[0];
                foreach (var header in headers)
                {
                    dataGridView1.Columns.Add(header.ToString(), header.ToString());
                }
                for (int i = 1; i < data.Count; i++)
                {
                    dataGridView1.Rows.Add(data[i].ToArray());
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu từ Google Sheets.");
            }
        }

        private void LoadTableNamesFromSQL()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-0TUPAG2\QUANGTRUNG;Initial Catalog=db_DSSV_1;User ID=sa; Password=1easygame"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT table_name FROM information_schema.tables WHERE table_type = 'BASE TABLE'";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        cboTableName.Items.Clear();
                        while (reader.Read())
                        {
                            cboTableName.Items.Add(reader["table_name"].ToString());
                        }
                        reader.Close();

                        if (cboTableName.Items.Count > 0)
                        {
                            cboTableName.SelectedIndex = 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải danh sách bảng từ SQL: " + ex.Message);
                }
            }
        }

        private int calculateScore(string correctAnswer, string studentAnswer)
        {
            string[] correctAnswers = correctAnswer.Split(',');
            string[] studentAnswers = studentAnswer.Split(',');

            int score = 0;
            for (int i = 0; i < correctAnswers.Length && i < studentAnswers.Length; i++)
            {
                if (correctAnswers[i].Trim() == studentAnswers[i].Trim())
                {
                    score++;
                }
            }

            return score;
        }

        private void checkStudy()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    int pointCheck = 0;
                    for (int i = 2; i < dataGridView1.Columns.Count; i++)
                    {
                        var cellValue = row.Cells[i].Value;
                        if (cellValue == null || string.IsNullOrEmpty(cellValue.ToString()))
                        {
                            pointCheck ++;
                        }
                    }
                    if (pointCheck == 2)
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else if (pointCheck == 3)
                    {
                        row.DefaultCellStyle.BackColor = Color.Orange;
                    }
                    else if (pointCheck > 3)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }

        private int getCurrentSaveCount(SqlConnection connection)
        {
            if (cboTableName.SelectedItem == null)
            {
                return 0;
            }

            string selectedTable = cboTableName.SelectedItem.ToString();
            string query = @"
                SELECT COUNT(*) 
                FROM sys.columns 
                WHERE Name LIKE 'DiemLan%' 
                AND Object_ID = Object_ID('{selectedTable}')";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                return (int)command.ExecuteScalar();
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string correctAnswer = txtMaDapAn.Text;
            string spreadsheetId = txtSheetLink.Text;
            string selectedSheet = cbo_Sheet.SelectedItem.ToString();
            string selectedTable = cboTableName.SelectedItem.ToString();

            if (selectedSheet == null)
            {
                MessageBox.Show("Vui lòng chọn Sheet muốn lưu");
            }

            if (string.IsNullOrEmpty(selectedTable))
            {
                MessageBox.Show("Vui lòng chọn bảng để lưu dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra định dạng "1A,2B,3C,..."
            string pattern = @"^(\d+[A-Z])(,\d+[A-Z])*$";
            string scoreColumn = "DiemLan" + saveCount;
            List<IList<object>> data = new List<IList<object>>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    string mssv = row.Cells[0].Value.ToString();
                    string hoVaTen = row.Cells[1].Value.ToString();
                    string studentAnswer = row.Cells[2].Value?.ToString();
                    if (mssv == null || hoVaTen == null)
                    {
                        MessageBox.Show("Lỗi định dạng dữ liệu đưa vào", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (studentAnswer == null)
                    {
                        int score = 10;
                        List<object> rowData = new List<object>
                            {
                                mssv,
                                hoVaTen,
                                score
                            };
                        data.Add(rowData);
                    }
                    else if (studentAnswer == "x")
                    {
                        int? score = null;
                        List<object> rowData = new List<object>
                            {
                                mssv,
                                hoVaTen,
                                score
                            };
                        data.Add(rowData);
                    }
                    else if (!string.IsNullOrEmpty(studentAnswer))
                    {
                        if (!Regex.IsMatch(correctAnswer, pattern))
                        {
                            errorProvider1.SetError(txtMaDapAn, "Đáp án phải có định dạng 1A,2B,3C,...");
                            return;
                        }
                        else
                        {
                            errorProvider1.SetError(txtMaDapAn, "");
                        }

                        if (string.IsNullOrEmpty(correctAnswer))
                        {
                            MessageBox.Show("Vui lòng nhập đáp án!");
                            return;
                        }
                        int score = calculateScore(correctAnswer, studentAnswer);
                        List<object> rowData = new List<object>
                            {
                                mssv,
                                hoVaTen,
                                score
                            };
                        data.Add(rowData);
                    }
                }
            }
            DatabaseHandler dbHandler = new DatabaseHandler();
            dbHandler.InsertData(data, scoreColumn, selectedTable);
            MessageBox.Show($"Đã thêm dữ liệu thành công vào cột {scoreColumn}");
            saveCount++;
        }
        private void txtSheetLink_TextChanged(object sender, EventArgs e)
        {
            string spreadsheetId = txtSheetLink.Text;
            if (!string.IsNullOrEmpty(spreadsheetId))
            {
                try
                {
                    GoogleSheetsReader.InitializeGoogleSheets();

                    // Lấy danh sách các sheet trong bảng tính
                    List<string> sheetNames = GoogleSheetsReader.GetSheetNames(spreadsheetId);
                    cbo_Sheet.Items.Clear();

                    if (sheetNames.Count > 0)
                    {
                        foreach (string sheetName in sheetNames)
                        {
                            cbo_Sheet.Items.Add(sheetName);
                        }
                        // Chọn sheet đầu tiên mặc định
                        cbo_Sheet.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Không có sheet nào trong bảng tính này.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải danh sách sheet: {ex.Message}");
                }
            }
        }
        private void btnXemDS_Click(object sender, EventArgs e)
        {
            btnXemDS_Click(sender, e, connection);
        }

        private void btnXemDS_Click(object sender, EventArgs e, SqlConnection connection)
        {
            if (cboTableName.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn bảng để xem dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string selectedTable = cboTableName.SelectedItem.ToString();

            try
            {
                string query = $"SELECT * FROM {selectedTable}";
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                checkStudy();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void txtMaDapAn_Enter(object sender, EventArgs e)
        {
            if (txtMaDapAn.Text == "VD: 1A,2B,3C,....")
            {
                txtMaDapAn.Text = "";
                txtMaDapAn.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtMaDapAn_Leave(object sender, EventArgs e)
        {
            if (txtMaDapAn.Text == "")
            {
                txtMaDapAn.Text = "VD: 1A,2B,3C,....";
                txtMaDapAn.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2) 
            {
                if (e.Value != null)
                {
                    string value = e.Value.ToString().Trim();
                    if (value.Equals("x", StringComparison.OrdinalIgnoreCase))
                    {
                        e.CellStyle.BackColor = Color.Yellow; 
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.White; 
                    }
                }
            }
        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            string newTableName = txtTableName.Text;

            if (string.IsNullOrEmpty(newTableName))
            {
                MessageBox.Show("Vui lòng nhập tên bảng để tạo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                CreateNewTableInSQL(newTableName);
                MessageBox.Show($"Bảng '{newTableName}' đã được tạo thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadTableNamesFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo bảng: " + ex.Message);
            }
        }

        private void CreateNewTableInSQL(string tableName)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-0TUPAG2\QUANGTRUNG;Initial Catalog=db_DSSV_1;User ID=sa; Password=1easygame"))
            {
                connection.Open();
                string createTableQuery = $@"
                    CREATE TABLE {tableName} (
                        MSSV NVARCHAR(50) PRIMARY KEY,
                        HoVaTen NVARCHAR(100)
                    )";

                using (SqlCommand cmd = new SqlCommand(createTableQuery, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    string tableName = cboTableName.SelectedItem.ToString();
                    saveFileDialog.Filter = "Excel (.xlsx)|*.xlsx|Excel (.xls)|*.xls";
                    saveFileDialog.Title = "Lưu file Excel";
                    saveFileDialog.FileName = $"{tableName}.xlsx"; 

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Sheet1");

                            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            {
                                worksheet.Cell(1, i + 1).Value = dataGridView1.Columns[i].HeaderText;
                            }

                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = dataGridView1.Rows[i].Cells[j].Value?.ToString();
                                }
                            }

                            try
                            {
                                workbook.SaveAs(filePath);
                                MessageBox.Show($"Dữ liệu đã được xuất thành công ra file: {filePath}");
                            }
                            catch (IOException ex)
                            {
                                MessageBox.Show("Lỗi khi lưu file: " + ex.Message);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất.");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string selectedTable = cboTableName.SelectedItem.ToString();
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-0TUPAG2\QUANGTRUNG;Initial Catalog=db_DSSV_1;User ID=sa; Password=1easygame"))
            {
                connection.Open();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string mssv = row.Cells["MSSV"].Value.ToString();

                    if (!string.IsNullOrEmpty(mssv))
                    {
                        // Tạo câu truy vấn UPDATE với các cột được thay đổi
                        List<string> updateFields = new List<string>();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;

                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            // Lấy tên cột
                            string columnName = dataGridView1.Columns[i].Name;

                            // Kiểm tra nếu giá trị cột này đã thay đổi
                            if (row.Cells[i].Value != null && row.Cells[i].Value.ToString() != row.Cells[i].Tag?.ToString())
                            {
                                // Thêm cột vào danh sách update
                                updateFields.Add($"{columnName} = @{columnName}");
                                cmd.Parameters.AddWithValue($"@{columnName}", row.Cells[i].Value ?? DBNull.Value);
                            }
                        }

                        if (updateFields.Count > 0)
                        {
                            string updateQuery = $@"
                                UPDATE {selectedTable}
                                SET {string.Join(", ", updateFields)}
                                WHERE MSSV = @MSSV";

                            cmd.CommandText = updateQuery;
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                MessageBox.Show("Cập nhật thành công!", "Thông báo");
            }
        }


    }
}
