using System;
using System.IO;

namespace StarshipChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Location location = new Location();
        
            //Generate Coordinates
            Random random = new Random();
            int x= random.Next(0, 100000000);
            int y = random.Next(0, 100000000);
            int z = random.Next(0, 100000000);

            //TODO:Change coordinate format to 123.456.78.9
            System.Text.RegularExpressions.Match m = System.Text.RegularExpressions.Regex.Match(x.ToString(), @"^([0-9]{3})\.([0-9]{3})\.([0-9]{2})\.([0-9])$");
            
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            location.xCoordinate = x;
            location.yCoordinate = y;
            location.zCoordinate = z;
            
            var surface = location.CalculateSurfaceArea(location.xCoordinate, location.yCoordinate, location.zCoordinate);
            Console.WriteLine(surface);
            Console.ReadLine();

        }
        

    }
}
