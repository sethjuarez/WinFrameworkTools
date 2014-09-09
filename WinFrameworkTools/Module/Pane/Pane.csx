using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraLayout.Utils;
using $rootnamespace$.ViewModel;
using $rootnamespace$.Win.Presenters;

namespace $rootnamespace$.Modules
{
    public partial class $module$$sub$ : BaseModuleControl, ISupportCompactLayout
    {
        private readonly $module$$sub$Presenter presenterCore;

        public $module$$sub$($module$ViewModel viewModel)
            : base(() => CreateViewModel(() => new $module$$sub$ViewModel(viewModel)))
        {
            InitializeComponent();
            FiltersTreeListAppearances.Apply(treeList);
            presenterCore = CreatePresenter();
        }

        protected override void OnParentViewModelAttached()
        {
            BindCommands();
        }


        public $module$$sub$ViewModel ViewModel
        {
            get { return GetViewModel<$module$$sub$ViewModel>(); }
        }

        public $module$$sub$Presenter Presenter
        {
            get { return presenterCore; }
        }

        protected virtual $module$$sub$Presenter CreatePresenter()
        {
            return new DashboardListPresenter(treeList, ViewModel);
        }

        private void BindCommands()
        {
            
        }

        bool compactLayout = true;

        bool ISupportCompactLayout.Compact
        {
            get { return compactLayout; }
            set
            {
                if (compactLayout == value) return;
                compactLayout = value;
                UpdateCompactLayout();
            }
        }

        private void UpdateCompactLayout()
        {
            btnNew$module$LayoutControlItem.Visibility = compactLayout ? LayoutVisibility.Never : LayoutVisibility.Always;
        }
    }
}
