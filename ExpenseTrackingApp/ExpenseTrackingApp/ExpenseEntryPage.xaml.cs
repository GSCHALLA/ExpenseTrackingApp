using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExpenseTrackingApp.Models
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
            var expenses = new List<Expenses>();
            var files = Directory.EnumerateFiles(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "*.expense.txt");
            foreach (var filename in files)
            {
                var expense = new Expenses
                {
                    Name = File.ReadAllText(filename),
                };

                expenses.Add(expense);
            }

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