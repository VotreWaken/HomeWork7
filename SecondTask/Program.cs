using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array();
            IOutput output = array;
            IOutput2 output2 = array;
            output.Show();
            ICalc Calc = array;
            Console.WriteLine("\nElements Less: " + Calc.Less(4));
            Console.WriteLine("\nElements Greater: " + Calc.Greater(6));
            output2.ShowEven();
            output2.ShowOdd();
        }

        interface IOutput
        {
            void Show();
            void Show(string info);
        }
        interface IOutput2
        {
            void ShowEven();
            void ShowOdd();
        }
        interface ICalc
        {
            int Less(int valueToCompare);
            int Greater(int valueToCompare);
        }

        class Array : ICalc, IOutput, IOutput2
        {
            int[] arr;

            public void ShowEven()
            {
                Console.WriteLine("\nEven: ");
                foreach (int item in arr)
                {
                    if (item % 2 == 0)
                    {

                        Console.Write($"{item}" + " ");
                    }
                }
                Console.WriteLine("");
            }
            public void ShowOdd()
            {
                Console.WriteLine("\nOdd: ");
                foreach (int item in arr)
                {
                    if (item % 2 != 0)
                    {
                        Console.Write($"{item}" + " ");
                    }
                }
                Console.WriteLine("");
            }
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

