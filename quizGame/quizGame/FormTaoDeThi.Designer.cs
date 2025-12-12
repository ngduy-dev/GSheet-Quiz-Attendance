namespace quizGame
{
    partial class FormTaoDeThi
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
            this.btnTructiep = new System.Windows.Forms.Button();
            this.btnGiantiep = new System.Windows.Forms.Button();
            this.lblGioithieu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTructiep
            // 
            this.btnTructiep.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTructiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTructiep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTructiep.Location = new System.Drawing.Point(65, 186);
            this.btnTructiep.Name = "btnTructiep";
            this.btnTructiep.Size = new System.Drawing.Size(215, 60);
            this.btnTructiep.TabIndex = 0;
            this.btnTructiep.Text = "Tạo đề thi trực tiếp";
            this.btnTructiep.UseVisualStyleBackColor = false;
            this.btnTructiep.Click += new System.EventHandler(this.btnTructiep_Click);
            // 
            // btnGiantiep
            // 
            this.btnGiantiep.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGiantiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiantiep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGiantiep.Location = new System.Drawing.Point(388, 186);
            this.btnGiantiep.Name = "btnGiantiep";
            this.btnGiantiep.Size = new System.Drawing.Size(215, 60);
            this.btnGiantiep.TabIndex = 1;
            this.btnGiantiep.Text = "Tạo đề thi từ file .txt";
            this.btnGiantiep.UseVisualStyleBackColor = false;
            this.btnGiantiep.Click += new System.EventHandler(this.btnGiantiep_Click);
            // 
            // lblGioithieu
            // 
            this.lblGioithieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioithieu.Location = new System.Drawing.Point(132, 32);
            this.lblGioithieu.Name = "lblGioithieu";
            this.lblGioithieu.Size = new System.Drawing.Size(397, 93);
            this.lblGioithieu.TabIndex = 2;
            this.lblGioithieu.Text = "Hãy chọn phương thức tạo đề thi";
            this.lblGioithieu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTaoDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 357);
            this.Controls.Add(this.lblGioithieu);
            this.Controls.Add(this.btnGiantiep);
            this.Controls.Add(this.btnTructiep);
            this.Name = "FormTaoDeThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTaoDeThi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTructiep;
        private System.Windows.Forms.Button btnGiantiep;
        private System.Windows.Forms.Label lblGioithieu;
    }
}