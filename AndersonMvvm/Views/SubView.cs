using AndersonMvvm.ViewModels;
using System.Windows.Forms;

namespace AndersonMvvm.Views
{
    public partial class SubView : BaseView
    {
        private SubViewModel _viewModel;
        public SubView(SubViewModel viewModel)
        {
            InitializeComponent();

            _viewModel = viewModel;
            base.Bind(_viewModel);

            IdTextBox.DataBindings.Add("Text", _viewModel,
                nameof(_viewModel.IdTextBoxText));
            NameTextBox.DataBindings.Add("Text", _viewModel,
               nameof(_viewModel.NameTextBoxText));
            IdTextBox.DataBindings.Add(nameof(IdTextBox.ReadOnly), _viewModel,
                nameof(_viewModel.IdTextBoxReadOnly));
        }
    }
}
