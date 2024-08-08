using CommunityToolkit.Maui;
using LearningMAUI.Services;
using LearningMAUI.View;
using LearningMAUI.ViewModel;
using Microsoft.Extensions.Logging;

namespace LearningMAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .UseMauiCommunityToolkit();

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddTransient<AuthViewModel>()
                .AddTransient<SignupPage>()
                .AddTransient<SigninPage>();

            builder.Services.AddSingleton<AuthService>();
            builder.Services.AddTransient<WelcomePage>();

            builder.Services.AddSingleton<HomeViewModel>()
                .AddSingleton<HomePage>();
            return builder.Build();
        }
    }
}
