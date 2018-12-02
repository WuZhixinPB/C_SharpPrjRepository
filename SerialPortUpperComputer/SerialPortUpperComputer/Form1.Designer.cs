namespace SerialPortUpperComputer
{
    partial class Form1
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
            this.Exit = new System.Windows.Forms.Button();
            this.Browse = new System.Windows.Forms.Button();
            this.createPRJ = new System.Windows.Forms.Button();
            this.textBoxShowSelectedPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(538, 328);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "退出";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(538, 284);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 1;
            this.Browse.Text = "浏览";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // createPRJ
            // 
            this.createPRJ.Location = new System.Drawing.Point(538, 247);
            this.createPRJ.Name = "createPRJ";
            this.createPRJ.Size = new System.Drawing.Size(75, 23);
            this.createPRJ.TabIndex = 2;
            this.createPRJ.Text = "生成项目";
            this.createPRJ.UseVisualStyleBackColor = true;
            this.createPRJ.Click += new System.EventHandler(this.createPRJ_Click);
            // 
            // textBoxShowSelectedPath
            // 
            this.textBoxShowSelectedPath.Location = new System.Drawing.Point(143, 286);
            this.textBoxShowSelectedPath.Name = "textBoxShowSelectedPath";
            this.textBoxShowSelectedPath.Size = new System.Drawing.Size(367, 21);
            this.textBoxShowSelectedPath.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 397);
            this.Controls.Add(this.textBoxShowSelectedPath);
            this.Controls.Add(this.createPRJ);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.Exit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Button createPRJ;
        private System.Windows.Forms.TextBox textBoxShowSelectedPath;
    }
}

