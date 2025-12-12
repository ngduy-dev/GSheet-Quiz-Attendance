namespace quizGame
{
    partial class FormMoDau
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
            this.btnCreateQR = new System.Windows.Forms.Button();
            this.btnTaodethi = new System.Windows.Forms.Button();
            this.btnDS = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateQR
            // 
            this.btnCreateQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateQR.ForeColor = System.Drawing.Color.Black;
            this.btnCreateQR.Location = new System.Drawing.Point(323, 703);
            this.btnCreateQR.Name = "btnCreateQR";
            this.btnCreateQR.Size = new System.Drawing.Size(154, 55);
            this.btnCreateQR.TabIndex = 4;
            this.btnCreateQR.Text = "Bài thi";
            this.btnCreateQR.UseVisualStyleBackColor = true;
            this.btnCreateQR.Click += new System.EventHandler(this.btnCreateQR_Click);
            // 
            // btnTaodethi
            // 
            this.btnTaodethi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaodethi.ForeColor = System.Drawing.Color.Black;
            this.btnTaodethi.Location = new System.Drawing.Point(526, 703);
            this.btnTaodethi.Name = "btnTaodethi";
            this.btnTaodethi.Size = new System.Drawing.Size(154, 55);
            this.btnTaodethi.TabIndex = 5;
            this.btnTaodethi.Text = "Tạo đề thi";
            this.btnTaodethi.UseVisualStyleBackColor = true;
            this.btnTaodethi.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDS
            // 
            this.btnDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDS.ForeColor = System.Drawing.Color.Black;
            this.btnDS.Location = new System.Drawing.Point(729, 703);
            this.btnDS.Name = "btnDS";
            this.btnDS.Size = new System.Drawing.Size(154, 55);
            this.btnDS.TabIndex = 6;
            this.btnDS.Text = "Danh sách sinh viên";
            this.btnDS.UseVisualStyleBackColor = true;
            this.btnDS.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblWelcome.Image = global::quizGame.Properties.Resources.background;
            this.lblWelcome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblWelcome.Location = new System.Drawing.Point(2, -2);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(1215, 826);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Chào mừng quý thầy cô đang sử dụng phần mềm điểm danh của công ty TNHH TDDDN";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // FormMoDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1217, 824);
            this.Controls.Add(this.btnDS);
            this.Controls.Add(this.btnTaodethi);
            this.Controls.Add(this.btnCreateQR);
            this.Controls.Add(this.lblWelcome);
            this.ForeColor = System.Drawing.Color.Cyan;
            this.IsMdiContainer = true;
            this.Name = "FormMoDau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm điểm danh cho giảng viên";
            this.Load += new System.EventHandler(this.FormMoDau_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnCreateQR;
        private System.Windows.Forms.Button btnTaodethi;
        private System.Windows.Forms.Button btnDS;
    }
}