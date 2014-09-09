using System;
using System.Linq;
using DevExpress.XtraEditors;
using System.Collections.Generic;

namespace WinFrameworkTools
{
    public partial class ModuleDialog : XtraForm
    {
        private readonly int _middle;
        private readonly int _bottom;
        public ModuleDialog()
        {
            InitializeComponent();
            checkSubModule.Checked = false;
            _middle = comboModules.Top;
            _bottom = checkSubModule.Top;
            ToggleDisplay();
        }

        private void ToggleDisplay()
        {
            if (checkSubModule.Checked)
            {
                checkSubModule.Top = _bottom;
                buttonCancel.Top = _bottom;
                buttonOK.Top = _bottom;
                comboModules.Visible = true;
                if (comboModules.Properties.Items.Count > 0)
                    comboModules.SelectedIndex = 0;
                Height = 137;
                
            }
            else
            {
                checkSubModule.Top = _middle;
                buttonCancel.Top = _middle;
                buttonOK.Top = _middle;
                comboModules.Visible = false;
                Height = 137 - buttonOK.Height;
            }
        }

        public string ModuleName
        {
            get
            {
                if (IsSubModule)
                    return comboModules.SelectedItem.ToString();
                else
                    return textName.Text;
            }
        }

        public bool IsSubModule
        {
            get
            {
                return checkSubModule.Checked;
            }
        }

        public string SubModuleName
        {
            get
            {
                if (IsSubModule)
                    return textName.Text;
                else
                    return "";
            }
        }

        public void SetModules(IEnumerable<string> modules)
        {
            comboModules.Properties.Items.Clear();
            comboModules.Properties.Items.AddRange(modules.ToArray());
            if (comboModules.Properties.Items.Count == 0)
                checkSubModule.Visible = false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void checkSubModule_CheckedChanged(object sender, EventArgs e)
        {
            ToggleDisplay();
        }
    }
}
