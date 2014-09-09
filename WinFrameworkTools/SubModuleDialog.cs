using System;
using System.Linq;
using DevExpress.XtraEditors;
using System.Collections.Generic;

namespace WinFrameworkTools
{
    public partial class SubModuleDialog : XtraForm
    {
        private readonly int _middle;
        private readonly int _bottom;
        public SubModuleDialog()
        {
            InitializeComponent();
        }


        public string ModuleName
        {
            get
            {

                return comboModules.SelectedItem.ToString();
            }
        }


        public string SubModuleName
        {
            get
            {
                return textName.Text;
            }
        }

        public void SetModules(IEnumerable<string> modules)
        {
            comboModules.Properties.Items.Clear();
            comboModules.Properties.Items.AddRange(modules.ToArray());
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
