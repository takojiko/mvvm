using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace AndersonMvvm.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected Dispatcher Dispatcher { get; set; }

        protected bool SetProperty<T>(ref T field,
            T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(field, value))
            {
                return false;
            }

            field = value;
            var h = this.PropertyChanged;
            if (h != null)
            {
                if (Dispatcher != null)
                {
                    Dispatcher.Invoke(
                        () => h(this, new PropertyChangedEventArgs(propertyName)));
                }
                else
                {
                    h(this, new PropertyChangedEventArgs(propertyName));
                }
            }

            return true;
        }

        public virtual DateTime GetDateTime()
        {
            return DateTime.Now;
        }


        private string _statusLabelText = "AAA";
        public string StatusLabelText
        {
            get { return _statusLabelText; }
            set
            {
                SetProperty(ref _statusLabelText, value);
            }
        }

        private int _statusProgressValue = 0;
        public int StatusProgressValue
        {
            get { return _statusProgressValue; }
            set
            {
                SetProperty(ref _statusProgressValue, value);
            }
        }

        private int _statusProgressMaximum = 0;
        public int StatusProgressMaximum
        {
            get { return _statusProgressMaximum; }
            set
            {
                SetProperty(ref _statusProgressMaximum, value);
            }
        }

        private int _statusProgressMinimum = 0;
        public int StatusProgressMinimum
        {
            get { return _statusProgressMinimum; }
            set
            {
                SetProperty(ref _statusProgressMinimum, value);
            }
        }

        private ProgressBarStyle _statusProgressStyle = ProgressBarStyle.Blocks;
        public ProgressBarStyle StatusProgressStyle
        {
            get { return _statusProgressStyle; }
            set
            {
                SetProperty(ref _statusProgressStyle, value);
            }
        }

        private bool _statusProgressVisible = false;
        public bool StatusProgressVisible
        {
            get { return _statusProgressVisible; }
            set
            {
                SetProperty(ref _statusProgressVisible, value);
            }
        }
    }
}
