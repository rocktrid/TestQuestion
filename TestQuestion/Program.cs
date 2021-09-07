using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TestQuestion
{
    class Program
    {

        static void Main(string[] args)
        {
            int counter =0; // счетчик для 1000000
            int numbers = 0; // числа, среди которых будут отбираться значения
            long sum = 0; // для отображения суммы числе кратных 13
            do
            {
                if(numbers%13==0)
                {
                    counter++;
                    sum += numbers;
                    Console.WriteLine(sum);
                }
                numbers++;
                //Thread.Sleep(1);
            }
            while (counter < 1000000);
            Console.WriteLine("Операция завершена, итого вая сумма:" + sum);
        }
    }
}
