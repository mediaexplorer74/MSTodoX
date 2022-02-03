// MainPage

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using Microsoft.EntityFrameworkCore;


// MSTodo namespace

namespace MSTodo
{

    // Phone class
    public class Phone
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }//

    // Company class
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Phone> Phones { get; set; }


        public override string ToString()
        {
            return Name;
        }
    }//

    //
    public class MobileContext : DbContext
    {
        public int CompanyId { get; set; }
        public Company Companies { get; set; }



        public MobileContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Mobile.db");
        }
    }

    // MainPage class
    public sealed partial class MainPage : Page
    {
        //public ObservableCollection<Phone> Phones { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public List<Phone> Phones { get; set; }


        public MainPage()
        {
            this.InitializeComponent();

            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            using (MobileContext db = new MobileContext())
            {
                companiesList.ItemsSource = db.Companies.ToList();
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CompanyPage));
        }
    }//

    
}
