using System;
using System.Linq;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFrameworkTools
{
    public partial class MainModuleDialog : XtraForm
    {
        public MainModuleDialog()
        {
            InitializeComponent();
        }

        public string ModuleName
        {
            get { return textName.Text; }
        }
        
        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
