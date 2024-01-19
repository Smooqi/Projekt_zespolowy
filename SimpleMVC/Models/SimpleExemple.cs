using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace SimpleMVC.Models
{

    #region Person
    public class Person
    {
        private readonly int id;
        public int Id { get; set; }

        private string? firstname;
        public string FirstName { get; set; } = string.Empty;

        private string? lastname;
        public string LastName { get; set; } = string.Empty;

        private int? age;

        public int? Age { get; set; }

        private int idincome;

        public int? IdIncome { get; set; }

        private int idspending;

        public int? IdSpending { get; set; }
    }
    #endregion

    #region Income
    public class Income
    {
        private int id;
        public int Id { get; set; }

        private float salary;
        public float Salary { get; set; }

        private float sidejob;
        public float SideJob { get; set; }

        private float rental;
        public float Rental { get; set;}
        
        private DateTime? date;
        public DateTime? Date { get; set; } 

    }
    #endregion

    #region Spending
    public class Spending
    {
        private int id;
        public int Id { get; set; }

        private float bills;
        public float Bills { get; set; }
        
        private float food;
        public float Food { get; set; }
        
        private float drugs;
        public float Drugs { get; set; }

        private float loans;
        public float Loans { get; set; }

        private float holidays;
        public float Holidays { get; set; }

        private float unexpected;
        public float Unexpected { get; set; }

        private DateTime date;
        public DateTime Date { get; set; }
        
    }

    #endregion


    #region SimpleExemple
    public class SimpleExemple
    {
        private string shape;

        public string? Shape { get; set; }

        private float girth;

        public float? Girth { get; set; }
        
        private float area;

        public float? Area { get; set; }

       public SimpleExemple(string shape, float girth, float area)
        {
            this.shape = shape;
            this.girth = girth;
            this.area = area;
        }

        public SimpleExemple()
        {
            this.shape = String.Empty;
            this.girth = 0;
            this.area = 0;
        }
    }
    #endregion 
}
