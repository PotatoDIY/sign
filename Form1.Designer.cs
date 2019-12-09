namespace Sign
{
    partial class Sign
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
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.textBoxSignText = new System.Windows.Forms.TextBox();
            this.buttonSign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(12, 12);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(776, 214);
            this.textBoxText.TabIndex = 0;
            // 
            // textBoxSignText
            // 
            this.textBoxSignText.Location = new System.Drawing.Point(12, 324);
            this.textBoxSignText.Multiline = true;
            this.textBoxSignText.Name = "textBoxSignText";
            this.textBoxSignText.Size = new System.Drawing.Size(776, 134);
            this.textBoxSignText.TabIndex = 1;
            // 
            // buttonSign
            // 
            this.buttonSign.Location = new System.Drawing.Point(12, 244);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(776, 65);
            this.buttonSign.TabIndex = 2;
            this.buttonSign.Text = "Sign";
            this.buttonSign.UseVisualStyleBackColor = true;
            this.buttonSign.Click += new System.EventHandler(this.buttonSign_Click);
            // 
            // Sign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.buttonSign);
            this.Controls.Add(this.textBoxSignText);
            this.Controls.Add(this.textBoxText);
            this.Name = "Sign";
            this.Text = "Sign for RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.TextBox textBoxSignText;
        private System.Windows.Forms.Button buttonSign;
    }
}

