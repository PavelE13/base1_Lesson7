using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base2_Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region //Ввод значений
            Console.WriteLine(" Введите одну из сторон куба х по длине его ребра:");
            int x = Convert.ToInt32(Console.ReadLine());
            #endregion
            double ValCube = ValCubeCalc (x); //вызов метода расчета объема куба;                          
            double SurfCube = SurfCubeCalc(x); //вызов метода расчета S поверхности куба;  
            /*if (triangleSquare1 == triangleSquare2)
            {
                Console.WriteLine(" Треугольники №1 = №2 = {0:f3}!", triangleSquare1); //Вывод результатов
            }
            else
            {
                if (triangleSquare1 > triangleSquare2 && triangleSquare1 != 0 && triangleSquare2 != 0)
                {
                    Console.WriteLine(" Площадь треугольника №1= {0:f3} больше площади треугольника №2= {1:f3}!", triangleSquare1, triangleSquare2); //Вывод результатов
                }
                else
                {
                    Console.WriteLine(" Площадь треугольника №2= {0:f3} больше площади треугольника №1= {1:f3}!", triangleSquare2, triangleSquare1); //Вывод результатов
                }
            }*/
            Console.ReadKey();
        }
        static double SurfCubeCalc(int a)
        {
                double SurfCube = 6*Math.Pow(a, 2); // Вычисление площади S поверхности куба S=6H2;
                Console.WriteLine(" Плащадь поверхности куба= {0:F3} ", SurfCube); //Вывод результатов до сотых
                return SurfCube;
        }
        static double ValCubeCalc(int a)
        {
            double ValCube = Math.Pow(a, 3); // Вычисление объема куба S=H3;
            Console.WriteLine(" Объем куба= {0:F3} ", ValCube); //Вывод результатов до сотых
            return ValCube;
        }
    }
}