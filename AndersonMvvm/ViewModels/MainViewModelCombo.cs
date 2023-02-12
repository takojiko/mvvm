namespace AndersonMvvm.ViewModels
{
    public sealed class MainViewModelCombo
    {
        public MainViewModelCombo(int value, string displayValue)
        {
            Value = value;
            DisplayValue = displayValue;
        }

        public int Value { get; }
        public string DisplayValue { get; }
    }
}