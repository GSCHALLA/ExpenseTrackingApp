using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTrackingApp.Models
{
    public class Category
    {
        public string CategoryName { get; set; }
        public string Uri { get; set; }
    }
}

public class ExpenseEntryData
    {
        public string Budget { get; set; }
    }

public class Expenses
{

    public static string FOOD = "FOOD";
    public static string TRAVEL = "TRAVEL";
    public static string INSURANCE = "INSURANCE";
    public static string UTILITIES = "UTILITIES";
    public static string MISC = "Miscellaneous";

    public static List<string> CATEGORIES = new List<string>()
    {
        FOOD,TRAVEL,INSURANCE,UTILITIES,MISC
    };


    public Dictionary<String, String> CATEGORY_URL_MAP = new Dictionary<String, String>()
        {
            { "Food", "" },
            { "Travel", "" },
            { "Insurance", "" },
            {"Utilities" , "" },
        };

        public string FileName { get; set; }
        public static decimal Budget { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public string Category { get; set; }
        public string ImageFile { get; set; }


        public string toString()
        {
            return $"{Name}\n{Amount}\n{Category}\n{DateOfPurchase}";
        }

    }


