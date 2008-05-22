namespace Wikiholic.Trac
{
    partial class DCTrac
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxPageContent = new System.Windows.Forms.TextBox();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.checkBoxUseCredential = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "get all pages";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 12;
            this.lstOutput.Location = new System.Drawing.Point(12, 117);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(479, 112);
            this.lstOutput.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "get page";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxPageContent
            // 
            this.textBoxPageContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPageContent.Location = new System.Drawing.Point(12, 264);
            this.textBoxPageContent.Multiline = true;
            this.textBoxPageContent.Name = "textBoxPageContent";
            this.textBoxPageContent.Size = new System.Drawing.Size(479, 292);
            this.textBoxPageContent.TabIndex = 3;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUrl.Location = new System.Drawing.Point(12, 12);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(479, 21);
            this.textBoxUrl.TabIndex = 4;
            this.textBoxUrl.Text = "http://localhost:8080/projects/HelloTOW";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(12, 61);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 21);
            this.textBoxUsername.TabIndex = 5;
            this.textBoxUsername.Text = "admin";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(121, 61);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(100, 21);
            this.textBoxPassword.TabIndex = 6;
            this.textBoxPassword.Text = "towadmin";
            // 
            // checkBoxUseCredential
            // 
            this.checkBoxUseCredential.AutoSize = true;
            this.checkBoxUseCredential.Checked = true;
            this.checkBoxUseCredential.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUseCredential.Location = new System.Drawing.Point(12, 39);
            this.checkBoxUseCredential.Name = "checkBoxUseCredential";
            this.checkBoxUseCredential.Size = new System.Drawing.Size(105, 16);
            this.checkBoxUseCredential.TabIndex = 7;
            this.checkBoxUseCredential.Text = "Use credential";
            this.checkBoxUseCredential.UseVisualStyleBackColor = true;
            this.checkBoxUseCredential.CheckedChanged += new System.EventHandler(this.checkBoxUseCredential_CheckedChanged);
            // 
            // DCTrac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 568);
            this.Controls.Add(this.checkBoxUseCredential);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.textBoxPageContent);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.button1);
            this.Name = "DCTrac";
            this.TabText = "DCTrac";
            this.Text = "DCTrac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxPageContent;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.CheckBox checkBoxUseCredential;
    }
}