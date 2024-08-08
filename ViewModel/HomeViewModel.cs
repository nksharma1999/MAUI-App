using CommunityToolkit.Mvvm.ComponentModel;
using LearningMAUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningMAUI.ViewModel
{
    public partial class HomeViewModel(AuthService authService): BaseViewModel
    {
        private readonly AuthService _authService = authService;
        [ObservableProperty]
        private ApiData[] _apiDatas = [];

        [ObservableProperty]
        private string _userName = string.Empty;

        private bool _isInitialized;

        public async Task InitializeAsync()
        {
            UserName = _authService.User ?? "Hi";
            //await Shell.Current.DisplayAlert("Alert", "Data Feating", "Ok");
            if (_isInitialized) return;
            IsBusy = true;
            try
            {
                //Make API Call
                ApiDatas = [new ApiData() { Id= 1, Description= "NewData", Name="Nandkishor", Price = 20}];
                _isInitialized = true;

            }
            catch (Exception ex)
            {
                _isInitialized = false;
                await ShowErrorAlert(ex.Message);
            }
            finally {
                IsBusy = false;
            }
        }

        public class ApiData
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public double Price { get; set; }
        }
    }
}
