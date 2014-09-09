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
	public class $module$$sub$Presenter : BasePresenter<$module$$sub$ViewModel>
	{
		private readonly TreeList _tree;
		public $module$$sub$Presenter(TreeList tree, $module$$sub$ViewModel viewModel)
			: base(viewModel)
		{
			_tree = tree;
			InitTree();
		}

		private void InitTree()
		{
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
