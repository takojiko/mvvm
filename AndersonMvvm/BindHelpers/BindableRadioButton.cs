using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndersonMvvm.BindHelpers
{
    /// <summary>
    /// バインディング用のラジオボタン
    /// </summary>
    public sealed class BindableRadioButton : RadioButton
    {
        public BindableRadioButton()
        {
            AutoCheck = false;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            this.Checked = !this.Checked;
        }
    }
}
