using KvalEkz7bilet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvalEkz7biletConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver("Поминов Даниил", "A, B, M");
            Auto auto1 = new Auto("Suzuki Grand Vitara", "К124ЕХ777");
            Auto auto2 = new Auto("Lexus IS 200", "М753ТР97");
            Auto auto3 = new Auto("VW Transporter t6", "А142ПА777");
            driver.Autos.Add(auto1);
            driver.Autos.Add(auto2);
            driver.Autos.Add(auto3);
            Console.WriteLine(driver.ShowAll());
            Console.ReadLine();
            //Поминов Даниил
        }
    }
}
