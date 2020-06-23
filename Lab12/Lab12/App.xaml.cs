using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Lab12.DataContext;
using Lab12.Interfaces;
using Lab12.Views;


namespace Lab12
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            GetContext().Database.EnsureCreated();
            MainPage = new NavigationPage(new Views.MainPage());

        }

        public static AppDbContext GetContext()
        {
            string DbPath = DependencyService.Get<IConfigDataBase>().GetFullPath("efCore.db");

            return new AppDbContext(DbPath);
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
