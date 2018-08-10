using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program

    {
        static string inputA, inputB, inputC;
        static double a, b, c;

        static void Main(string[] args)



        {
            double x1, x2;



            Console.WriteLine("Podaj parametr A");
            inputA = Console.ReadLine();
            a = Convert.ToInt32(inputA);
            if (a == 0)
            {

                Console.WriteLine("równianie nie jest kwadratowe");
                
            }
            else
            {
                Console.WriteLine("Podaj parametr B");
                inputB = Console.ReadLine();
                Console.WriteLine("Podaj parametr C");
                inputC = Console.ReadLine();

                
                b = Convert.ToInt32(inputB);
                c = Convert.ToInt32(inputC);

                double delta = b * b - 4 * a * c;
                Console.WriteLine(delta);
                Console.ReadLine();
                

                if (delta > 0)
                {
                    Console.WriteLine("Pierwiastek delty jest równy{0}", Math.Sqrt(delta));
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("to jest samo x1" + x1);
                    Console.WriteLine("Delta posiada dwa rozwiązania\n{0} \n{1}", x1, x2);

                }
                else if (delta == 0)
                {
                    Console.WriteLine("Pierwiastek delty jest równy{0}", Math.Sqrt(delta));
                    x1 = (-b / (2 * a));
                }
                else
                {
                    Console.WriteLine("brak rozwiązań w zbiorze liczb rzeczywistych");
                }














                }
            Console.ReadLine();
        }
    }
}
