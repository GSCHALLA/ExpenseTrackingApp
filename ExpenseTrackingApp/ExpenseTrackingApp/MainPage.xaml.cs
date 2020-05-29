using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseTrackingApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExpenseTrackingApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public static string BudgetSet { get; set; }
        public static string BudgetFile { get; set; }

       

        public MainPage()
        {
            InitializeComponent();


        }


        private async void OnSaveButtonClicked(object sender, EventArgs e)
        {

            //var expense = (Expenses)BindingContext;

            //var expenses = Path.Combine
            //    (Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            //    $"{Path.GetRandomFileName()}.expense.txt");
            ////File.WriteAllText(expenses, editor.Name);

            await Navigation.PushModalAsync(new ExpenseEntryPage
            {
                BindingContext = new ExpenseEntryData
                {
                    Budget = budget.Text
                }
            });
        }
    

            private void OnDeleteButtonClicked(object sender, EventArgs e)
            {

            }
        }
    }


