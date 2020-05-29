using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExpenseTrackingApp
{
    public partial class App : Application
    {
        public static string BudgetFile { get; internal set; }
        public static string IsBudgetSet { get; set; }
        public static string BudgetCost { get; set; }
        public static  bool SetInitialBudget { get; set; }


        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            
            var FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
            , "MyExpenses");

            if(Directory.Exists(FolderPath))
            {
                    
            }
            else
            {
                Directory.CreateDirectory(FolderPath);
            }

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
