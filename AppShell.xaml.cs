using LearningMAUI.View;

namespace LearningMAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RefisterRoutes();
           /* Routing.RegisterRoute(nameof(SigninPage),typeof(SigninPage));
            Routing.RegisterRoute(nameof(SignupPage),typeof(SignupPage));*/ 
        }
        private readonly static Type[] _routablePageTypes = [
            typeof(SigninPage), 
            typeof(SignupPage),
            typeof(MyOrderPage),
            typeof(OrderDetailsPage),
            typeof(DetailsPage),
            ];
        private static void RefisterRoutes()
        {
            foreach(var pageType in _routablePageTypes)
            {
                Routing.RegisterRoute(pageType.Name, pageType);
            }
            /*Routing.RegisterRoute(nameof(SigninPage), typeof(SigninPage));
            Routing.RegisterRoute(nameof(SignupPage), typeof(SignupPage));*/
        }

        private async void SignoutMenuItem_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.DisplayAlert("Alert", "Signout Button Clicked","Ok");
        }
    }
}
