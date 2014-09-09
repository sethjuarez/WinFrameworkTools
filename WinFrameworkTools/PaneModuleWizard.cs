using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.CodeRush.Core;
using System.Collections.Generic;
using Microsoft.VisualStudio.TemplateWizard;

namespace WinFrameworkTools
{
    public class PaneModuleWizard : IWizard
    {
        private bool _shouldRun = true;
        private string _module = string.Empty;
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
            // add enum item after classes have
            // been generated
            if (!string.IsNullOrEmpty(_module))
                Helpers.AddEnumItem("ModuleType", _module);
        }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            PaneModuleDialog dialog = new PaneModuleDialog();
            dialog.SetModules(Helpers.GetModules(CodeRush.Source.ActiveProject));
            _module = string.Empty;

            _shouldRun = dialog.ShowDialog() == DialogResult.OK &&
                         !string.IsNullOrEmpty(dialog.ModuleName) &&
                         string.IsNullOrEmpty(dialog.SubModuleName);

            if (_shouldRun)
            {
                // add replacement items
                replacementsDictionary.Add("$module$", dialog.ModuleName);
                replacementsDictionary.Add("$sub$", dialog.SubModuleName);
                _module = dialog.ModuleName + dialog.SubModuleName;
                _shouldRun = true;
            }
        }


        public bool ShouldAddProjectItem(string filePath)
        {
            return _shouldRun;
        }
    }
}
