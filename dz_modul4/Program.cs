using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace dz_4modul
{
    class Program
    {
        static void Main(string[] args)
        {
            string _NameOfModel = "";
            string _TypeOfEngine = "";
            double _price = 0;
            long _PowerOfEngine = 0;
            int _CountOfPlaces = 0;
            Auto auto = new Auto(4, 10000000);

            WriteLine("Введите название модели");
            _NameOfModel = ReadLine();
            auto.SetNameOfModel(_NameOfModel);
            WriteLine("Введите тип двигателся");
            _TypeOfEngine = ReadLine();
            auto.SetTypeOfEngine(_TypeOfEngine);
            WriteLine("Введите цену");
            while (!double.TryParse(ReadLine(), out _price))
            {
                Write("Error");
            }
            auto.SetPrice(_price);
            WriteLine("Введите количество мест");
            while (!int.TryParse(ReadLine(), out _CountOfPlaces))
            {
                Write("Error");
            }
            auto.SetCountOfPlaces(_CountOfPlaces);
            WriteLine("Введите мощность двигателя");
            while (!long.TryParse(ReadLine(), out _PowerOfEngine))
            {
                Write("Error");
            }
            auto.SetPowerOfEngine(_PowerOfEngine);

            auto.show();
            auto.showCountOfModelsOverTheWorld();
            ReadLine();
        }
    }

}
