using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using AndersonMvvm.ViewModels;

namespace AndersonMvvm.Views
{
    public partial class MainView : BaseView
    {
        private MainViewModel _viewModel
            = new MainViewModel(Dispatcher.CurrentDispatcher);
        public MainView()
        {
            InitializeComponent();

            _viewModel.PropertyChanged += ViewModel_PropertyChanged;

            base.Bind(_viewModel);

            AAALabel.DataBindings.Add("Text", _viewModel, nameof(_viewModel.AAALabelText));
            BBBTextBox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.BBBTextBoxText));
            CCCDateTimePicker.DataBindings.Add(nameof(CCCDateTimePicker.Value), _viewModel, nameof(_viewModel.CCCDateTimePickerValue));
            DDDCheckBox.DataBindings.Add(nameof(DDDCheckBox.Checked), _viewModel, nameof(_viewModel.DDDCheckBoxChecked));
            ARadioButton.DataBindings.Add("Checked", _viewModel, nameof(_viewModel.ARadioButtonChecked), false, DataSourceUpdateMode.OnPropertyChanged);
            BRadioButton.DataBindings.Add("Checked", _viewModel, nameof(_viewModel.BRadioButtonChecked), false, DataSourceUpdateMode.OnPropertyChanged);
            EEEComboBox.DataBindings.Add("DataSource", _viewModel, nameof(_viewModel.ComboSource));
            EEEComboBox.ValueMember = nameof(MainViewModelCombo.Value);
            EEEComboBox.DisplayMember = nameof(MainViewModelCombo.DisplayValue);
            EEEComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            EEEComboBox.DataBindings.Add("SelectedValue", _viewModel, nameof(_viewModel.EEEComboBoxSelectedValue), false, DataSourceUpdateMode.OnPropertyChanged);
         
            //MyDataGrid.DataBindings.Add("DataSource", _viewModel,
            //    nameof(_viewModel.MyDataGridSource));
            MyDataGrid.DataSource = _viewModel.MyDataGridSource;
            MyDataGrid.DoubleClick += (sender, e) => _viewModel.MyDataGridDoubleClick(MyDataGrid.CurrentRow.DataBoundItem as MainViewModelGrid);
            MyDataGrid.Columns[nameof(MainViewModelGrid.Id)].HeaderText = "アイディー";
            MyDataGrid.Columns[nameof(MainViewModelGrid.Name)].HeaderText = "名前";
            MyDataGrid.Columns[nameof(MainViewModelGrid.Id)].Width = 100;
            
            UpdateButton.Click += (sender, e) => _viewModel.UpdateExecute();
            UpdateAsyncButton.Click += (sender, e) => _viewModel.UpdateAsyncExecute();
            CheckButton.Click += (sender, e) => _viewModel.CheckExecute();
            SaveButton.Click += (sender, e) => _viewModel.SaveExecute();
            SubViewShowButton.Click += (sender, e) => _viewModel.SubViewShowExecute();
            ProgressManualButton.Click += (sender, e) => _viewModel.ProgressManualExecute();
            ProgressAutoButton.Click += (sender, e) => _viewModel.ProgressAutoExeute();

            //EEEComboBox.SelectedIndexChanged += (sender, e) 
            //    => _viewModel.EEEComboBoxSelectedIndexChanged(e);
        }

        private void ViewModel_PropertyChanged(
            object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(_viewModel.XXX))
            { 
            }
        }
    }
}
