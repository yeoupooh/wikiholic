using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WikiholicGUI
{
    public partial class FormServerInformation : Form
    {
        public ComboBox cbType { get { return comboBoxType; } }
        public ComboBox cbUrl { get { return comboBoxUrl; } }
        public Button btGo { get { return buttonGo; } }

        public TextBox tbUsername { get { return textBoxUsername; } }
        public TextBox tbPassword { get { return textBoxPassword; } }

        public Button btTest { get { return buttonTest; } }

        public CheckBox chkSavePassword { get { return checkBoxSavePassword; } }
        public CheckBox chkAutoLogin { get { return checkBoxAutoLogin; } }

        public Button btOK { get { return buttonOK; } }
        public Button btCancel { get { return buttonCancel; } }

        public FormServerInformation()
        {
            InitializeComponent();
        }
    }
}