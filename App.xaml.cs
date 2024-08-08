using LearningMAUI.Services;

namespace LearningMAUI
{
    public partial class App : Application
    {
        public App(AuthService authService)
        {
            InitializeComponent();

          //  authService.Initialize();

            MainPage = new AppShell(authService);
        }
    }
}
