using System;
using System.IO;
using System.Linq;
using DevExpress.Mvvm;
using DevExpress.XtraTreeList;
using System.Collections.Generic;
using DevExpress.XtraTreeList.Nodes;
using $rootnamespace$.ViewModel;

namespace $rootnamespace$.Presenters
{
    public class $module$$sub$
    {
        private readonly TreeList _tree;
        private readonly $module$$sub$ViewModel _viewModel;

        public $module$$sub$(TreeList tree, $module$$sub$ViewModel viewModel)
        {
            _viewModel = viewModel;
            _tree = tree;
            InitTree();
        }

        public DashboardsFilterPaneViewModel ViewModel
        {
            get
            {
                return _viewModel;
            }
        }

        private void InitTree()
        {
            _tree.OptionsView.ShowColumns = false;
            _tree.OptionsView.ShowHorzLines = false;
            _tree.OptionsView.ShowVertLines = false;
            _tree.OptionsView.ShowIndicator = false;
            _tree.OptionsSelection.UseIndicatorForSelection = false;


            _tree.OptionsBehavior.DragNodes = true;
            _tree.OptionsBehavior.Editable = false;

            _tree.BeginUpdate();
            var column = _tree.Columns.Add();
            column.Caption = "Main";
            column.VisibleIndex = 0;
            _tree.EndUpdate();

        }

        public TreeListNode AddNode(string name, object tag = null, TreeListNode parent = null)
        {
            var node = _tree.AppendNode(new object[] { name }, parent);
            node.Tag = tag;
            return node;
        }
    }
}
