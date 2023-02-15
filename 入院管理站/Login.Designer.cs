namespace 入院管理站
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_No = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tbx_No = new System.Windows.Forms.TextBox();
            this.tbx_Password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_No
            // 
            this.lbl_No.AutoSize = true;
            this.lbl_No.Location = new System.Drawing.Point(25, 62);
            this.lbl_No.Name = "lbl_No";
            this.lbl_No.Size = new System.Drawing.Size(62, 18);
            this.lbl_No.TabIndex = 0;
            this.lbl_No.Text = "登录：";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(25, 124);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(62, 18);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "密码：";
            this.lbl_Password.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbx_No
            // 
            this.tbx_No.Location = new System.Drawing.Point(107, 52);
            this.tbx_No.Name = "tbx_No";
            this.tbx_No.Size = new System.Drawing.Size(195, 28);
            this.tbx_No.TabIndex = 2;
            // 
            // tbx_Password
            // 
            this.tbx_Password.Location = new System.Drawing.Point(107, 114);
            this.tbx_Password.Name = "tbx_Password";
            this.tbx_Password.Size = new System.Drawing.Size(195, 28);
            this.tbx_Password.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 288);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbx_Password);
            this.Controls.Add(this.tbx_No);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_No);
            this.Name = "Login";
            this.Text = "登陆界面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_No;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox tbx_No;
        private System.Windows.Forms.TextBox tbx_Password;
        private System.Windows.Forms.Button button1;
    }
}

