namespace Ichongli.TuiGirls
{
    using Caliburn.Micro;
    using Caliburn.Micro.Autofac;
    using Caliburn.Micro.Logging;
    using Ichongli.TuiGirls.Service;
    using Ichongli.TuiGirls.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AppBootstrapper : AutofacBootstrapper
    {
        protected override void ConfigureBootstrapper()
        {
            //  you must call the base version first!
            base.ConfigureBootstrapper();

            //  override namespace naming convention
            EnforceNamespaceConvention = false;
            //  change our view model base type
            //ViewModelBaseType = typeof(IShell);
        }
    }
}
