using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("eded1");
            string eded1 = Console.ReadLine();

            Console.WriteLine("eded2");
            string eded2 = Console.ReadLine();


            var num1 = Convert.ToInt32(eded1);
            var num2 = Convert.ToInt32(eded2);


            int samAll = num(num1, num2);
            Console.WriteLine(samAll);



            Console.WriteLine("kvadrat ucun ededi daxil et");
            string eded3 = Console.ReadLine();
            var num3 = Convert.ToInt32(eded3);
            int cub = kol(num3);
            Console.WriteLine(cub);


            var cos = Num();
            Console.WriteLine(cos);
        }
        static int num(int x, int y)
        {

            return x + y;
        }

        static int kol(int a)
        {

            a = a * a;
            return a;
        }

         static int number()
        {

            string Number=Console.ReadLine();
            return Convert.ToInt32(Number);

        }
        static int Num()
        {
            Console.WriteLine("number 1");
             var Num1 = number();
            Console.WriteLine("number 2");
            var Num2 = number();
            Console.WriteLine("number 3");
            var Num3 = number();
            Console.WriteLine("number 4");
            var Num4 = number();
            return Num1 + Num2 + Num3 + Num4 / 2;
            


        }

    }
}
