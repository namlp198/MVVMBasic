using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMBasic
{
    public interface IView
    {
        void SetDataContext(object viewModel);
        void SetLanguage(string sLanguage);
        void ShowView();
        void CloseView();
    }
}
