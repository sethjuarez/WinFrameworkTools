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
            //DevExpress.XtraEditors.WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle("Office 2013");
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
        }

        public override void FinalizePlugIn()
        {


            base.FinalizePlugIn();
        }



        private void actionCreateMainModule_Execute(ExecuteEventArgs ea)
        {
            try
            {
                var template = Path.Combine(_templateDirectory, "Main", "Main.vstemplate");
                EnvDTE.Project project = CodeRush.Source.ActiveProject.GetEnvDTEProject();
                var projectItems = project.ProjectItems;
                projectItems.AddFromTemplate(template, "temp.cs");

            }
            catch (Exception ex)
            {
                Console.Write("Error: {0}", ex.Message);
                Console.Write("Stack Trace: {0}\n", ex.StackTrace);
            }
        }
    }
}