using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LearningMAUI.View;
using LearningMAUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningMAUI.ViewModel
{
    public partial class AuthViewModel(AuthService authService) : BaseViewModel
    {
        private readonly AuthService _authService = authService;

        [ObservableProperty, NotifyPropertyChangedFor(nameof(CanSinup))]
        private string? _name;

        [ObservableProperty,NotifyPropertyChangedFor(nameof(CanSignin)), NotifyPropertyChangedFor(nameof(CanSinup))]
        private string? _password;

        [ObservableProperty, NotifyPropertyChangedFor(nameof(CanSignin)), NotifyPropertyChangedFor(nameof(CanSinup))]
        private string? _email;

        [ObservableProperty, NotifyPropertyChangedFor(nameof(CanSinup))]
        private string? _address;

        public bool CanSinup => !string.IsNullOrEmpty(Name)
            && CanSignin && !string.IsNullOrEmpty(Address);

        public bool CanSignin => !string.IsNullOrEmpty(Password)
            && !string.IsNullOrEmpty(Email);

        [RelayCommand]
        private async Task SignupAsync()
        {
            IsBusy = true;
            try
            {
                //Make API Call
                /*await Shell.Current.GoToAsync($"//{nameof(HomePage)}", animate: true);*/
                _authService.Signin(Name, "Tokenhkjsdhghhsfghks");
                await GoToAsync($"//{nameof(HomePage)}", true);
            }
            catch (Exception ex)
            {
                await ShowErrorAlert(ex.Message);
            }
            finally {
                //IsBusy = false;            
            }
        }

        [RelayCommand]
        private async Task SigninAsync()
        {
            IsBusy = true;
            try
            {
                //Api Call
                _authService.Signin(Name, "Tokenhkjsdhghhsfghks");
                await GoToAsync($"//{nameof(HomePage)}", true);
            }
            catch (Exception ex)
            {
                await ShowErrorAlert(ex.Message);
            }
            finally { IsBusy = false; }
        }
    }
}
