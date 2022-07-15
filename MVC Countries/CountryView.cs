using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    internal class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country _displayCountry)
        {
            DisplayCountry = _displayCountry;
        }


        public void Display()
        {
            Console.WriteLine($"{DisplayCountry.Name} in in {DisplayCountry.Continent} and their flag is ");
            foreach (string color in DisplayCountry.Colors)
            {
                Console.WriteLine(color);
            }
               //make for each on display country.colors
               ////cw each string in foreach  $"{DisplayCountry.Colors}.");
        }


    }
}
