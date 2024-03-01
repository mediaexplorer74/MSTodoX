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

// MSTodoX
namespace MSTodoX
{
    // MainPage class
    public partial class MainPage : ContentPage
    {

        // MainPage
        public MainPage()
        {
            InitializeComponent();

        }//MainPage


        // Setting_OnClicked
        private void Setting_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SettingPage());

        }//Setting_OnClicked


        // OnSignInSignOut
        async void OnSignInSignOut(object sender, EventArgs e)
        {
            AuthenticationResult authResult = null;

            IEnumerable<IAccount> accounts = 
                await App.PCA.GetAccountsAsync().ConfigureAwait(false);
            
            try
            {
                if (btnSignInSignOut.Text == "Sign in")
                {
                    try
                    {
                        IAccount firstAccount = accounts.FirstOrDefault();
                        authResult = await App.PCA.AcquireTokenSilent
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

                            authResult = await builder.ExecuteAsync().ConfigureAwait(false);
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

                    if (authResult != null)
                    {
                        var content = 
                            await GetHttpContentWithTokenAsync(authResult.AccessToken);
                        
                        UpdateUserContent(content);
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
                        slUser.IsVisible = false;
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


        // UpdateUserContent
        private void UpdateUserContent(string content)
        {
            if(!string.IsNullOrEmpty(content))
            {
                //JObject jlists = JObject.Parse(content);
                JToken jlists = JObject.Parse(content);

                var jsonElement = jlists.Root.SelectToken("value");


                IJEnumerable<JToken> Llist = jlists.Root.SelectToken("value").AsJEnumerable();

                Device.BeginInvokeOnMainThread(() =>
                {
                    slUser.IsVisible = true;

                   
                    //string json = jlists.ToString(); // ["value"]

                    //ListsItem metalist = JsonConvert.DeserializeObject<ListsItem>(json);

                    //lblId.Text = metalist.value[0].id;
                    //lblDisplayName.Text = metalist.value[0].displayName;
                    //lblIsShared.Text = (metalist.value[0].isShared).ToString();
                    //lblIsOwner.Text = (metalist.value[0].isOwner).ToString();
                    //lblWellknownListName.Text = metalist.value[0].wellknownListName;

                    foreach (JToken jlist in Llist)
                    {
                        string goodObject = jlist.ToString();
                        ListItem list = JsonConvert.DeserializeObject<ListItem>(goodObject);

                        // TODO
                        lblId.Text = lblId.Text + " | " + list.id;
                        
                        lblDisplayName.Text = lblDisplayName.Text + " | " + list.displayName;
                        
                        lblIsShared.Text = lblIsShared.Text + " | " + (list.isShared).ToString();
                        
                        lblIsOwner.Text = lblIsOwner.Text + " | " + (list.isOwner).ToString();
                        
                        lblWellknownListName.Text = lblWellknownListName.Text + " | "
                        +  list.wellknownListName;
                    }

                    btnSignInSignOut.Text = "Sign out";
                });
            }

        }//UpdateUserContent


        // GetHttpContentWithTokenAsync
        public async Task<string> GetHttpContentWithTokenAsync(string token)
        {
            try
            {
                //get data from API
                HttpClient client = new HttpClient();
                HttpRequestMessage message =
                new HttpRequestMessage
                 (HttpMethod.Get, "https://graph.microsoft.com/v1.0//me/todo/lists");
                //new HttpRequestMessage
                // (HttpMethod.Get, "https://graph.microsoft.com/v1.0/me");

                message.Headers.Authorization = 
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                HttpResponseMessage response = 
                    await client.SendAsync(message).ConfigureAwait(false);
                string responseString = 
                    await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return responseString;
            }
            catch(Exception ex)
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await DisplayAlert("API call to graph failed: ", 
                        ex.Message, "Dismiss").ConfigureAwait(false);
                });
                return ex.ToString();
            }

        }//GetHttpContentWithTokenAsync

    }//MainPage

}//MSTodoX
