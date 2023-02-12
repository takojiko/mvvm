namespace AndersonMvvm.ViewModels
{
    public class SubViewModel : ViewModelBase
    {
        public SubViewModel(MainViewModelGrid row)
        {
            if (row == null)
            {
                IdTextBoxReadOnly = false;
                return;
            }

            IdTextBoxText = row.Id;
            NameTextBoxText = row.Name;
            IdTextBoxReadOnly = true;
        }

        private string _idTextBoxText = string.Empty;
        public string IdTextBoxText
        {
            get { return _idTextBoxText; }
            set
            {
                SetProperty(ref _idTextBoxText, value);
            }
        }

        private string _nameTextBoxText = string.Empty;
        public string NameTextBoxText
        {
            get { return _nameTextBoxText; }
            set
            {
                SetProperty(ref _nameTextBoxText, value);
            }
        }

        private bool _idTextBoxReadOnly = false;
        public bool IdTextBoxReadOnly
        {
            get { return _idTextBoxReadOnly; }
            set
            {
                SetProperty(ref _idTextBoxReadOnly, value);
            }
        }
        //
    }
}
