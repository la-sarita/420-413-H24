using CommunityToolkit.Mvvm.ComponentModel;


namespace MauiAppCheckSplitter.ViewModels
{
    public partial class CheckViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Tip))]
        [NotifyPropertyChangedFor(nameof(Total))]
        [NotifyPropertyChangedFor(nameof(PersonalAmount))]
        double _amount;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Tip))]
        [NotifyPropertyChangedFor(nameof(Total))]
        [NotifyPropertyChangedFor(nameof(PersonalAmount))]
        double _tipRate;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(PersonalAmount))]
        int _numPeople = 1;

        public double Tip => RoundUp(Amount * (TipRate / 100.0));
        public double Total => RoundUp(Amount + Tip);
        public double PersonalAmount => RoundUp(Total / (NumPeople * 1.0));

        private double RoundUp(double amount)
        {
            decimal roundedAmount = 0;

            try
            {
                roundedAmount = (decimal)amount;
                roundedAmount = System.Math.Ceiling(roundedAmount * 100) / 100;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return (double)roundedAmount;
        }
    }
}
