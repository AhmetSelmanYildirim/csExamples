using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            SeedPlants seedPlant = new SeedPlants();
            seedPlant.PropagationBySeed();

            System.Console.WriteLine();

            Birds bird = new Birds();
            bird.Fly();




        }
    }
}
