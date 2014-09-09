using System;
using System.Linq;
using DevExpress.Mvvm;
using System.Collections.Generic;
using DevExpress.DashboardCommon;

namespace $rootnamespace$.ViewModel
{
    public class $module$$sub$ViewModel
    {
        private readonly $module$ViewModel _parentViewModel;
        public $module$$sub$ViewModel()
            : this(null)
        {
            
        }

        public $module$$sub$ViewModel($module$ViewModel parentViewModel)
        {
            _parentViewModel = parentViewModel;
        }


        public DashboardsViewModel ParentViewModel
        {
            get
            {
                return _parentViewModel;
            }
        }
    }
}
