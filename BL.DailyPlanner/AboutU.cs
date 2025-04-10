using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DailyPlanner
{
    public class AboutU
    {
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static int Age { get; set; }
        public static string Email { get; set; }

        public static void UserInfo (string fName, string lName, int age, string email)
        {
            FirstName = fName;
            LastName = lName;
            Age = age;
            Email = email;

        }

        public static string UserSummary()
        {
            return $"User: {FirstName} {LastName}, Age: {Age}, Email: {Email}";
        }
    }
}
