using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
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
            ICalc2 calc2 = array;
            Console.WriteLine("\nCount Distinct: " + calc2.CountDistinct());
            Console.WriteLine("\nEqual To Value Total: " + calc2.EqualToValue(2));
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
        interface ICalc2
        {
            int CountDistinct();
            int EqualToValue(int value);
        }
        class Array : ICalc, ICalc2, IOutput, IOutput2
        {
            int[] arr;

            public int CountDistinct()
            {
                Console.WriteLine("Count Distinct: ");
                System.Collections.ArrayList unique = new System.Collections.ArrayList();
                int result = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (unique.IndexOf(arr[i]) == -1)
                    {
                        result++;
                        unique.Add(arr[i]);
                    }
                }
                for (int i = 0; i < unique.Count; i++)
                {
                    Console.Write(unique[i] + " ");
                }
                Console.WriteLine("");
                return result;
            }
            public int EqualToValue(int valueToCompare)
            {
                int result = 0;
                foreach (int item in arr)
                {
                    if (item == valueToCompare)
                    {
                        Console.WriteLine($"Element In Array: {item} Equal To {valueToCompare}" + " ");
                        result++;
                    }
                }
                Console.WriteLine("");
                return result;
            }

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
