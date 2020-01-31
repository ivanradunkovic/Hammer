//using Hammer.Models.OAuthProviders;
//using Hammer.Models;
//using Microsoft.Owin;
//using Microsoft.Owin.Security;
//using Microsoft.Owin.Security.Cookies;
//using Microsoft.Owin.Security.Google;
//using Microsoft.Owin.Security.Facebook;
//using Owin;
//using System;

//namespace Hammer
//{
//    public partial class Startup
//    {
//        public void ConfigureAuth(IAppBuilder app)
//        {
//            var facebookCredentials = Actions.LoadCredentials(SignInApplication.Facebook);
       
//            if (facebookCredentials == null)
//                throw new Exception
//                    ("FacebookCredentials could not be found(FacebookAuthenticationOptions)");


//            app.SetDefaultSignInAsAuthenticationType(CookieAuthenticationDefaults.AuthenticationType);
//            var cookieOptions = new CookieAuthenticationOptions
//            {
//                LoginPath = new PathString("/Account/Index"),
//                SlidingExpiration = true,
//                Provider = new CookieProvider(),
//                ExpireTimeSpan = TimeSpan.FromDays(7)
//            };
//            app.UseCookieAuthentication(cookieOptions);           

//            var facebookOptions = new FacebookAuthenticationOptions()
//            {
//                AppSecret = facebookCredentials.Client_Secret,
//                AppId = facebookCredentials.Client_Id,
//                AuthenticationType = facebookCredentials.Provider,
//                Provider = new FacebookProvider()
//            };
//            app.UseFacebookAuthentication(facebookOptions);
//        }
//    }
//}