using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fahrenheit__celsius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Oppg 1
            double fahrenheit = 98; //Bruker double fordi jeg skal regne med desimaler
            //Oppg 2
            Console.WriteLine($"Fahrenheit: {fahrenheit}");
            //Oppg 3
            double celsius = Math.Round((fahrenheit - 32) * 5 / 9, 2); //Runder av til to desimaler
            
            //Oppg 4
            Console.WriteLine($"Calsius: {celsius}");

            //Oppg 5
            while (true)
            {
                try
                {
                    Console.WriteLine("Hva vil du gjøre om fra fahrenheit til celsius");
                    double start = Convert.ToDouble(Console.ReadLine()); //Converterer fra string til double. Hvis dette ikke går så vil det blri fanget opp av try-catch
                    double svar = Math.Round((start - 32) * 5 / 9, 2);
                    Console.WriteLine($"{start} Fahrenheit = {svar} Celsius");
                    break;
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.ReadLine();

        }
    }
}
