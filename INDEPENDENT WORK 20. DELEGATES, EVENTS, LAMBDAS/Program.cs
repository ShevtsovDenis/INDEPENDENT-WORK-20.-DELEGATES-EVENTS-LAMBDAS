using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1. В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
-       метод получает входным параметром переменную типа double;
-       метод возвращает значение типа double, которое является результатом вычисления.
     Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
-       длину окружности по формуле D = 2 * π* R;
-       площадь круга по формуле S = π* R²;
-       объем шара. Формула V = 4/3 * π * R³.*/

namespace INDEPENDENT_WORK_20.DELEGATES__EVENTS__LAMBDAS
{
    class Program
    {
        static double GetLenght (double r)//создаем метод для вычисления длины окружности, с указанной сигнатурой
        {
            double d = 2 * Math.PI * Math.Abs(r);
            Console.WriteLine("Длина окружности равна {0:f2}",d);
            return d;
        }
        static double GetSquare(double r)//создаем метод для вычисления площади окружности, с указанной сигнатурой
        {
            double s = Math.PI * Math.Pow(r,2);
            Console.WriteLine("Площадь окружности равна {0:f2}",s);
            return s;
        }
        static double GetVolume(double r)//создаем метод для вычисления объема шара, с указанной сигнатурой
        {
            double v =4.0/3* Math.PI * Math.Pow(Math.Abs(r),3);
            Console.WriteLine("Объем шара равен {0:f2}",v);
            return v;
        }

        delegate double MyDelegate(double r);//создаем делегат с сигнатурой, соответствующей созданым методам

        static void Main(string[] args)
        {
            MyDelegate myDelegate = GetLenght;//создаем экземпляр делегата и связываем его с первым методом
            myDelegate += GetSquare;//добавляем связь со вторым методом
            myDelegate += GetVolume;//добавляем связь с третьим методом
            myDelegate(2);//передаем аргумент
            Console.ReadKey();
        }
    }
}
