using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThread
{
    class Program
    {
        static string Result = "";
        static string path = "";
        static void Main(string[] args)
        {
            Console.Write("Введите путь до файлов: ");
            path = Console.ReadLine();

            Thread thread1 = new Thread(ReadFile_1);
            Thread thread2 = new Thread(ReadFile_2);
            Thread thread3 = new Thread(ReadFile_3);
            
            thread1.Start();
            thread2.Start();
            thread3.Start();
            using (Stream myStream = File.Open(path + "\\out.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                StreamWriter writer = new StreamWriter(myStream);
                writer.Write(Result);
            }
            Console.ReadLine();
        }

        private static void ReadFile_1()
        {
            ReadFile(1);         
        }
        private static void ReadFile_2()
        {
            ReadFile(2);
        }
        private static void ReadFile_3()
        {
            ReadFile(3);
        }


        static void ReadFile(int i)
        {            
            using (StreamReader reader = new StreamReader(path + $"\\in_{i}.dat"))
            {
                string[] numbers = new string[2];
                string command = reader.ReadLine();
                numbers = reader.ReadLine().Split(' ');
                try
                {
                    switch (command)
                    {
                        case "1":
                            double first = Convert.ToDouble(numbers[0]);
                            double second = Convert.ToDouble(numbers[1]);
                            Console.WriteLine(first + second);
                            Result += $"{first + second}\n";
                            break;
                        case "2":
                            first = Convert.ToDouble(numbers[0]);
                            second = Convert.ToDouble(numbers[1]);
                            Console.WriteLine(first * second);
                            Result += $"{first * second}\n";
                            break;
                        case "3":
                            first = Convert.ToDouble(numbers[0]);
                            second = Convert.ToDouble(numbers[1]);
                            Console.WriteLine(Math.Pow(first, 2) + Math.Pow(second, 2));
                            Result += $"{Math.Pow(first, 2) + Math.Pow(second, 2)}\n";
                            break;
                        default:
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("В файле находятся не числа!");
                }                
            }
        }
    }
}
