using Microsoft.Maui.Controls.PlatformConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningMAUI.Services
{
    public class AuthService
    {
        private const string AuthKey = "AuthKey";
        private const string TokenKey = "TokenKey";
        public string? User { get; private set; }

        public string? Token { get; private set; }

        public void Signin(string? user, string? token)
        {
            Preferences.Default.Set(AuthKey, user);
            Preferences.Default.Set(TokenKey, token);  
            User = user;
            Token = token;
        }

        public void Signout()
        {
            Preferences.Default.Remove(AuthKey);
            Preferences.Default.Remove(TokenKey);
            User = null;
            Token = null;
        }

        public void Initialize()
        {
            if (Preferences.Default.ContainsKey(TokenKey))
            {
                var token = Preferences.Default.Get<string?>(TokenKey, null);
                if (string.IsNullOrWhiteSpace(token)) {
                    Preferences.Default.Remove(TokenKey);
                }
                else
                {
                    Token = token;
                }
            }
        }
    }
}
