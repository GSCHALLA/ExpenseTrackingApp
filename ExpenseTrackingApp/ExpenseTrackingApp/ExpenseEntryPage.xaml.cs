using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseTrackingApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExpenseTrackingApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExpenseEntryPage : ContentPage
    {

        public string Budget { get; set; }
  
        public ExpenseEntryPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            BudgetLabel.Text = $"BudgetExpense is {Budget}";




            var expenseDataFiles = Directory.EnumerateFiles(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "*.expenses.txt").ToList();

            var expenses = new List<Expenses>();


            foreach (var dataFile in expenseDataFiles)
            {
                /*//fruits \n 10 \n food
                File.Delete(dataFile);
                continue;*/
               
                var data = File.ReadAllText(dataFile);
                Console.WriteLine(data);
                string[] dataSplit = data.Split('\n');

                
                var expense = new Expenses
                {
                    Name = dataSplit[0],
                    Amount = Convert.ToDecimal(dataSplit[1]), 
                    Category = dataSplit[2],
                     DateOfPurchase = Convert.ToDateTime(dataSplit[3])
                };

                expenses.Add(expense);
            }

            listview.ItemsSource = expenses;
        }


        private async void OnAddExpensesClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ExpenseModel
            {
                BindingContext = new Expenses()
            }) ;
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {

        }

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {

        }
    }
}

//var expense = (Expenses)BindingContext;
//if(string.IsNullOrWhiteSpace(expense.name))
//{
//    //create and add

//var entryname = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
//        $"{Path.GetRandomFileName()}.expenses.txt");

//   // File.WriteAllText(entryname, editor.Text);

//}
//else
//{
//    //File.WriteAllText(expense.name, editor.Text);
//}