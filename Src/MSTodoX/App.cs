using Microsoft.Identity.Client;
using System;
using System.IO;
using System.Linq;
using MSTodoX.Model;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Reflection;

namespace MSTodoX
{
    public class App : Application
    {
        public static string AppDataDir = string.Empty;
        public static string AppDataDbString = string.Empty;

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
        internal static object authResult;

        public static object ParentWindow { get; set; }

        public App(string specialRedirectUri = null)
        {
            AppDataDir = "";//Application.Path ;//appDataDir;
            AppDataDbString = Path.Combine(App.AppDataDir, AppSetting.DbFileName);
            InitializeDb();

            PCA = PublicClientApplicationBuilder.Create(ClientID)
                .WithRedirectUri(specialRedirectUri?? $"msal{ClientID}://auth")
                .WithIosKeychainSecurityGroup("com.microsoft.adalcache")
                .Build();

            MainPage = new NavigationPage(new MSTodoX.MainPage());
        }

        private void InitializeDb()
        {
            using (var conn = new SQLiteConnection(AppDataDbString))
            {
                conn.CreateTable<AppSetting>();

                var data = conn.Table<AppSetting>();

                if (!data.Any())
                {
                    var d = new AppSetting()
                    {
                        //AppName = "TodoistX",
                        //Author = "Jaroslav Langer",
                        //AuthKey = "2f6421653f8eb04e42492f94615d6b32daf343bc"
                        AppName = "MSTodoX",
                        Author = " Media Explorer",
                        AuthKey = ClientID // paste your Access Token here
                    };

                    conn.Insert(d);
                }
            }

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
