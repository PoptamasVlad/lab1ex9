using System;

namespace lab1ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scrieti un program care interschimba valoarea a doua variabile intregi.*/

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int x;

            x = num1;
            num1 = num2;
            num2 = x;

            Console.WriteLine(num1 + " " + num2);

        }
    }
}
