// MainPage

using Microsoft.Identity.Client;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using MSTodoX.Model;
using Xamarin.Forms;
using MSTodoX;
using Todoist.Net;

// MSTodoX
namespace MSTodoX
{
    // MainPage class
    public partial class MainPage : ContentPage
    {
     
        // !
        public string[] Phones { get; set; }

        // MainPage
        public MainPage()
        {
            InitializeComponent();

            // !
            Phones = new string[] { "iPhone 8", "Samsung Galaxy S9", "Huawei P10", "LG G6" };
            
            // !
            this.BindingContext = this;

        }//MainPage

       
        private void Browse_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProjectBrowsePage());
        }


        // Setting_OnClicked
        private void Setting_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SettingPage());

        }//Setting_OnClicked


        // OnSignInSignOut
        async void OnSignInSignOut(object sender, EventArgs e)
        {
            //AuthenticationResult authResult = null;

            IEnumerable<IAccount> accounts = 
                await App.PCA.GetAccountsAsync().ConfigureAwait(false);
            
            try
            {
                if (btnSignInSignOut.Text == "Sign in")
                {
                    try
                    {
                        IAccount firstAccount = accounts.FirstOrDefault();
                        App.authResult = await App.PCA.AcquireTokenSilent
                            (App.Scopes, firstAccount)
                                .ExecuteAsync()
                                .ConfigureAwait(false);
                    }
                    catch (MsalUiRequiredException)
                    {
                        try
                        { 
                            var builder = 
                            App.PCA.AcquireTokenInteractive(App.Scopes)
                                  .WithParentActivityOrWindow(App.ParentWindow);

                            if (Device.RuntimePlatform != "UWP")
                            {
                                // on Android and iOS, prefer to use the system browser,
                                // which does not exist on UWP
                                SystemWebViewOptions systemWebViewOptions 
                                    = new SystemWebViewOptions()
                                {                            
                                    iOSHidePrivacyPrompt = true,
                                };

                                builder.WithSystemWebViewOptions(systemWebViewOptions);
                                builder.WithUseEmbeddedWebView(false);
                            }

                            App.authResult = await builder.ExecuteAsync().ConfigureAwait(false);
                        }
                        catch (Exception ex2)
                        {
                            Device.BeginInvokeOnMainThread(async () =>
                            {
                                await DisplayAlert
                                (
                                    "Acquire token interactive failed. " +
                                    "See exception message for details: ", 
                                    ex2.Message, 
                                    "Dismiss"
                                );
                            });
                        }
                    }

                    if (App.authResult != null)
                    {
                        string content = 
                            await TodoClient.GetHttpContentWithTokenAsync(App.authResult.AccessToken);
                        
                        //UpdateUserContent(content);
                    }
                }
                else
                {
                    while (accounts.Any())
                    {
                        await App.PCA.RemoveAsync(
                            accounts.FirstOrDefault()).ConfigureAwait(false);

                        accounts = await App.PCA.GetAccountsAsync().ConfigureAwait(false);
                    }

                    
                    Device.BeginInvokeOnMainThread(() => 
                    {
                        //slUser.IsVisible = false;
                        btnSignInSignOut.Text = "Sign in"; 
                    });
                }
            }
            catch (Exception ex)
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await DisplayAlert
                    (
                        "Authentication failed. " +
                        "See exception message for details: ", 
                        ex.Message, 
                        "Dismiss"
                    );
                });
            }

        }//OnSignInSignOut        

    }//MainPage

}//MSTodoX
