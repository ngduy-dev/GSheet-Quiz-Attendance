namespace quizGame
{
    partial class FormTaoMaQR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaoMaQR));
            this.btnTaoQR = new System.Windows.Forms.Button();
            this.txtTaoQR = new System.Windows.Forms.TextBox();
            this.lblNhapDuongLink = new System.Windows.Forms.Label();
            this.pictureTaoQR = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblChonfile = new System.Windows.Forms.Label();
            this.txtChonfile = new System.Windows.Forms.TextBox();
            this.btnChonfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTaoQR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTaoQR
            // 
            this.btnTaoQR.Location = new System.Drawing.Point(910, 41);
            this.btnTaoQR.Name = "btnTaoQR";
            this.btnTaoQR.Size = new System.Drawing.Size(134, 45);
            this.btnTaoQR.TabIndex = 0;
            this.btnTaoQR.Text = "Tạo QR";
            this.btnTaoQR.UseVisualStyleBackColor = true;
            this.btnTaoQR.Click += new System.EventHandler(this.btnTaoQR_Click);
            // 
            // txtTaoQR
            // 
            this.txtTaoQR.Location = new System.Drawing.Point(433, 52);
            this.txtTaoQR.Name = "txtTaoQR";
            this.txtTaoQR.Size = new System.Drawing.Size(451, 22);
            this.txtTaoQR.TabIndex = 1;
            // 
            // lblNhapDuongLink
            // 
            this.lblNhapDuongLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapDuongLink.Location = new System.Drawing.Point(122, 29);
            this.lblNhapDuongLink.Name = "lblNhapDuongLink";
            this.lblNhapDuongLink.Size = new System.Drawing.Size(247, 65);
            this.lblNhapDuongLink.TabIndex = 2;
            this.lblNhapDuongLink.Text = "Đường dẫn muốn tạo QR";
            this.lblNhapDuongLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureTaoQR
            // 
            this.pictureTaoQR.Image = ((System.Drawing.Image)(resources.GetObject("pictureTaoQR.Image")));
            this.pictureTaoQR.Location = new System.Drawing.Point(433, 242);
            this.pictureTaoQR.Name = "pictureTaoQR";
            this.pictureTaoQR.Size = new System.Drawing.Size(386, 350);
            this.pictureTaoQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTaoQR.TabIndex = 3;
            this.pictureTaoQR.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(433, 654);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(386, 76);
            this.button1.TabIndex = 4;
            this.button1.Text = "Bắt đầu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblChonfile
            // 
            this.lblChonfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonfile.Location = new System.Drawing.Point(122, 112);
            this.lblChonfile.Name = "lblChonfile";
            this.lblChonfile.Size = new System.Drawing.Size(247, 65);
            this.lblChonfile.TabIndex = 7;
            this.lblChonfile.Text = "Chọn đề kiểm tra";
            this.lblChonfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtChonfile
            // 
            this.txtChonfile.Location = new System.Drawing.Point(433, 135);
            this.txtChonfile.Name = "txtChonfile";
            this.txtChonfile.Size = new System.Drawing.Size(451, 22);
            this.txtChonfile.TabIndex = 6;
            // 
            // btnChonfile
            // 
            this.btnChonfile.Location = new System.Drawing.Point(910, 124);
            this.btnChonfile.Name = "btnChonfile";
            this.btnChonfile.Size = new System.Drawing.Size(134, 45);
            this.btnChonfile.TabIndex = 5;
            this.btnChonfile.Text = "Chọn file";
            this.btnChonfile.UseVisualStyleBackColor = true;
            this.btnChonfile.Click += new System.EventHandler(this.btnChonfile_Click);
            // 
            // FormTaoMaQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 824);
            this.Controls.Add(this.lblChonfile);
            this.Controls.Add(this.txtChonfile);
            this.Controls.Add(this.btnChonfile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureTaoQR);
            this.Controls.Add(this.lblNhapDuongLink);
            this.Controls.Add(this.txtTaoQR);
            this.Controls.Add(this.btnTaoQR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormTaoMaQR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo Mã QR";
            ((System.ComponentModel.ISupportInitialize)(this.pictureTaoQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaoQR;
        private System.Windows.Forms.TextBox txtTaoQR;
        private System.Windows.Forms.Label lblNhapDuongLink;
        private System.Windows.Forms.PictureBox pictureTaoQR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblChonfile;
        private System.Windows.Forms.TextBox txtChonfile;
        private System.Windows.Forms.Button btnChonfile;
    }
}