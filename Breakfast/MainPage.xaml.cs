using Breakfast.ViewModels;

namespace Breakfast;

public partial class MainPage : ContentPage
{


    public MainPage()
    {
        InitializeComponent();
        BindingContext = new BreakfastVm();
    }

}

