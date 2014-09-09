using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.CodeRush.Core;
using DevExpress.CodeRush.PlugInCore;
using DevExpress.CodeRush.StructuralParser;
using System.IO;
using System.Reflection;

namespace WinFrameworkTools
{
    public partial class Main : StandardPlugIn
    {
        private string _templateDirectory;
        public override void InitializePlugIn()
        {
            base.InitializePlugIn();
            _templateDirectory = Path.Combine(
                                    Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), 
                                    "Module");

            DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
            DevExpress.XtraEditors.WindowsFormsSettings.EnableFormSkins();
        }

        public override void FinalizePlugIn()
        {


            base.FinalizePlugIn();
        }



        private void actionCreateMainModule_Execute(ExecuteEventArgs ea)
        {
            ExecuteTemplate("Main");
        }

        private void actionCreatePaneModule_Execute(ExecuteEventArgs ea)
        {
            ExecuteTemplate("Pane");
        }

        private void actionCreateEditModule_Execute(ExecuteEventArgs ea)
        {
            ExecuteTemplate("Edit");
        }

        private void ExecuteTemplate(string template)
        {
            try
            {
                if (CodeRush.Source.ActiveProject != null)
                {
                    EnvDTE.Project project = CodeRush.Source.ActiveProject.GetEnvDTEProject();
                    var projectItems = project.ProjectItems;

                    var t = Path.Combine(_templateDirectory, template, template +  ".vstemplate");
                    projectItems.AddFromTemplate(t, "temp.cs");
                }
                else
                    Console.Write("No Active Project!");

            }
            catch (Exception ex)
            {
                Console.Write("Error: {0}", ex.Message);
                Console.Write("Stack Trace: {0}\n", ex.StackTrace);
            }
        }

        
    }
}