using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.CodeRush.Core;
using System.Collections.Generic;
using DevExpress.CodeRush.PlugInCore;
using DevExpress.CodeRush.StructuralParser;
using DevExpress.CodeRush.Common.Constants;

namespace WinFrameworkTools
{
    public static class Helpers
    {
        public static bool ItemExists(string type)
        {
            return GetType(type) != null;
        }

        public static ITypeElement GetType(string type)
        {
            var item = CodeRush.Source.ActiveProject.AllTypes.OfType<ITypeElement>()
                            .Where(e => e.Signature == type);

            if (item.Count() == 1)
                return item.First();
            else
                return null;

        }

        public static void AddEnumItem(string enumType, string moduleName)
        {
            var element = GetType(enumType);
            if (element != null)
            {
                Enumeration enumeration = element.ToLanguageElement() as Enumeration;

                // add enum element
                SourcePoint insertionPoint = SourcePoint.Empty;
                string expansion;
                int nodesCount = enumeration.NodeCount;
                if (nodesCount > 0)
                {
                    LanguageElement lastNode = enumeration.Nodes[nodesCount - 1] as LanguageElement;
                    expansion = CodeRush.Language.IsBasic ? "" : String.Format(",{0}{1}", Environment.NewLine, moduleName);
                    insertionPoint = lastNode.Range.End;
                }
                else
                {
                    expansion = moduleName + Environment.NewLine;
                    CodeRush.Language.GetCodeBlockStart(enumeration, ref insertionPoint);
                }

                TextDocument targetDoc = CodeRush.File.Activate(enumeration.FileNode.Name) as TextDocument;
                if (targetDoc != null)
                    CodeRush.TextExpansions.Insert(targetDoc, insertionPoint, expansion, false, true);
            }
        }

        public static IEnumerable<string> GetModules(ProjectElement project)
        {
            var projectPath = Path.GetDirectoryName(project.FilePath);
            string modules = Path.Combine(projectPath, "Modules");
            return Directory.EnumerateDirectories(modules).Select(s => s.Split('\\').Last());
        }
           
    }
}
