namespace Ichongli.TuiGirls.Service
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IProgressService
    {
        void Show();
        void Show(string text);
        void Hide();
    }
}
