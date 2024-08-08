
using LearningMAUI.Services;

namespace LearningMAUI.View;

public partial class WelcomePage : ContentPage
{
    private readonly AuthService _authService;
	public WelcomePage(AuthService authService)
	{
		InitializeComponent();
        _authService = authService;
	}

    protected async override void OnAppearing()
    {
        if (_authService != null && _authService.Token != null && !string.IsNullOrWhiteSpace(_authService.Token)) {
            await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        }
    }
    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
    }

    private async void Signin_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SigninPage));
    }

    private async void Signup_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SignupPage));
    }

   
}