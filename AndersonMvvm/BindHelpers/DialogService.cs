using AndersonMvvm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndersonMvvm.BindHelpers
{
    /// <summary>
    /// 画面遷移サービス
    /// </summary>
    public sealed class DialogService : IDialogService
    {
        public DialogResult ShowDialog(ViewModelBase vm)
        {
            string viewName = vm.GetType().FullName.Replace("ViewModel", "View");
            Type type = Type.GetType(viewName);
            using (var view = (Form)Activator.CreateInstance(type, vm))
            {
                return view.ShowDialog();
            }
        }
    }
}
