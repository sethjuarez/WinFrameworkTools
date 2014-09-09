using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.CodeRush.Core;
using System.Collections.Generic;
using Microsoft.VisualStudio.TemplateWizard;

namespace WinFrameworkTools
{
    public class MainModuleWizard : IWizard
    {
        public void BeforeOpeningFile(EnvDTE.ProjectItem projectItem)
        {
            
        }

        public void ProjectFinishedGenerating(EnvDTE.Project project)
        {
            
        }

        public void ProjectItemFinishedGenerating(EnvDTE.ProjectItem projectItem)
        {
            
        }

        public void RunFinished()
        {
            if (!string.IsNullOrEmpty(_module))
                Helpers.AddEnumItem("ModuleType", _module);
        }

        private bool _shouldRun = true;
        private string _module = string.Empty;
        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            MainModuleDialog dialog = new MainModuleDialog();
            _module = string.Empty;
            _shouldRun = dialog.ShowDialog() == DialogResult.OK;
            if (_shouldRun)
            {
                _module = dialog.ModuleName;
                replacementsDictionary.Add("$module$", _module);
                _shouldRun = true;
            }
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return _shouldRun;
        }
    }
}
