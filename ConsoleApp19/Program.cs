using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp19.Program;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array();
            IOutput output = array;
            output.Show();
            ICalc Calc = array;
            Console.WriteLine("\nElements Less: " + Calc.Less(4));
            Console.WriteLine("\nElements Greater: " + Calc.Greater(6));
        }

        interface IOutput
        {
            void Show();
            void Show(string info);
        }
        interface ICalc
        {
            int Less(int valueToCompare);
            int Greater(int valueToCompare);
        }

        class Array : ICalc, IOutput
        {
            int[] arr;

            public Array()
            {
                arr = new int[9];
                Random random = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = random.Next(0, 10);
                }
            }
            public void Show()
            {
                foreach (int item in arr)
                {
                    Console.Write($"{item}" + " ");
                }
            }
            public void Show(string info)
            {
                foreach (int item in arr)
                {
                    Console.Write($"{info} {item}" + " ");
                }
            }
            public int Less(int value)
            {
                int result = 0;
                Console.Write($"\nArray Less than {value}: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (value > arr[i])
                    {
                        result++;
                        Console.Write($"{result}: {arr[i]}" + " ");
                    }
                }
                return result;
            }
            public int Greater(int value)
            {
                int result = 0;
                Console.Write($"Array Greater than {value}: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (value < arr[i])
                    {
                        result++;
                        Console.Write($"{result}: {arr[i]}" + " ");
                    }
                }
                return result;
            }
        }
    }
}
