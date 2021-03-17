using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Module_2.Controllers
{
    public class Assignment_2Controller : ApiController
    {
        /// <summary>
        /// Calculates the number of calorties of the menu. Returns a message with the total of the calories.
        /// </summary>
        /// <param name="burger">The number of calories in a burger</param>
        /// <param name="side">The number of calories in a side</param>
        /// <param name="drink">The number of calories in drink</param>
        /// <param name="dessert">The number of calorties in a drink</param>
        /// <returns>"Your total count of calories is (sum of parameters)</returns>
        /// <example>
        ///     GET api/Assignment_1/Menu/0/0/0/0/		-> "Tour total count of calories is 0"
        [HttpGet]
        [Route("api/Assignment_2/Menu/{burger}/{drink}/{side}/{dessert}")]
      public string Menu (int burger, int side, int drink, int dessert)
        {
            int burgerCalories = 0;
            if (burger == 1)
                burgerCalories = 461;
            else if (burger == 2)
                burgerCalories = 431;
            else if (burger == 3)
                burgerCalories = 420;
            else if (burger == 4)
                burgerCalories = 0;
            int sideCalories = 0;
            if (side == 1)
                sideCalories = 100;
            else if (side == 2)
                sideCalories = 57;
            else if (side == 3)
                sideCalories = 70;
            else if (side == 4)
                sideCalories = 0;
            int drinkCalories = 0;
            if (drink == 1)
                drinkCalories = 130;
            else if (drink == 2)
                drinkCalories = 160;
            else if (drink == 3)
                drinkCalories = 118;
            else if (drink == 4)
                drinkCalories = 0;
            int dessertCalories = 0;
            if (dessert == 1)
                dessertCalories = 167;
            else if (dessert == 2)
                dessertCalories = 266;
            else if (dessert == 3)
                dessertCalories = 75;
            else if (dessert == 4)
                dessertCalories = 0;

            int sum = burgerCalories + sideCalories + drinkCalories + dessertCalories;
            return "Your total count of calories is " + sum + "!";
        }
    }
}
