using System;

namespace inheritance
{
    public class Creatures
    {
        protected void Eating()
        {
            Console.WriteLine("Creatures eat.");
        }

        protected void Breathing()
        {
            Console.WriteLine("Creatures breath.");
        }

        protected void Excretion()
        {
            Console.WriteLine("Creatures excret.");
        }

        public virtual void ResponseToStimuli()
        {
            Console.WriteLine("Creatures react to stimuli");
        }

    }
}
