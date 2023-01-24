namespace XamlApp1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.BindingContext = new PhoneViewModel
        {
            Title = "iPhone 7",
            Company = "Apple",
            Price = 52000
        };
    }
}


