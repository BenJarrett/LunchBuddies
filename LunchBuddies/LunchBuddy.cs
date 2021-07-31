
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuddies.LunchBuddy
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

        public void Eat()
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is at {restaurant.RestaurantName}");

        }

        public void Eat(string food)
        {
            Console.WriteLine($"{FirstName} {LastName} ate {food} at the office.");
        }

        public void Eat(List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} is at {restaurant.RestaurantName} with ");
            foreach (var item in companions)
            {
                Console.WriteLine($"{item.FirstName}");
            }
        }

        public void Eat(string food, List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} orded {food} at {restaurant.RestaurantName} with ");
            foreach (var item in companions)
            {
                Console.WriteLine($"{item.FirstName}");
            }
        }

    }
}

