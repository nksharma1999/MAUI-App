using LearningMAUI.ViewModel;
namespace LearningMAUI.View;

public partial class SigninPage : ContentPage
{
    /*private string emailInput =  "";
    private string passwordInput = "";*/
	public SigninPage(AuthViewModel authViewModel)
	{
		InitializeComponent();
        BindingContext = authViewModel;
	}

   /* private async void SigninButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.DisplayAlert("Alert", emailInput + passwordInput, "Ok");
        await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
    }

    private void Email_TextChanged(object sender, TextChangedEventArgs e)
    {
        *//*string oldText = e.OldTextValue;*//*
        emailInput = e.NewTextValue;
        *//*await Shell.Current.DisplayAlert("Alert", newText, "Ok");*//*
    }

    private void Password_TextChanged(object sender, TextChangedEventArgs e)
    {
        passwordInput = e.NewTextValue;
    }*/
}