using System;
using System.Linq;
using DevExpress.Mvvm;
using System.Collections.Generic;

namespace $rootnamespace$.ViewModel
{
    public class $module$$sub$ViewModel : ISupportParentViewModel
    {
        public $module$$sub$ViewModel()
            : this(null)
        {
            
        }

        public $module$$sub$ViewModel($module$ViewModel parentViewModel)
        {
            ParentViewModel = parentViewModel;
        }


        public object ParentViewModel { get; set; }
    }
}
