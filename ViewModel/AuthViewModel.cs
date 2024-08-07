using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningMAUI.ViewModel
{
    public partial class AuthViewModel: BaseViewModel
    {

        [ObservableProperty]
        private string? _name;
        [ObservableProperty]
        private string? _password;
        [ObservableProperty]
        private string? _email;
        [ObservableProperty]
        private string? _address;

        public bool CanSinup => !string.IsNullOrEmpty(Name)
            && CanSignin && !string.IsNullOrEmpty(Address);

        public bool CanSignin => !string.IsNullOrEmpty(Password)
            && !string.IsNullOrEmpty(Email);
        private async Task SignupAsync()
        {
            IsBusy = true;
            try
            {
                //Make API Call
            }
            catch (Exception ex)
            {
                throw;
            }
            finally {
                IsBusy = false;            
            }
        }
    }
}
