using Microsoft.Identity.Client;
using System;
using Xamarin.Forms;

namespace UserDetailsClient
{
    public class App : Application
    {
        public static IPublicClientApplication PCA = null;

        /// <summary>
        /// The ClientID is the Application ID found in the portal (https://go.microsoft.com/fwlink/?linkid=2083908). 
        /// You can use the below id however if you create an app of your own you should replace the value here.
        /// </summary>
        public static string ClientID =
        //"a643bcca-2548-4793-aa1c-826a430680f4"; // UWP Tutorial
        "4a1aa1d5-c567-49d0-ad0b-cd957a47f842"; //msidentity-samples-testing tenant (**good**)

        public static string[] Scopes = { "User.Read", "Tasks.ReadWrite" };
        public static string Username = string.Empty;

        public static object ParentWindow { get; set; }

        public App(string specialRedirectUri = null)
        {
            PCA = PublicClientApplicationBuilder.Create(ClientID)
                .WithRedirectUri(specialRedirectUri?? $"msal{ClientID}://auth")
                .WithIosKeychainSecurityGroup("com.microsoft.adalcache")
                .Build();

            MainPage = new NavigationPage(new UserDetailsClient.MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
