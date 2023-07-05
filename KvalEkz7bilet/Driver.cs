using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Reflection.Emit;
using System.Text;

namespace KvalEkz7bilet
{
    public class Driver
    {
        //Поминов Даниил
        public string Name { get; set; }
        public string Class { get; set; }
        public List<Auto> Autos = new List<Auto>();
        public Driver(string name, string aClass) 
        { 
            Name = name;
            Class = aClass;
        }
        public string ShowAll()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Информация о водителе: \nИмя - {Name}\nКвалификация - {Class}\n\nИнформация об его автомобилях:\n");
            foreach (Auto auto in Autos)
            {
                sb.Append(auto.Show());
            }
            return sb.ToString();
            //Поминов Даниил
        }
    }

    public class Auto : IComparable
    {
        public string Title { get; set; }
        public string Number { get; set; }
        public Auto(string title, string number)
        {
            Title = title;
            Number = number;
        }
        public string Show()
        {
            return $"Авто - {Title} {Number}\n";
        }
        public int CompareTo(object obj)
        {
            return (this.Title + this.Number).CompareTo(Title + Number);
        }
    }
    //Поминов Даниил
}
