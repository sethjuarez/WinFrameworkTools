using System;
using System.Linq;
using DevExpress.Mvvm;
using DevExpress.DashboardCommon;
using System.Collections.Generic;
using DevExpress.Mvvm.DataAnnotations;

namespace $rootnamespace$.ViewModel
{
	public class $module$$sub$ViewModel : ISupportParameter
	{
		// Tip for instantiating this as a standalone window
		// 1. in the view
		// protected override void OnInitServices(IServiceContainer serviceContainer)
		// {
		//		base.OnInitServices(serviceContainer);
		//		serviceContainer.RegisterService(new DetailFormDocumentManagerService(ModuleType.$module$$sub$));
		// }

		// 2. In the ViewModel we need this property
		// [ServiceProperty]
		// public virtual IDocumentManagerService DocumentManagerService
		// {
		//		get
		//		{
		//			return null;
		//		}
		// }

		// 3. Whenever you want to instantiate, use this:
		// var document = DocumentManagerService.CreateDocument("$module$$sub$", someParameter, this);
		// if (document != null)
		//		document.Show();

		public virtual object Parameter { get; set; }
	}
}
