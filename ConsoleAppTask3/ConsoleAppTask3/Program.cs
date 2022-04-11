using System;


namespace ConsoleAppTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Hour h = new Hour(12);
            Minute m = new Minute(54);
            Day d = new Day(h, m);
            Console.WriteLine(d.getCurrentTime());
            Console.WriteLine(d.getDayParth());
        }
    }
}
