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
    public interface IDialogService
    {
        DialogResult ShowDialog(ViewModelBase vm); 
    }
}
