using System;
using System.Linq;
using System.Collections.Generic;
using $rootnamespace$.Modules;
using $rootnamespace$.ViewModel;


namespace $rootnamespace$.Presenters
{
    public class $module$Presenter : BasePresenter<$module$ViewModel>
    {
        public $module$Presenter($module$ view, $module$ViewModel viewModel)
            : base(viewModel)
        {
            // should consider wiring UI elements from $module$
            // into this presenter instance in a more granular way
            View = view;
        }

        public $module$ View { get; private set; }
    }
}
