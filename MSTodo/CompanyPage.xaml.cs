using System;
using System.Collections.Generic;
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

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace MSTodo
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class CompanyPage : Page
    {
        // !
        Company company;

        public CompanyPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter != null)
            {
                int id = (int)e.Parameter;
                using (MobileContext db = new MobileContext())
                {
                    company = db.Companies.FirstOrDefault(c => c.Id == id);
                }
            }

            if (company != null)
            {
                headerBlock.Text = "Редактирование компании";
                nameBox.Text = company.Name;
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            using (MobileContext db = new MobileContext())
            {
                if (company != null)
                {
                    company.Name = nameBox.Text;
                    db.Companies.Update(company);
                }
                else
                {
                    db.Companies.Add(new Company { Name = nameBox.Text });
                }
                db.SaveChanges();
            }
            GoToMainPage();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            GoToMainPage();
        }

        private void GoToMainPage()
        {
            if (Frame.CanGoBack)
                Frame.GoBack();
            else
                Frame.Navigate(typeof(MainPage));
        }
    }
}
