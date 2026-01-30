using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SV.Services
{
    public class RestaurantPickerService
    {
        public string RestaurantPicker(int num)
        {
            int rng = Random.Shared.Next(0, 10);
            return num switch
            {
                0 => rng switch
                {
                    0 => "Burger King",
                    1 => "Carl's Jr.",
                    2 => "Chick-fil-A",
                    3 => "Five Guys",
                    4 => "In-N-Out",
                    5 => "Jack in the Box",
                    6 => "KFC",
                    7 => "McDonald's",
                    8 => "Popeyes",
                    9 => "Wendy's",
                    _ => ""
                },
                1 => rng switch
                {
                    0 => "Adalberto's (Stockton)",
                    1 => "Arroyo's Cafe (Stockton)",
                    2 => "Chipotle",
                    3 => "Del Taco",
                    4 => "Don Luis (Stockton)",
                    5 => "El Grullito (Stockton)",
                    6 => "El Pollo Loco",
                    7 => "Nena's (Stockton)",
                    8 => "Taco Bell",
                    9 => "Xochimilco Cafe (Stockton)",
                    _ => ""
                },
                2 => rng switch
                {
                    0 => "Angelina's (Stockton)",
                    1 => "De Vinci's (Stockton)",
                    2 => "Domino's",
                    3 => "Little Caesars",
                    4 => "Mountain Mike's",
                    5 => "Olive Garden",
                    6 => "Papa John's",
                    7 => "Pizza Hut",
                    8 => "Round Table",
                    9 => "The Old Spaghetti Factory",
                    _ => ""
                },
                _ => ""
            };
        }
    }
}
