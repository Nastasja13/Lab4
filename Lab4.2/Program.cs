using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Ввести целое число N > 0.Найти квадрат данного числа, используя для его вычисления следующую формулу: 
            N2 = 1 + 3 + 5 + ... +(2 * N – 1). 
            После добавления к сумме каждого слагаемого выводить текущее значение суммы
            (в результате будут выведены квадраты всех целых чисел от 1 до N).*/

            int a = 0, b = 1;
            Console.Write("Введите целое число больше 0: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Квадраты чисел: ");
            while (b <= N * 2)
            {
                
                a += b;
                Console.WriteLine(a.ToString());
                b += 2;
            }
            
            Console.WriteLine();
            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
}
