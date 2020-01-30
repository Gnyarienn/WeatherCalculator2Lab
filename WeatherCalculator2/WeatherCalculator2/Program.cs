using System;

namespace WeatherCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BASIC WEATHER CALCULATOR 2.0");
            int temperature;
            double RH;
            double HI;
            String input;
            double WindChill;
            int windspeed;

            Console.WriteLine("Enter Temperature");
            input = Console.ReadLine();
            temperature = int.Parse(input);




            if (temperature > 50)
            {
                Console.WriteLine("Enter Relative Humidity");
                input = Console.ReadLine();
               RH = int.Parse(input);

                HI = 0.5 * (temperature + 61.0 + ((temperature - 68) * 1.2) + (RH * 0.049));
                Console.WriteLine("Heat Index is" + HI);
            }

            else
            {
                Console.WriteLine("Enter Wind Speed");
                input = Console.ReadLine();
                windspeed = int.Parse(input);


                WindChill = 35.74 + (0.6125 * temperature) - 35.75 * Math.Pow(windspeed, 0.6) + 0.4275 * temperature * Math.Pow(windspeed, 0.16);
                Console.WriteLine("Windchill is" + WindChill);

            }

        }
    }
}
           
                

        

            

