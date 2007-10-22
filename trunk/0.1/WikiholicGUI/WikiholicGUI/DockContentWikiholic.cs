using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace WikiholicGUI
{
    public partial class DockContentWikiholic : DockContent
    {
        public ToolStrip ts { get { return toolStrip1; } }

        public ToolStripButton btAddServer { get { return toolStripButton1; } }
        public ToolStripButton btEditServer { get { return toolStripButton2; } }
        public ToolStripButton btRemoveServer { get { return toolStripButton3; } }

        public ToolStripButton btAddWiki { get { return toolStripButton4; } }
        public ToolStripButton btEditWiki { get { return toolStripButton5; } }
        public ToolStripButton btRemoveWiki { get { return toolStripButton6; } }

        public TreeView tv { get { return treeViewMain; } }

        public DockContentWikiholic()
        {
            InitializeComponent();
        }
    }
}
