using AndersonMvvm.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndersonMvvm.Views
{
    public partial class BaseView : Form
    {
        public BaseView()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        protected void Bind(ViewModelBase vm)
        {
            StatusProgress.DataBindings.Add(nameof(StatusProgress.Value), vm,
           nameof(vm.StatusProgressValue));
            StatusProgress.DataBindings.Add(nameof(StatusProgress.Maximum), vm,
             nameof(vm.StatusProgressMaximum));
            StatusProgress.DataBindings.Add(nameof(StatusProgress.Minimum), vm,
             nameof(vm.StatusProgressMinimum));
            StatusProgress.DataBindings.Add(nameof(StatusProgress.Style), vm,
             nameof(vm.StatusProgressStyle));
            StatusProgress.DataBindings.Add(nameof(StatusProgress.Visible), vm,
           nameof(vm.StatusProgressVisible));

            StatucLabel.DataBindings.Add("Text", vm,
                nameof(vm.StatusLabelText));
        }
    }
}
