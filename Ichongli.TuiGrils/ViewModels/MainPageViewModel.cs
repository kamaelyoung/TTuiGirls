

namespace Ichongli.TuiGrils.ViewModels
{
    using Ichongli.TuiGrils.Service;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MainPageViewModel
    {
        private IProgressService _progressService;
        public MainPageViewModel()
        {

        }
        public MainPageViewModel(IProgressService progressService)
        {
            this._progressService = progressService;
            this._progressService.Show();
        }
    }
}
