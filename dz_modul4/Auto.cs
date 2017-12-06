using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace dz_4modul
{
    public partial class Auto : Auto2
    {
        private string NameOfModel;
        private string TypeOfEngine;
        private double price;
        private long PowerOfEngine;
        private int CountOfPlaces;
        public static string NameOfFirm;
        public static int CountOfCircles;
        static Auto()
        {
            NameOfFirm = "Запорожец";
            CountOfCircles = 4;
        }
        public Auto(long PowerOfEngine, double price)
        {
            this.PowerOfEngine = PowerOfEngine;
            this.price = price;
        }
        public Auto()
        {
        }
        public string GetNameOfModel()
        {
            return NameOfModel;
        }
        public void SetNameOfModel(string name)
        {
            this.NameOfModel = name;
        }
        public string GetTypeOfEngine()
        {
            return TypeOfEngine;
        }
        public void SetTypeOfEngine(string name)
        {
            this.TypeOfEngine = name;
        }
        public double GetPrice()
        {
            return price;
        }
        public void SetPrice(double price)
        {
            this.price = price;
        }
        public long GetPowerOfEngine()
        {
            return PowerOfEngine;
        }
        public void SetPowerOfEngine(long power)
        {
            this.PowerOfEngine = power;
        }
        public int GetCountOfPlaces()
        {
            return CountOfPlaces;
        }
        public void SetCountOfPlaces(int count)
        {
            this.CountOfPlaces = count;
        }
        public void show()
        {
            WriteLine("Название модели " + NameOfModel);
            WriteLine("Тип двигателя " + TypeOfEngine);
            WriteLine("Цена- " + price);
            WriteLine("Мощность двигателя-" + PowerOfEngine);
            WriteLine("Количество мест " + CountOfPlaces);
            WriteLine("Название фирмы производителя " + NameOfFirm);
            WriteLine("Количество колес " + CountOfCircles);
        }

    }
}




