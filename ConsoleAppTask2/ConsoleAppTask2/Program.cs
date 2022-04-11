using System;
using System.IO;
using System.Collections.Generic;

namespace Task_2
{
    class Program
    {
        static List<double> Read_from_file(string file_path)
        {
            try
            {
                List<double> list = new List<double>();
                using (StreamReader sr = new StreamReader(file_path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(double.Parse(line));
                        list.Add(double.Parse(line));
                    }
                }
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        static async void Write_to_file(string text, string file_path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(file_path, false, System.Text.Encoding.Default))
                {
                    await sw.WriteLineAsync(text);
                }
                Console.WriteLine("Запись выполнена");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        static double List_sum(List<double> list)
        {
            double sum = 0;
            foreach (int value in list)
            {
                sum += value;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            List<double> list = Read_from_file(@"C:\Users\Danil\source\repos\ConsoleAppTask2\in.txt");
            double sum = (List_sum(list));
            Write_to_file(sum.ToString("R"), @"C:\Users\Danil\source\repos\ConsoleAppTask2\out.txt");
        }
    }
}
