using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int katet = 0;

            Console.Write("Введите длину катета равнобедренного треугольника: ");
            try
            {
                katet = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Вы ввели не целое число! Нажмите Enter, чтобы начать заново.");
            }

            //First triangle

            for (int i = 0; i < katet; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            //Second triangle

            for (int i = katet; i >= 0; i--)
            { 
                for (int j = 0; j < i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            //Third triangle

            int m = katet;

            for (int i = 0; i < katet; i++)
            {
                m--;
                for (int j = 0; j < m; j++)
                {
                    Console.Write(" ");
                    
                }
                for (int p = 0; p < (katet - m); p++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < katet; i++)
            {
                
                for (int j = 0; j < m; j++)
                {
                    Console.Write(" ");

                }
                for (int p = 0; p < (katet - m); p++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                m++;
            }

            Console.ReadLine();
        }
    }
}
