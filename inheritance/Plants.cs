using System;

namespace inheritance
{
    public class Plants : Creatures
    {
        protected void Photosynthesis()
        {
            Console.WriteLine("Plants Photosynthesis.");
        }
    }

    public class SeedPlants : Plants
    {
        public SeedPlants()
        {
            base.Photosynthesis();
            base.Eating();
            base.Excretion();
            base.Breathing();
        }
        public void PropagationBySeed()
        {
            Console.WriteLine("Seed Plants propogate by seed");
        }
    }

    public class SeedlessPlants : Plants
    {
        public SeedlessPlants()
        {
            base.Photosynthesis();
                        base.Eating();
            base.Excretion();
            base.Breathing();
        }
        public void PropagationBySpor()
        {
            Console.WriteLine("Seed Plants propogate by spor");
        }
    }
}
