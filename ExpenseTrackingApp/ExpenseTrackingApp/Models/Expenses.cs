using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTrackingApp.Models
{
    public enum ExpenseCategory
    {
        Travel,
        Insurance,
        Food,
        Utilities,
        Miscellaneous

    }
    public class Expenses
    {
        public string FileName { get; set; }
        public static decimal Budget { get; set; }
        public string Name { get; set; }
        public decimal ExpenseAmount { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public ExpenseCategory Category { get; set; }
        public string ImageFile { get; set; }


        //public  Expenses(string name , int amount , DateTime dateOfPurchase , ExpenseCategory category )
        //{
        //    Name = name;
        //    Amount = amount;
        //    DateOfPurchase = dateOfPurchase;
        //    Category = category;


        //}



    }
}
