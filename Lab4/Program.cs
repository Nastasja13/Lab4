using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число больше 0: ");
            int N = Convert.ToInt32(Console.ReadLine());
            double N2 = Math.Pow (N, 2); //квадрат числа
            int number = 2;
            int Sum = (2 * N - 1);
            int Formula = N;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Квадрат {0} равен {1}", i , i * i);
            }
            do
            {
                Formula += 1 + 3 + 5 + number + Sum;  
            } while (Formula < N2);
            Console.WriteLine("Квадрат {0} равен {1}", N, N2);
            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
}
