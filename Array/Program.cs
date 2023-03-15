using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = new string[]{ "Volvo", "BMW", "Ford", "Mazda" };
            string firstName = "AHmad", lastName = "Arif", NPM = "40621190002";
            string fullname = $"MR. {firstName} {lastName}, \nNPM : {NPM}";
            Console.WriteLine(fullname);
            //cars[0] = "Opel";
            Console.WriteLine(@"Using FOR LOOPING\\ : ");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.Write(cars[i]+",");
            }
            Console.WriteLine("\nUsing FOR EACH \\\\: ");
            foreach (string i in cars)
            {
                Console.Write(i + ",");
            }
            int[,] array =
            {
                {1,2},
                {3,4},
                {5,6}
            };
            Console.WriteLine("\n Array Multiedimensi : "+array[0,0]);
        }
    }
    class Array
    {
        
    }
}
