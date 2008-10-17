using System;
using System.Collections.Generic;
using System.Text;
using OpenCS.RBP;
using OpenCS.Common.Action;
using WeifenLuo.WinFormsUI.Docking;
using System.Diagnostics;
using System.Reflection;

namespace WikiholicPlugin
{
    public class WikiholicPlugin : BaseToggleableRbpPlugin
    {
        public override string Title
        {
            get { return "WikiholicPlugin"; }
        }

        public override Version Version
        {
            get { return new Version(FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion); }
        }

        public override void Init()
        {
            InitToggleableResources(new DockContentWikiholic(), DockState.DockLeft, Properties.Resources.Wikipedia_icon);
        }

        public override void Deinit()
        {
            DeinitToggleableResources();
        }

        public override ActionResult HandleAction(IAction action)
        {
            ActionResult result = ActionResult.NotHandled;

            result = HandleShowAction(action);
            if (result != ActionResult.NotHandled)
            {
                return result;
            }

            return result;
        }
    }
}
