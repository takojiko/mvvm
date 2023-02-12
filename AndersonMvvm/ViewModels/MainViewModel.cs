using AndersonMvvm.BindHelpers;
using AndersonMvvm.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace AndersonMvvm.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private IMessageService _messageService;
        private IDialogService _dialogService;

        public MainViewModel(Dispatcher dispatcher)
            : this(dispatcher, new MessageService(), new DialogService())
        {
        }

        public MainViewModel(
            Dispatcher dispatcher,
            IMessageService messageService,
            IDialogService dialogService)
        {
            base.Dispatcher = dispatcher;
            _messageService = messageService;
            _dialogService = dialogService;

            ComboSource = new BindingListAsync<MainViewModelCombo>(dispatcher);
            MyDataGridSource = new BindingListAsync<MainViewModelGrid>(dispatcher);

            ComboSource.Add(new MainViewModelCombo(1, "1111"));
            ComboSource.Add(new MainViewModelCombo(2, "2222"));
            ComboSource.Add(new MainViewModelCombo(3, "3333"));

            MyDataGridSource.Add(new MainViewModelGrid("10", "AAA10"));
            MyDataGridSource.Add(new MainViewModelGrid("20", "AAA20"));
            MyDataGridSource.Add(new MainViewModelGrid("30", "AAA30"));
            MyDataGridSource.Add(new MainViewModelGrid("40", "AAA40"));
        }

        private string _xxx = "XXX!!!";
        public string XXX
        {
            get { return _xxx; }
            set
            {
                SetProperty(ref _xxx, value);
            }
        }

        private string _aaaLabelText = "AAA";
        public string AAALabelText
        {
            get { return _aaaLabelText; }
            set
            {
                SetProperty(ref _aaaLabelText, value);
            }
        }

        private string _bbbTextBoxText = "BBB";
        public string BBBTextBoxText
        {
            get { return _bbbTextBoxText; }
            set
            {
                SetProperty(ref _bbbTextBoxText, value);
            }
        }

        private DateTime _cccDateTimePickerValue = DateTime.Now;
        public DateTime CCCDateTimePickerValue
        {
            get { return _cccDateTimePickerValue; }
            set
            {
                SetProperty(ref _cccDateTimePickerValue, value);
            }
        }

        private bool _dddCheckBoxChecked = false;
        public bool DDDCheckBoxChecked
        {
            get { return _dddCheckBoxChecked; }
            set
            {
                SetProperty(ref _dddCheckBoxChecked, value);
            }
        }

        private bool _aRadioButtonChecked = false;
        public bool ARadioButtonChecked
        {
            get { return _aRadioButtonChecked; }
            set
            {
                SetProperty(ref _aRadioButtonChecked, value);

                if(value)
                {
                    SetProperty(
                        ref _bRadioButtonChecked,
                        false,
                        nameof(BRadioButtonChecked));
                }
            }
        }

        private bool _bRadioButtonChecked = false;
        public bool BRadioButtonChecked
        {
            get { return _bRadioButtonChecked; }
            set
            {
                SetProperty(ref _bRadioButtonChecked, value);

                if (value)
                {
                    SetProperty(
                        ref _aRadioButtonChecked,
                        false,
                        nameof(ARadioButtonChecked));
                }
            }
        }

        public BindingListAsync<MainViewModelCombo> ComboSource { get; set; }

        private object _eeeComboBoxSelectedValue;
        public object EEEComboBoxSelectedValue
        {
            get { return _eeeComboBoxSelectedValue; }
            set
            {
                SetProperty(ref _eeeComboBoxSelectedValue, value);
                EEEComboBoxSelectedItem = 
                    ComboSource.FirstOrDefault(x=>x.Value == (int)value);
            }
        }

        public MainViewModelCombo EEEComboBoxSelectedItem { get; set; }

        public BindingListAsync<MainViewModelGrid> MyDataGridSource { get; set; }

        internal void UpdateExecute()
        {
            Update();
        }

        internal async void UpdateAsyncExecute()
        {
            await Task.Run(() => Update());
        }

        internal void Update()
        {
            XXX = "update xxx!!!";
            AAALabelText = "aaa update!!!";
            BBBTextBoxText = "bbb update!!!";
            CCCDateTimePickerValue = DateTime.Now.AddDays(1);
            DDDCheckBoxChecked = true;

            string date = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            System.Threading.Thread.Sleep(1000);
            MyDataGridSource.Add(new MainViewModelGrid("100", date));
            ComboSource.Add(new MainViewModelCombo(100, date));

            System.Threading.Thread.Sleep(1000);
            MyDataGridSource.Add(new MainViewModelGrid("100", date));
            ComboSource.Add(new MainViewModelCombo(100, date));

            System.Threading.Thread.Sleep(1000);
            MyDataGridSource.Add(new MainViewModelGrid("100", date));
            ComboSource.Add(new MainViewModelCombo(100, date));
        }

        public void SaveExecute()
        {
            if(_messageService.QuestionOKCancel("保存しますか？")
                != DialogResult.OK)
            {
                return;
            }

            int intResult = 0;
            if (!int.TryParse(BBBTextBoxText, out intResult))
            {
                throw new InputException("数値を入力してください");
            }

            //Save...
            AAALabelText = "SAVE!!";

            StatusLabelText = "Saveしました";
        }

        public void SubViewShowExecute()
        {
            var vm = new SubViewModel(null);
            _dialogService.ShowDialog(vm);
        }

        public void MyDataGridDoubleClick(MainViewModelGrid row)
        {
            var vm = new SubViewModel(row);
            _dialogService.ShowDialog(vm);
        }

        internal void CheckExecute()
        {
        }

        public void ProgressManualExecute()
        {
            StatusProgressVisible = true;
            StatusProgressStyle = ProgressBarStyle.Blocks;
            StatusProgressMinimum = 0;
            StatusProgressMaximum = 100;
            StatusProgressValue = 50;
        }

        public void ProgressAutoExeute()
        {
            StatusProgressVisible = true;
            StatusProgressStyle = ProgressBarStyle.Marquee;
        }

        public void EEEComboBoxSelectedIndexChanged(EventArgs e)
        {

        }
    }
}
