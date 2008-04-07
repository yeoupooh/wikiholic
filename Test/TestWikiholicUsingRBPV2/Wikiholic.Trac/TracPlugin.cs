using System;
using System.Collections.Generic;
using System.Text;
using OpenCS.Common.Plugin;
using OpenCS.RBP;
using OpenCS.Common.Action;
using System.Diagnostics;
using WeifenLuo.WinFormsUI.Docking;

namespace Wikiholic.Trac
{
    public class TracPlugin : BaseRbpPlugin
    {
        public override void Init()
        {
            DCTrac dc = new DCTrac();
            dc.Show(m_rbc.DockPanel, DockState.DockLeft);
        }

        public override void Deinit()
        {
        }

        public override ActionResult HandleAction(IAction action)
        {
            return ActionResult.NotHandled;
        }

        public override string Title
        {
            get { return "TracPlugin"; }
        }

        public override Version Version
        {
            get { return new Version("0.1.1.1"); }
        }
    }
}
