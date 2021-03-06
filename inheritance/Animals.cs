using System;

namespace inheritance
{
    public class Animals : Creatures
    {
        protected void Adaptation()
        {
            Console.WriteLine("Animals adapt.");
        }

        public override void ResponseToStimuli()
        {
            base.ResponseToStimuli();
            Console.WriteLine("Animals react to charge");
        }

    }

    public class Reptiles : Animals
    {
        public Reptiles()
        {
            base.Adaptation();
            base.Eating();
            base.Excretion();
            base.Breathing();
        }
        public void Creep()
        {
            Console.WriteLine("Reptiles creep");
        }
    }

    public class Birds : Animals
    {
        public Birds()
        {
            base.Adaptation();
            base.Eating();
            base.Excretion();
            base.Breathing();
            base.ResponseToStimuli();
        }
        public void Fly()
        {
            Console.WriteLine("Birds fly");
        }
    }
}
