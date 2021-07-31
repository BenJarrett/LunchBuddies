using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuddies
{
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }




        public LunchBuddy(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }
    }
}

