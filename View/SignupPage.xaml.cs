using LearningMAUI.ViewModel;
namespace LearningMAUI.View;

public partial class SignupPage : ContentPage
{
	public SignupPage(AuthViewModel authViewModel)
	{
		InitializeComponent();
		BindingContext = authViewModel;
	}

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		await Shell.Current.GoToAsync(nameof(SigninPage));
    }
}