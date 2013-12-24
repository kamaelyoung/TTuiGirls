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
        private PhoneContainer container;

        static AppBootstrapper()
        {
            LogManager.GetLog = type => new DebugLogger(type);
        }

        protected override void Configure()
        {
            // container = new PhoneContainer(RootFrame);

            //if (!Execute.InDesignMode)
            //    container.RegisterPhoneServices();

            container.Instance<IProgressService>(new ProgressService(RootFrame));

            container.PerRequest<MainPageViewModel>();
        }
    }
}
