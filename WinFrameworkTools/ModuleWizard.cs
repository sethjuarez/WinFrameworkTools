using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TemplateWizard;
using System.Windows.Forms;
using EnvDTE;
using System.IO;
using DevExpress.CodeRush.StructuralParser;
using DevExpress.CodeRush.Core;
using System.Linq;

namespace WinFrameworkTools
{
    public class ModuleWizard : IWizard
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
            if(!string.IsNullOrEmpty(_module))
                Helpers.AddEnumItem("ModuleType", _module);
        }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            ModuleDialog dialog = new ModuleDialog();
            dialog.SetModules(Helpers.GetModules(CodeRush.Source.ActiveProject));
            _module = string.Empty;

            _shouldRun = dialog.ShowDialog() == DialogResult.OK;

            if(_shouldRun)
            {
                _module = dialog.ModuleName;
                replacementsDictionary.Add("$module$", _module);
                if(dialog.IsSubModule)
                {
                    replacementsDictionary.Add("$sub$", dialog.SubModuleName);
                    _module = dialog.ModuleName + dialog.SubModuleName;
                }
                else
                    replacementsDictionary.Add("$sub$", "");
                _shouldRun = true;
            }
                

        }

        
        public bool ShouldAddProjectItem(string filePath)
        {
            
            return _shouldRun;
        }
    }
}
