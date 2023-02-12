using System.ComponentModel;
using System.Windows.Threading;

namespace AndersonMvvm.BindHelpers
{
    /// <summary>
    /// 非同期で実行してもUIスレッドに戻すBindingList
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class BindingListAsync<T> : BindingList<T>
    {
        private Dispatcher _dispatcher;

        public BindingListAsync(Dispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        protected override void OnListChanged(ListChangedEventArgs e)
        {
            _dispatcher.Invoke(() => base.OnListChanged(e));
        }
    }
}
