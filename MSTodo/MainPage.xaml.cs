
using Microsoft.Graph;
using Microsoft.Graph.Core;

using Microsoft.Identity.Client;
using System;
using System.Collections.Generic; // !
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

using Microsoft.EntityFrameworkCore; // !


using System.Diagnostics;
using System.Net.Http.Headers;

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Todo.Core.Model;
using TaskStatus = Microsoft.Graph.TaskStatus;
using System.Threading.Tasks;



// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace MSTodo
{

    // Класс Phone, который будет представлять модель телефона
    // о-вторых, для создания связи "один-ко-многим" зависимая модель должна 
    // содержать ключ. В нашем случае зависимой моделью является Phone, 
    // поэтому он определяет ключ в виде двух свойств:
    //    1) public int CompanyId { get; set; }
    //    2) public Company Company { get; set; }
    public class Phone
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }

        
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }

    // Класс Company, который представляет компанию-производителя телефона
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Phone> Phones { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    // После определения моделей нам надо добавить в проект класс контекста данных, 
    // через который приложение будет взаимодействовать с базой данных.
    // Итак, добавим в проект новый класс MobileContext :
    public class MobileContext : DbContext
    {
        // Класс контекста данных должен быть унаследован от базового класса DbContext, 
        // а для взаимодействия с таблицами в базе данных в нем определяются свойства 
        // по типу DbSet<T>. 
        // То есть через свойство Companies будет идти взаимодействие с таблицей компаний, 
        // а через свойство Phones - взаимодействие с таблицей телефонов.
        public DbSet<Company> Companies { get; set; }
        public DbSet<Phone> Phones { get; set; }

        // В конструкторе контекста мы генерируем базу данных, 
        // которая соответствует определению моделей, с помощью 
        // выражения Database.EnsureCreated().
        public MobileContext()
        {
            Database.EnsureCreated();
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Mobile.db");
        }
    }

    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //Set the scope for API call to user.read
        private string[] scopes = new string[] { "user.read", "tasks.readwrite", "device.read" };

        // Below are the clientId (Application Id) of your app registration and the tenant information. 
        // You have to replace:
        // - the content of ClientID with the Application Id for your app registration
        // - The content of Tenant by the information about the accounts allowed to sign-in in your application:
        //   - For Work or School account in your org, use your tenant ID, or domain
        //   - for any Work or School accounts, use organizations
        //   - for any Work or School accounts, or Microsoft personal account, use common
        //   - for Microsoft Personal account, use consumers
        private const string ClientId = "4a1aa1d5-c567-49d0-ad0b-cd957a47f842";

        private const string Tenant = "common"; // Alternatively "[Enter your tenant, as obtained from the azure portal, e.g. kko365.onmicrosoft.com]"
        private const string Authority = "https://login.microsoftonline.com/" + Tenant;

        // The MSAL Public client app
        private static IPublicClientApplication PublicClientApp;

        private static string MSGraphURL = "https://graph.microsoft.com/v1.0/";
        private static AuthenticationResult authResult;



        public MainPage()
        {
            this.InitializeComponent();

            // !
            this.Loaded += MainPage_Loaded;
        }





        // При загрузке страницы срабатывает обработчик MainPage_Loaded, 
        // в котором получаем список компаний из базы данных и устанавливаем его 
        // в качестве источника данных для ListView
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            using (MobileContext db = new MobileContext())
            {
                companiesList.ItemsSource = db.Companies.ToList();
            }
        }


        /// <summary>
        /// Call AcquireTokenAsync - to acquire a token requiring user to sign-in
        /// </summary>
        /*
        private async void CallGraphButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Sign-in user using MSAL and obtain an access token for MS Graph
                GraphServiceClient graphClient = await SignInAndInitializeGraphServiceClient(scopes);

                // Call the /me endpoint of Graph
                User graphUser = await graphClient.Me.Request().GetAsync();

                // Go back to the UI thread to make changes to the UI
                await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                {
                    ResultText.Text = "Display Name: " + graphUser.DisplayName + "\nBusiness Phone: " + graphUser.BusinessPhones.FirstOrDefault()
                                      + "\nGiven Name: " + graphUser.GivenName + "\nid: " + graphUser.Id
                                      + "\nUser Principal Name: " + graphUser.UserPrincipalName;
                    
                    DisplayBasicTokenInfo(authResult);
                    
                    this.SignOutButton.Visibility = Visibility.Visible;
                });
            }
            catch (MsalException msalEx)
            {
                await DisplayMessageAsync($"Error Acquiring Token:{System.Environment.NewLine}{msalEx}");
            }
            catch (Exception ex)
            {
                await DisplayMessageAsync($"Error Acquiring Token Silently:{System.Environment.NewLine}{ex}");
                return;
            }
        }
        */


        // ***************************************

        //public async Task<IEnumerable<TodoItem>> ListAsync(bool listAll)
        private async void CallGraphButton_Click(object sender, RoutedEventArgs e)
        {
            // Plan B
            //this.SignOutButton.Visibility = Visibility.Visible;

            //IEnumerable<TodoItem> rrr;
            try
            {

                //var graphServiceClient = new GraphServiceClient(AuthenticationProvider);

                // Sign-in user using MSAL and obtain an access token for MS Graph
                GraphServiceClient graphClient = await SignInAndInitializeGraphServiceClient(scopes);

                //IUserManagedDevicesCollectionRequest 
                //IUserOwnedDevicesCollectionWithReferencesPage devices =
                //    await graphClient.Me.OwnedDevices.Request().GetAsync();
                //ManagedDevices.Request().GetAsync(); //.Outlook.Tasks.Request();
                //IUserManagedDevicesCollectionPage tasks = await request.GetAsync();
                var tasks = await graphClient.Me.Outlook.Tasks.Request().GetAsync();
                //var lists = await graphClient.Me.Todo.Lists
                //.Request()
                //.GetAsync();

                //if (!listAll)
                //{
                //tasks.Filter($"status ne '{TaskStatus.Completed.ToString().ToLower()}'");
                //}                

                IEnumerable<TodoItem> mytasks = tasks.Select(task => new TodoItem()
                {
                    Id = task.Id,
                    Subject = task.Subject,
                    IsCompleted = task.Status == TaskStatus.Completed
                });

                /*
                //return
                rrr = tasks.Select(task => new TodoItem()
                {
                    Id = task.Id,
                    Subject = task.DeviceCategory.ToString(),//task.Subject,
                    IsCompleted = task.EasActivated.Value == true//task.Status == TaskStatus.Completed
                });
                */



                // Go back to the UI thread to make changes to the UI
                await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                {
                    //.AdditionalData//.Client.ToString() 
                    //+ "\nUser device ContentType: " + devices.ContentType.ToString() 
                    //+ "\nUser device is readonly: " + rdevices.IsReadOnly
                    //ResultText.Text = "User device AdditionalData: " + mytasks.
                    //                  + "\nUser device Count: ";// + rdevices.Count.;

                    foreach(TodoItem ttask in mytasks)
                    {
                        ResultText.Text = ResultText.Text + "\n" + ttask.Id 
                        + "\n" + ttask.Subject
                        + "\n" + ttask.IsCompleted; 
                    }

                    //DisplayBasicTokenInfo(authResult);

                    this.SignOutButton.Visibility = Visibility.Visible;
                });

            }
            catch (MsalException msalEx)
            {
                await DisplayMessageAsync($"Error Acquiring Token:{System.Environment.NewLine}{msalEx}");
            }
            catch (Exception ex)
            {
                await DisplayMessageAsync($"Error Acquiring Token Silently:{System.Environment.NewLine}{ex}");
                
                //return null;
            }
            
            //return null;
        }



            // ***************************************



            /// <summary>
            /// Signs in the user and obtains an Access token for MS Graph
            /// </summary>
            /// <param name="scopes"></param>
            /// <returns> Access Token</returns>
            private static async Task<string> SignInUserAndGetTokenUsingMSAL(string[] scopes)
        {
            // Initialize the MSAL library by building a public client application
            PublicClientApp = PublicClientApplicationBuilder.Create(ClientId)
                .WithAuthority(Authority)
                .WithUseCorporateNetwork(false)
                .WithRedirectUri(DefaultRedirectUri.Value)
                 .WithLogging((level, message, containsPii) =>
                 {
                     Debug.WriteLine($"MSAL: {level} {message} ");
                 }, LogLevel.Warning, enablePiiLogging: false, enableDefaultPlatformLogging: true)
                .Build();

            // It's good practice to not do work on the UI thread, so use ConfigureAwait(false) whenever possible.
            IEnumerable<IAccount> accounts = await PublicClientApp.GetAccountsAsync().ConfigureAwait(false);
            IAccount firstAccount = accounts.FirstOrDefault();

            try
            {
                authResult = await PublicClientApp.AcquireTokenSilent(scopes, firstAccount)
                                                  .ExecuteAsync();
            }
            catch (MsalUiRequiredException ex)
            {
                // A MsalUiRequiredException happened on AcquireTokenSilentAsync. This indicates you need to call AcquireTokenAsync to acquire a token
                Debug.WriteLine($"MsalUiRequiredException: {ex.Message}");

                authResult = await PublicClientApp.AcquireTokenInteractive(scopes)
                                                  .ExecuteAsync()
                                                  .ConfigureAwait(false);

            }
            return authResult.AccessToken;
        }

        /// <summary>
        /// Sign in user using MSAL and obtain a token for MS Graph
        /// </summary>
        /// <returns>GraphServiceClient</returns>
        private async static Task<GraphServiceClient> SignInAndInitializeGraphServiceClient(string[] scopes)
        {
            GraphServiceClient graphClient = new GraphServiceClient(MSGraphURL,
                new DelegateAuthenticationProvider(async (requestMessage) =>
                {
                    requestMessage.Headers.Authorization = new AuthenticationHeaderValue("bearer", await SignInUserAndGetTokenUsingMSAL(scopes));
                }));

            return await Task.FromResult(graphClient);
        }

        /// <summary>
        /// Sign out the current user
        /// </summary>
        private async void SignOutButton_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<IAccount> accounts = await PublicClientApp.GetAccountsAsync().ConfigureAwait(false);
            IAccount firstAccount = accounts.FirstOrDefault();

            try
            {
                await PublicClientApp.RemoveAsync(firstAccount).ConfigureAwait(false);
                await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                {
                    ResultText.Text = "User has signed-out";
                    this.CallGraphButton.Visibility = Visibility.Visible;
                    this.SignOutButton.Visibility = Visibility.Collapsed;
                });
            }
            catch (MsalException ex)
            {
                ResultText.Text = $"Error signing-out user: {ex.Message}";
            }
        }

        /// <summary>
        /// Display basic information contained in the token. Needs to be called from the UI thead.
        /// </summary>
        private void DisplayBasicTokenInfo(AuthenticationResult authResult)
        {
            TokenInfoText.Text = "";
            if (authResult != null)
            {
                TokenInfoText.Text += $"User Name: {authResult.Account.Username}" + Environment.NewLine;
                TokenInfoText.Text += $"Token Expires: {authResult.ExpiresOn.ToLocalTime()}" + Environment.NewLine;
            }
        }

        /// <summary>
        /// Displays a message in the ResultText. Can be called from any thread.
        /// </summary>
        private async Task DisplayMessageAsync(string message)
        {
            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
                   () =>
                   {
                       ResultText.Text = message;
                   });
        }






        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CompanyPage));
        }

        // !
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            // получаем выделеный пункт меню
            if (companiesList.SelectedItem != null)
            {
                Company company = companiesList.SelectedItem as Company;
                if (company != null)
                    Frame.Navigate(typeof(CompanyPage), company.Id);
            }
        }

        // !
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            // получаем выделеный пункт меню
            if (companiesList.SelectedItem != null)
            {
                Company company = companiesList.SelectedItem as Company;
                if (company != null)
                {
                    using (MobileContext db = new MobileContext())
                    {
                        db.Companies.Remove(company);
                        db.SaveChanges();
                        companiesList.ItemsSource = db.Companies.ToList();
                    }
                }
            }
        }
    }
}
