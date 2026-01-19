using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andoskin3VARIANT
{
    using System;

    namespace RectangleApplication
    {
        public class Rectangle
        {
            
            public double Height; // Поля для хранения данных(Высота)
            public double Width;  // Поля для хранения данных(Ширина)

            
            public void ShowData()
            {
                Console.WriteLine ("Данные прямоугольника:"); // Вывод данных
                Console.WriteLine ($"Высота: {Height}");
                Console.WriteLine ($"Ширина: {Width}");
            }

            
            public double Perimeter() // Рассчитывает и возвращает значение 
            {
                return 2 * Height + 2 * Width;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                
                Rectangle AND = new Rectangle();

                AND.Height = 2; // Значение высоты
                AND.Width = 3;  // Значение ширины

                
                AND.ShowData();
                Console.WriteLine(); // Сделанная пустая строка

               
                double perimeter = AND.Perimeter(); // Расчет периметра
                Console.WriteLine($"Периметр прямоугольника: {perimeter}");

                Console.WriteLine("\nВыполнил стдуент группы 33ИС Андоскин Даниил");
                Console.ReadKey();
            }
        }
    }
}
