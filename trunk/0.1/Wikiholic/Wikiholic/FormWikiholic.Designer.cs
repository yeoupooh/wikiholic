namespace Wikiholic
{
    partial class FormWikiholic
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
            OpenCS.Common.Logging.ConsoleLogger consoleLogger2 = new OpenCS.Common.Logging.ConsoleLogger();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWikiholic));
            this.richBrowserControl1 = new OpenCS.RBP.Controls.RichBrowserControl();
            this.SuspendLayout();
            // 
            // richBrowserControl1
            // 
            this.richBrowserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richBrowserControl1.ExecutingPath = null;
            this.richBrowserControl1.Location = new System.Drawing.Point(0, 0);
            consoleLogger2.HasUI = false;
            consoleLogger2.LevelOptions = OpenCS.Common.Logging.LogLevelOptions.None;
            consoleLogger2.UIOption = OpenCS.Common.Logging.LogUIOption.All;
            this.richBrowserControl1.Logger = consoleLogger2;
            this.richBrowserControl1.Name = "richBrowserControl1";
            this.richBrowserControl1.ShowAddressToolStrip = true;
            this.richBrowserControl1.ShowMenuStrip = true;
            this.richBrowserControl1.ShowSearchToolStrip = false;
            this.richBrowserControl1.ShowStatusStrip = true;
            this.richBrowserControl1.ShowWebToolStrip = true;
            this.richBrowserControl1.Size = new System.Drawing.Size(741, 346);
            this.richBrowserControl1.TabIndex = 0;
            // 
            // FormWikiholic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 346);
            this.Controls.Add(this.richBrowserControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWikiholic";
            this.Text = "Wikiholic";
            this.ResumeLayout(false);

        }

        #endregion

        private OpenCS.RBP.Controls.RichBrowserControl richBrowserControl1;
    }
}

