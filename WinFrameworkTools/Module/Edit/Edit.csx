using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraBars.Ribbon;
using $rootnamespace$.ViewModel;
using $rootnamespace$.Presenters;


namespace $rootnamespace$.Modules
{
    public partial class $module$$sub$ : BaseModuleControl, IRibbonModule
    {
        private readonly $module$$sub$Presenter presenterCore;
        public $module$$sub$()
            : base(CreateViewModel<$module$$sub$ViewModel>)
        {
            InitializeComponent();
            presenterCore = CreatePresenter();
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
            return new $module$$sub$Presenter(this, ViewModel);
        }

        public RibbonControl Ribbon
        {
            get { return ribbonControl1; }
        }


        private void BindCommands()
        {
            // bind commands to $module$$sub$ViewModel here

        }
    }
}
