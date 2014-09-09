using System;
using System.Linq;
using System.Collections.Generic;
using $rootnamespace$.Modules;
using $rootnamespace$.ViewModel;


namespace $rootnamespace$.Presenters
{
    public class $module$$sub$Presenter : BasePresenter<$module$$sub$ViewModel>
    {
        public $module$$sub$Presenter($module$$sub$ view, $module$$sub$ViewModel viewModel)
            : base(viewModel)
        {
            // should consider wiring UI elements from $module$$sub$
            // into this presenter instance in a more granular way
            View = view;
        }

        public $module$$sub$ View { get; private set; }
    }
}
