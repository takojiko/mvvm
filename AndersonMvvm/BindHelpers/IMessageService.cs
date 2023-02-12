using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndersonMvvm.BindHelpers
{
    /// <summary>
    /// メッセージサービス
    /// </summary>
    public interface IMessageService
    {
        void OKOnly(string message);
        DialogResult QuestionOKCancel(string message);
    }
}
