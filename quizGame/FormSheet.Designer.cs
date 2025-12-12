namespace quizGame
{
    partial class FormSheet
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSheetLink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.cbo_Sheet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDapAn = new System.Windows.Forms.Label();
            this.txtMaDapAn = new System.Windows.Forms.TextBox();
            this.btnXemDS = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTaoTable = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.lblChonLop = new System.Windows.Forms.Label();
            this.cboTableName = new System.Windows.Forms.ComboBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txt_sobuoinghi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1063, 565);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // txtSheetLink
            // 
            this.txtSheetLink.Location = new System.Drawing.Point(192, 22);
            this.txtSheetLink.Name = "txtSheetLink";
            this.txtSheetLink.Size = new System.Drawing.Size(447, 22);
            this.txtSheetLink.TabIndex = 1;
            this.txtSheetLink.TextChanged += new System.EventHandler(this.txtSheetLink_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đường dẫn Sheet";
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(667, 22);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(119, 33);
            this.btnNhap.TabIndex = 3;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(69, 190);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(119, 33);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cbo_Sheet
            // 
            this.cbo_Sheet.FormattingEnabled = true;
            this.cbo_Sheet.Location = new System.Drawing.Point(192, 62);
            this.cbo_Sheet.Name = "cbo_Sheet";
            this.cbo_Sheet.Size = new System.Drawing.Size(148, 24);
            this.cbo_Sheet.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sheet";
            // 
            // lblDapAn
            // 
            this.lblDapAn.AutoSize = true;
            this.lblDapAn.Location = new System.Drawing.Point(64, 153);
            this.lblDapAn.Name = "lblDapAn";
            this.lblDapAn.Size = new System.Drawing.Size(71, 16);
            this.lblDapAn.TabIndex = 8;
            this.lblDapAn.Text = "Mã đáp án";
            // 
            // txtMaDapAn
            // 
            this.txtMaDapAn.ForeColor = System.Drawing.Color.Gray;
            this.txtMaDapAn.Location = new System.Drawing.Point(192, 150);
            this.txtMaDapAn.Name = "txtMaDapAn";
            this.txtMaDapAn.Size = new System.Drawing.Size(447, 22);
            this.txtMaDapAn.TabIndex = 7;
            this.txtMaDapAn.Text = "VD: 1A,2B,3C,....";
            this.txtMaDapAn.Enter += new System.EventHandler(this.txtMaDapAn_Enter);
            this.txtMaDapAn.Leave += new System.EventHandler(this.txtMaDapAn_Leave);
            // 
            // btnXemDS
            // 
            this.btnXemDS.Location = new System.Drawing.Point(245, 190);
            this.btnXemDS.Name = "btnXemDS";
            this.btnXemDS.Size = new System.Drawing.Size(119, 33);
            this.btnXemDS.TabIndex = 9;
            this.btnXemDS.Text = "Xem Kết Quả";
            this.btnXemDS.UseVisualStyleBackColor = true;
            this.btnXemDS.Click += new System.EventHandler(this.btnXemDS_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblTaoTable
            // 
            this.lblTaoTable.AutoSize = true;
            this.lblTaoTable.Location = new System.Drawing.Point(66, 104);
            this.lblTaoTable.Name = "lblTaoTable";
            this.lblTaoTable.Size = new System.Drawing.Size(79, 16);
            this.lblTaoTable.TabIndex = 10;
            this.lblTaoTable.Text = "Tạo lớp mới";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(194, 104);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(447, 22);
            this.txtTableName.TabIndex = 11;
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Location = new System.Drawing.Point(667, 99);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(119, 33);
            this.btnCreateTable.TabIndex = 12;
            this.btnCreateTable.Text = "Tạo lớp mới";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // lblChonLop
            // 
            this.lblChonLop.AutoSize = true;
            this.lblChonLop.Location = new System.Drawing.Point(425, 65);
            this.lblChonLop.Name = "lblChonLop";
            this.lblChonLop.Size = new System.Drawing.Size(60, 16);
            this.lblChonLop.TabIndex = 14;
            this.lblChonLop.Text = "Chọn lớp";
            // 
            // cboTableName
            // 
            this.cboTableName.FormattingEnabled = true;
            this.cboTableName.Location = new System.Drawing.Point(491, 62);
            this.cboTableName.Name = "cboTableName";
            this.cboTableName.Size = new System.Drawing.Size(148, 24);
            this.cboTableName.TabIndex = 13;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(428, 190);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(119, 33);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "Xuất file Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(635, 190);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(119, 33);
            this.btnCapNhat.TabIndex = 16;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txt_sobuoinghi
            // 
            this.txt_sobuoinghi.Location = new System.Drawing.Point(835, 67);
            this.txt_sobuoinghi.Name = "txt_sobuoinghi";
            this.txt_sobuoinghi.Size = new System.Drawing.Size(100, 22);
            this.txt_sobuoinghi.TabIndex = 17;
            this.txt_sobuoinghi.TextChanged += new System.EventHandler(this.txt_sobuoinghi_TextChanged);
            // 
            // FormSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 824);
            this.Controls.Add(this.txt_sobuoinghi);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblChonLop);
            this.Controls.Add(this.cboTableName);
            this.Controls.Add(this.btnCreateTable);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.lblTaoTable);
            this.Controls.Add(this.btnXemDS);
            this.Controls.Add(this.lblDapAn);
            this.Controls.Add(this.txtMaDapAn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_Sheet);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSheetLink);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormSheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho lưu trữ danh sách sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSheetLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ComboBox cbo_Sheet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDapAn;
        private System.Windows.Forms.TextBox txtMaDapAn;
        private System.Windows.Forms.Button btnXemDS;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label lblTaoTable;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.Label lblChonLop;
        private System.Windows.Forms.ComboBox cboTableName;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txt_sobuoinghi;
    }
}