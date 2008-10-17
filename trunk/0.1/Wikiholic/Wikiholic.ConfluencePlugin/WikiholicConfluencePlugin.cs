using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using OpenCS.Common.Action;
using OpenCS.Common.Plugin;

namespace Wikiholic.ConfluencePlugin
{
    public class WikiholicConfluencePlugin : BasePlugin
    {
        public override string Title
        {
            get { return "Wikiholic.Confluence"; }
        }

        public override Version Version
        {
            get { return new Version(FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion); }
        }

        public override void Init()
        {
        }

        public override void Deinit()
        {
        }

        public override ActionResult HandleAction(IAction action)
        {
            return ActionResult.NotHandled;
        }

    }
}
