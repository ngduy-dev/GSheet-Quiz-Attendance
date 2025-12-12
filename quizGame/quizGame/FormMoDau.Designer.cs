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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMoDau));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnCreateQR = new System.Windows.Forms.Button();
            this.btnTaodethi = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Yellow;
            this.lblWelcome.Image = ((System.Drawing.Image)(resources.GetObject("lblWelcome.Image")));
            this.lblWelcome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblWelcome.Location = new System.Drawing.Point(-1, -1);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(1215, 826);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Chào mừng quý thầy cô đang sử dụng phần mềm điểm danh của công ty TNHH TDDDN";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // btnCreateQR
            // 
            this.btnCreateQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateQR.ForeColor = System.Drawing.Color.Black;
            this.btnCreateQR.Location = new System.Drawing.Point(323, 703);
            this.btnCreateQR.Name = "btnCreateQR";
            this.btnCreateQR.Size = new System.Drawing.Size(154, 55);
            this.btnCreateQR.TabIndex = 4;
            this.btnCreateQR.Text = "Tạo Mã QR";
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
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(729, 703);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 55);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormMoDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1217, 824);
            this.Controls.Add(this.button3);
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
        private System.Windows.Forms.Button button3;
    }
}