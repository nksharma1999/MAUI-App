﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningMAUI.ViewModel
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool _isBusy;

        protected async Task GoToAsync(string url, bool animate = false) =>
            await Shell.Current.GoToAsync(url, animate);
        protected async Task ShowErrorAlert(string errorMessage) =>
            await Shell.Current.DisplayAlert("Error", errorMessage,"Ok");
    }
}
