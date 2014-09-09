using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraBars.Ribbon;
using $rootnamespace$.ViewModel;
using $rootnamespace$.Presenters;


namespace $rootnamespace$.Modules
{
    public partial class $module$ : BaseModuleControl, IRibbonModule
    {
        private readonly $module$Presenter presenterCore;
        public $safeitemname$()
            : base(CreateViewModel<$module$ViewModel>)
        {
            InitializeComponent();
            presenterCore = CreatePresenter();
            BindCommands();
        }

        public $module$ViewModel ViewModel
        {
            get { return GetViewModel<$module$ViewModel>(); }
        }

        public $module$Presenter Presenter
        {
            get { return presenterCore; }
        }

        protected virtual $module$Presenter CreatePresenter()
        {
            return new $module$Presenter(this, ViewModel);
        }

        public RibbonControl Ribbon
        {
            get { return ribbonControl1; }
        }


        private void BindCommands()
        {
            // bind commands to $module$ViewModel here

        }
    }
}
