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
        readonly List<string> _restaurants = new List<string> { "Dinos", "Dinos 1", "Dinos 2", "Dinos 3" };



        public Restaurant()
        {
            Random randomRestaurant = new();
            int index = randomRestaurant.Next(_restaurants.Count);
            RestaurantName = _restaurants[index];
            
        }
    }
}
