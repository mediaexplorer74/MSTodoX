using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using MSTodoX.Model;// s;
using SQLite;
//using MSTodoX.Net;
//using MSTodoX.Net.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Todoist.Net.Models;
using Todoist.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace MSTodoX
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectBrowsePage : ContentPage
    {
        string content = string.Empty;
        public ObservableCollection<Project> Items { get; set; }

        public static string AuthKey { get; set; } = string.Empty;

        public ProjectBrowsePage()
        {
            InitializeComponent();
        }
        
        protected override void OnAppearing()
        {
            base.OnAppearing();
            using (var conn = new SQLiteConnection(App.AppDataDbString))
            {
                var item = conn.Get<AppSetting>(1);
                AuthKey = item.AuthKey;
            }

            if (string.IsNullOrEmpty(AuthKey))
            {
                DisplayAlert
                    (
                    "Action required", 
                    "You need to set auth. key first", 
                    "Ok"
                    );

                Navigation.PushAsync(new SettingPage());
            }

            LoadProjects();
        }

        //static System.Collections.Generic.IEnumerable<Project> projects
        //            = null;//await client.Projects.GetAsync();
        private async Task LoadProjects()
        {
            Items = new ObservableCollection<Project>();
            
            // "new" Todoist client
            //using (var client = new TodoistClient(AuthKey))
            //{

                if (App.authResult != null)
                {
                    content =
                        await TodoClient.GetHttpContentWithTokenAsync(App.authResult.AccessToken);

                    //UpdateUserContent(content);
                }
                else
                {
                    return;
                }

                if (!string.IsNullOrEmpty(content))
                {
                    //JObject jlists = JObject.Parse(content);
                    JToken jlists = JObject.Parse(content);

                    var jsonElement = jlists.Root.SelectToken("value");


                    IJEnumerable<JToken> Llist = jlists.Root.SelectToken("value").AsJEnumerable();
                    
                    //var jl = jlists.Root.SelectToken("value").AsJEnumerable();
                    

                    //Device.BeginInvokeOnMainThread(() =>
                    //{
                        //slUser.IsVisible = true;


                        //string json = jlists.ToString(); // ["value"]

                        //ListsItem metalist = JsonConvert.DeserializeObject<ListsItem>(json);

                        //lblId.Text = metalist.value[0].id;
                        //lblDisplayName.Text = metalist.value[0].displayName;
                        //lblIsShared.Text = (metalist.value[0].isShared).ToString();
                        //lblIsOwner.Text = (metalist.value[0].isOwner).ToString();
                        //lblWellknownListName.Text = metalist.value[0].wellknownListName;

                        //string[] pList = new string[1000];
                        int counter = 0;

                        //project = Llist.ToList<Project>();

                        foreach (JToken jlist in Llist)
                        {

                            string goodObject = jlist.ToString();
                            ListItem list = JsonConvert.DeserializeObject<ListItem>(goodObject);

                    //pList[counter] = list.displayName;

                            Project item = new Project("Test");
                            item.Id = counter.ToString();//list.id;
                            item.Name = list.displayName;
                            
                            Items.Add(item);


                            // TODO
                            /*lblId.Text = lblId.Text + " | " + list.id;

                            lblDisplayName.Text = lblDisplayName.Text + " | " + list.displayName;

                            lblIsShared.Text = lblIsShared.Text + " | " + (list.isShared).ToString();

                            lblIsOwner.Text = lblIsOwner.Text + " | " + (list.isOwner).ToString();

                            lblWellknownListName.Text = lblWellknownListName.Text + " | "
                            +  list.wellknownListName;*/
                            counter++;
                        }

                        //phonesList.BindingContext = pList;

                        //btnSignInSignOut.Text = "Sign out";
                    //});
                }
                else
                {
                    return;
                }

                //foreach (Project item in projects)
                //{
                //    Items.Add(item);
                //}
            //}

            MyListView.ItemsSource = Items;
        }//LoadProjects



        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;
            ((ListView)sender).SelectedItem = null;

            await Navigation.PushAsync(new TaskBrowsePage((Project)e.Item));
        }

        private void AddNewProjectButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddProjectPage());
        }

        // UpdateUserContent
        private void UpdateUserContent(string content)
        {
            if (!string.IsNullOrEmpty(content))
            {
                //JObject jlists = JObject.Parse(content);
                JToken jlists = JObject.Parse(content);

                var jsonElement = jlists.Root.SelectToken("value");


                IJEnumerable<JToken> Llist = jlists.Root.SelectToken("value").AsJEnumerable();

                Device.BeginInvokeOnMainThread(() =>
                {
                    //slUser.IsVisible = true;


                    //string json = jlists.ToString(); // ["value"]

                    //ListsItem metalist = JsonConvert.DeserializeObject<ListsItem>(json);

                    //lblId.Text = metalist.value[0].id;
                    //lblDisplayName.Text = metalist.value[0].displayName;
                    //lblIsShared.Text = (metalist.value[0].isShared).ToString();
                    //lblIsOwner.Text = (metalist.value[0].isOwner).ToString();
                    //lblWellknownListName.Text = metalist.value[0].wellknownListName;

                    string[] pList = new string[1000];
                    int counter = 0;

                    foreach (JToken jlist in Llist)
                    {

                        string goodObject = jlist.ToString();
                        ListItem list = JsonConvert.DeserializeObject<ListItem>(goodObject);

                        pList[counter] = list.displayName;


                        // TODO
                        /*lblId.Text = lblId.Text + " | " + list.id;
                        
                        lblDisplayName.Text = lblDisplayName.Text + " | " + list.displayName;
                        
                        lblIsShared.Text = lblIsShared.Text + " | " + (list.isShared).ToString();
                        
                        lblIsOwner.Text = lblIsOwner.Text + " | " + (list.isOwner).ToString();
                        
                        lblWellknownListName.Text = lblWellknownListName.Text + " | "
                        +  list.wellknownListName;*/
                        counter++;
                    }

                    //phonesList.BindingContext = pList;

                    //btnSignInSignOut.Text = "Sign out";
                });
            }

        }//UpdateUserContent

    }//class end
}
