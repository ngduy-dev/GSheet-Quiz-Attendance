namespace quizGame
{
    partial class FormTaoDeThiTuFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChonfile = new System.Windows.Forms.Button();
            this.txtBrowser = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnImport = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblCauhoi = new System.Windows.Forms.Label();
            this.lblCauA = new System.Windows.Forms.Label();
            this.lblCauB = new System.Windows.Forms.Label();
            this.lblCauC = new System.Windows.Forms.Label();
            this.lblCauD = new System.Windows.Forms.Label();
            this.txtCauhoi = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChonfile
            // 
            this.btnChonfile.Location = new System.Drawing.Point(495, 57);
            this.btnChonfile.Name = "btnChonfile";
            this.btnChonfile.Size = new System.Drawing.Size(90, 29);
            this.btnChonfile.TabIndex = 0;
            this.btnChonfile.Text = "Chọn file";
            this.btnChonfile.UseVisualStyleBackColor = true;
            this.btnChonfile.Click += new System.EventHandler(this.btnChonfile_Click);
            // 
            // txtBrowser
            // 
            this.txtBrowser.Location = new System.Drawing.Point(63, 60);
            this.txtBrowser.Name = "txtBrowser";
            this.txtBrowser.Size = new System.Drawing.Size(412, 22);
            this.txtBrowser.TabIndex = 1;
            this.txtBrowser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 450);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1066, 302);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnImport
            // 
            this.btnImport.Enabled = false;
            this.btnImport.Location = new System.Drawing.Point(600, 57);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(90, 29);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // lblCauhoi
            // 
            this.lblCauhoi.AutoSize = true;
            this.lblCauhoi.Location = new System.Drawing.Point(63, 117);
            this.lblCauhoi.Name = "lblCauhoi";
            this.lblCauhoi.Size = new System.Drawing.Size(52, 16);
            this.lblCauhoi.TabIndex = 4;
            this.lblCauhoi.Text = "Câu hỏi";
            // 
            // lblCauA
            // 
            this.lblCauA.AutoSize = true;
            this.lblCauA.Location = new System.Drawing.Point(63, 164);
            this.lblCauA.Name = "lblCauA";
            this.lblCauA.Size = new System.Drawing.Size(19, 16);
            this.lblCauA.TabIndex = 5;
            this.lblCauA.Text = "A.";
            // 
            // lblCauB
            // 
            this.lblCauB.AutoSize = true;
            this.lblCauB.Location = new System.Drawing.Point(63, 211);
            this.lblCauB.Name = "lblCauB";
            this.lblCauB.Size = new System.Drawing.Size(19, 16);
            this.lblCauB.TabIndex = 6;
            this.lblCauB.Text = "B.";
            // 
            // lblCauC
            // 
            this.lblCauC.AutoSize = true;
            this.lblCauC.Location = new System.Drawing.Point(63, 258);
            this.lblCauC.Name = "lblCauC";
            this.lblCauC.Size = new System.Drawing.Size(19, 16);
            this.lblCauC.TabIndex = 7;
            this.lblCauC.Text = "C.";
            // 
            // lblCauD
            // 
            this.lblCauD.AutoSize = true;
            this.lblCauD.Location = new System.Drawing.Point(63, 305);
            this.lblCauD.Name = "lblCauD";
            this.lblCauD.Size = new System.Drawing.Size(20, 16);
            this.lblCauD.TabIndex = 8;
            this.lblCauD.Text = "D.";
            // 
            // txtCauhoi
            // 
            this.txtCauhoi.Enabled = false;
            this.txtCauhoi.Location = new System.Drawing.Point(164, 117);
            this.txtCauhoi.Name = "txtCauhoi";
            this.txtCauhoi.Size = new System.Drawing.Size(752, 22);
            this.txtCauhoi.TabIndex = 9;
            // 
            // txtA
            // 
            this.txtA.Enabled = false;
            this.txtA.Location = new System.Drawing.Point(164, 164);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(752, 22);
            this.txtA.TabIndex = 10;
            // 
            // txtB
            // 
            this.txtB.Enabled = false;
            this.txtB.Location = new System.Drawing.Point(164, 211);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(752, 22);
            this.txtB.TabIndex = 11;
            // 
            // txtC
            // 
            this.txtC.Enabled = false;
            this.txtC.Location = new System.Drawing.Point(164, 258);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(752, 22);
            this.txtC.TabIndex = 12;
            // 
            // txtD
            // 
            this.txtD.Enabled = false;
            this.txtD.Location = new System.Drawing.Point(164, 305);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(752, 22);
            this.txtD.TabIndex = 13;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(714, 401);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 30);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(824, 401);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 30);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(934, 401);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 30);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(1044, 401);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(85, 30);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // FormTaoDeThiTuFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1197, 779);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtCauhoi);
            this.Controls.Add(this.lblCauD);
            this.Controls.Add(this.lblCauC);
            this.Controls.Add(this.lblCauB);
            this.Controls.Add(this.lblCauA);
            this.Controls.Add(this.lblCauhoi);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBrowser);
            this.Controls.Add(this.btnChonfile);
            this.Name = "FormTaoDeThiTuFile";
            this.Text = "FormTaoDeThiTuFile";
            this.Load += new System.EventHandler(this.FormTaoDeThiTuFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChonfile;
        private System.Windows.Forms.TextBox txtBrowser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblCauhoi;
        private System.Windows.Forms.Label lblCauA;
        private System.Windows.Forms.Label lblCauB;
        private System.Windows.Forms.Label lblCauC;
        private System.Windows.Forms.Label lblCauD;
        private System.Windows.Forms.TextBox txtCauhoi;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
    }
}