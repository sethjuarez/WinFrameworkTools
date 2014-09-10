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
using DevExpress.XtraEditors;
using Microsoft.VisualStudio.Shell;

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
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle("Visual Studio 2013 Light");
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
                // trying to find active project
                EnvDTE.ProjectItems projectItems = null;
                if (CodeRush.Source.ActiveProject != null)
                    projectItems = CodeRush.Source.ActiveProject.GetEnvDTEProject().ProjectItems;
                else if (CodeRush.Source.ActiveSolution!= null && 
                        CodeRush.Source.ActiveSolution.ProjectElements.Count > 0)
                    projectItems = ((ProjectElement)CodeRush.Source.ActiveSolution.ProjectElements.ToArray()[0]).GetEnvDTEProject().ProjectItems;
                else if (CodeRush.Solution.AllProjects != null &&
                        CodeRush.Solution.AllProjects.FirstOrDefault() != null)
                    projectItems = CodeRush.Solution.AllProjects.FirstOrDefault().ProjectObject.ProjectItems;
                else if (CodeRush.ProjectItems.Active != null)
                    projectItems = CodeRush.ProjectItems.Active.ProjectItems;
                else if (CodeRush.Project.Active != null)
                    projectItems = CodeRush.Project.Active.ProjectObject.ProjectItems;

                if (projectItems != null)
                {
                    var t = Path.Combine(_templateDirectory, template, template + ".vstemplate");
                    projectItems.AddFromTemplate(t, "temp.cs");
                }
                else
                {
                    Console.Write("No Active Project!");
                    XtraMessageBox.Show("No active project!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.Write("Error: {0}", ex.Message);
                Console.Write("Stack Trace: {0}\n", ex.StackTrace);
                var message = string.Format("Error: {0}\n\nStack Trace: {1}", ex.Message, ex.StackTrace);
                XtraMessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}