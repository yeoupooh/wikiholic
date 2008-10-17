using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using OpenCS.RBP;
using OpenCS.Common.Action;
using OpenCS.Common.Plugin;

namespace WikiholicPlugin
{
    public partial class DockContentWikiholic : DockContent, IToggleableDockContent
    {
        public DockContentWikiholic()
        {
            InitializeComponent();
        }

        #region IToggleableDockContent 멤버

        public IActionHandler ActionHandler
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                ;
            }
        }

        public IPlugin Plugin
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                ;
            }
        }

        public IRichBrowserControl RichBrowserControl
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                ;
            }
        }

        #endregion
    }
}