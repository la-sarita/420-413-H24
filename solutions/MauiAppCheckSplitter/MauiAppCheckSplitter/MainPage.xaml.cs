using MauiAppCheckSplitter.ViewModels;

namespace MauiAppCheckSplitter
{
    public partial class MainPage : ContentPage
    {
        readonly CheckViewModel viewModel;

        public MainPage()
        {
            InitializeComponent();

            viewModel = (CheckViewModel)BindingContext;

            for (int i = 1; i < 16; i++)
            {
                NumberOfPeople.Items.Add(i.ToString());
            }

            NumberOfPeople.SelectedIndex = 0;
        }

        private void NumberOfPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1)
            {
                viewModel.NumPeople = selectedIndex + 1;
            }
        }
    }

}
