using LearningMAUI.ViewModel;

namespace LearningMAUI.View;

public partial class HomePage : ContentPage
{
	private readonly HomeViewModel _homeViewModel;
	public HomePage(HomeViewModel homeViewModel)
	{
		InitializeComponent();
        _homeViewModel = homeViewModel;
        BindingContext = _homeViewModel;
	}

    protected override async void OnAppearing()
    {
        await _homeViewModel.InitializeAsync();
    }
}