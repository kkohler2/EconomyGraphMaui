using EconomyGraphTest.ViewModels;

namespace EconomyGraphMauiTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BindingContext = new MainPageViewModel();
            InitializeComponent();
        }
    }
}