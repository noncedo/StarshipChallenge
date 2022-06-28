using System;
using System.IO;
using System.Threading.Tasks;

namespace StarshipChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Location location = new Location();
            bool isHabitable = false;

            //limited random to 5 instead of 15000 due to perfomance issue
            for (int i = 0; i <= 5; i++)
            {
                //Generate Coordinates
                Random random = new Random();
                location.xCoordinate = random.Next(0, 100000000);
                location.yCoordinate = random.Next(0, 100000000);
                location.zCoordinate = random.Next(0, 100000000);

                //TODO:Change coordinate format to 123.456.78.9
                //System.Text.RegularExpressions.Match m = System.Text.RegularExpressions.Regex.Match(x.ToString(), @"^([0-9]{3})\.([0-9]{3})\.([0-9]{2})\.([0-9])$");

                Habitability hab;
                var surfaceArea = location.CalculateSurfaceArea(location.xCoordinate, location.yCoordinate, location.zCoordinate);

                //If surface Area is between 1 Million and 100 Million Mark location as habitable
                //Else if surface area is less than 1 Million or less than 0 mark location as inhabitable
                if (surfaceArea >= 1000000 || surfaceArea <= 100000000)
                {
                    isHabitable = true;
                    //hab = new IsHabitable();
                }
                else if(surfaceArea <= 0 || surfaceArea < 1000000)
                {
                    isHabitable = false;
                    hab = new NotHabitable();
                }
                WriteToFile(location.xCoordinate, location.yCoordinate, location.zCoordinate, isHabitable,surfaceArea);

               // ReadFromFile();
            }
           
        }
        
        static void WriteToFile(int x, int y, int z, bool isHabitable,int surfaceArea)
        {
            StreamWriter file = new StreamWriter("Planets.txt",true);
            //"x:{0},y:{1},z:{2},Area:{3},isHabitable:{4}",
            file.WriteLine("{0},{1},{2},{3},{4}",x,y,z,surfaceArea,isHabitable);
            file.Close();
        }

        static void ReadFromFile()
        {
            using StreamReader reader = new StreamReader("Planets.txt");

            string[] field;
            string line = "";
             IsHabitable isHab = new IsHabitable();

            while ((line = reader.ReadLine())!= null)
            {
                field = line.Split(',');
                isHab.Colonization(double.Parse(field[3]));
            }
            
        }

    }
}
