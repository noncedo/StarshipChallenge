using System;
using System.IO;

namespace StarshipChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate test = new Coordinate("123.456.78.9");

            Random random = new Random();

            Coordinate X = new Coordinate(random);
            Coordinate Y = new Coordinate(random);
            Coordinate Z = new Coordinate(random);
            string path = "";

            // Write file using StreamWriter  
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(X);
                writer.WriteLine(Y);
                writer.WriteLine(Z);
            }

            // Read a file  
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
        struct Coordinate
        {
            uint val;
            public Coordinate(string text)
            {
                System.Text.RegularExpressions.Match m = System.Text.RegularExpressions.Regex.Match(text, @"^([0-9]{3})\.([0-9]{3})\.([0-9]{2})\.([0-9])$");
                if (!m.Success) throw new FormatException("The coordinate is not in the format 000.000.00.0");
                val = uint.Parse(m.Groups[1].Value + m.Groups[2].Value + m.Groups[3].Value + m.Groups[4].Value);

            }
            public Coordinate(Random random)
            {
                val = (uint)random.Next(1000000000);
            }
        }

    }
}
