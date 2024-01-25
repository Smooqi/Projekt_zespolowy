using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using Microsoft.EntityFrameworkCore.Diagnostics;


namespace SimpleMVC.Models
{
    public class Users
    {
        public static List<Users> userList = new List<Users>()
        {
            new Users { UserName = "u1", Password = "pass1" },
            new Users { UserName = "u2", Password = "pass2" },
        // Dodaj więcej użytkowników
        };
/*
        private readonly int id;
        public int Id { get; set; }
*/
        private string? userName;

        public string? UserName { get; set; }

        private string? password;

        public string? Password { get; set; }

  /*      private DateTime dateCreate;

        public DateTime DateCreate { get; set; }

        private DateTime dateLastLoginErr;

        public DateTime DateLastErr { get; set; }

        private DateTime dateLastLoginGood;

        public DateTime DateLastLoginGood { get; set; }

        private string email;

        public string Email { get; set; }

        private string tel;

        public string Tel { get; set; }*/
    }

}
