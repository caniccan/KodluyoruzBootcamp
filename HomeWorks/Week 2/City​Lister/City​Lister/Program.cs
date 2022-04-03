using System;
using System.Collections.Generic;
using System.Linq;

namespace City_Lister
{
    class Program
    {
        static void Main()
        {
            List<string> cities=new List<string> {"Ankara", "Ankara", "Ankara", "Sinop", "İstanbul", "İstanbul", "Eskişehir", "Ankara" };
            Menu(cities);           
                                                                        //we created the list and were redirected to the menu
        }
        public static void Menu(List<string> cities) 
        {
            Console.WriteLine("What action do u want to take");
            Console.WriteLine("1- Add City");
            Console.WriteLine("2- Show City List");                     //we showed the menu
            Console.WriteLine("3- Exit the Lister");
            int actionNumber = Convert.ToInt32(Console.ReadLine());

            if (actionNumber == 1)
            {
                CityAdd(cities);
            }
            else if (actionNumber == 2)                                 //we have processed according to the value entered
            {
                CityList(cities);
            }
            else if (actionNumber == 3)
            {
                Console.WriteLine("Exited the Lister");
            }
        }

        public static List<string> CityList(List<string> cities)
        {
            List<string> cityList = cities.Distinct().ToList();
            
            foreach (var item in cityList)                            //we showed the list
            {
                Console.WriteLine(item);
            }
            return cityList;
        }
         static void CityAdd(List<string> cities) 
        {
            Console.Write("Input city to add: ");                   //we added city to list
            cities.Add(Console.ReadLine());

            Console.WriteLine("Do you wanna show city list ? [y/n]");
            bool showCityList = Console.ReadLine().ToUpper() == "Y";        //We have done the requested action.
            if (showCityList)
            {
                CityList(cities);
            }
            else
            {
                Menu(cities);
            }
        }
        
        

    }
}
