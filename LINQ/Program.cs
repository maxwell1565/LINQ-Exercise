namespace LINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Program
    {
        static void Main(string[] args)
        {
           List<string> gameNames = new List<string>
            {"Madden", "GTA", "NHL", "Minecraft" };

            var shortToLong = gameNames.OrderByDescending(word => word.Length);

            Console.WriteLine("Words ordered from shortest to longest:");
            foreach (var word in shortToLong)
            {
                Console.WriteLine(word);
            }
        }
    }
}