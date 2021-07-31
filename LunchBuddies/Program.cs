using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            var lunchBuddy = new LunchBuddy.LunchBuddy("Cheyenne", "Bilderback");
            lunchBuddy.Eat();

            lunchBuddy.Eat("Cream Cheese");

            lunchBuddy.Eat(new List<LunchBuddy.LunchBuddy>
            {
                new LunchBuddy.LunchBuddy("Rowan", "Lafontaine")
            });

            lunchBuddy.Eat("Wings", new List<LunchBuddy.LunchBuddy>
            {
                new LunchBuddy.LunchBuddy("Puck", "Jarrett")
            });
            
        }

    }
}
