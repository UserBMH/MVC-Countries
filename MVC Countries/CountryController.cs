using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    internal class CountryController
    {

        public List<Country> CountryDb { get; set; }

        public CountryController()
            {
            CountryDb = new List<Country>()
                {
                    new Country("Germany", "Europe", new List<string>
                    {
                        "Black",
                        "Red",
                        "Yellow",
                    }),
                    new Country("Canada", "North America", new List<string>
                    {
                        "Red",
                        "White",

                    }),
                    new Country("Australia", "Australia", new List<string>
                    {
                        "Blue",
                        "Red",
                        "White",
                    })
                };
             }


       
        
        
        public void CountryAction(Country c)
        {
            CountryView View = new CountryView(c);
            View.Display();
            
        }


        public void WelcomeAction()
        {
            string inputloop = "y";
            CountryListView listviews = new CountryListView(CountryDb);
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
           while (inputloop == "y")
            {
                listviews.Display();
                Console.WriteLine("Search by number");
                int input = int.Parse(Console.ReadLine());
                CountryAction(CountryDb[input - 1]);

                Console.WriteLine("Search again? y/n");
                inputloop = Console.ReadLine();

                if (inputloop == "y")
                {

                }
                else
                {
                    inputloop = "n";
                }
            }
        }


       



    }
}
