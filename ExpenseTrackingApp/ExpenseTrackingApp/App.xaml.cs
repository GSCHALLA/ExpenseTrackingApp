using System;
using System.IO;
using ExpenseTrackingApp.Models;
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

            var expenseBudgetPath = Path.Combine
                (Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
               "ExpenseBudget.txt");

            if(File.Exists(expenseBudgetPath))
            {
                var budget = File.ReadAllText(expenseBudgetPath);
                MainPage = new ExpenseEntryPage
                {
                    Budget = budget
                };
            }
            else
            {
                MainPage = new MainPage();
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
