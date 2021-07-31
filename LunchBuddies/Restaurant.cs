using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuddies
{
    class Restaurant
    {
        public string RestaurantName;
        readonly List<string> _Restaurants = new List<string> { "Dinos", "Dinos 1", "Dinos 2", "Dinos 3" };



        public Restaurant(string restaurantName)
        {
            Random rand = new Random();
            int index = rand.Next(_Restaurants.Count);
            RestaurantName = _Restaurants[index];
            
        }
    }
}
