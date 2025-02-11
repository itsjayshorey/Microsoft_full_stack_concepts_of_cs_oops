using System;

namespace Program
{
    public class Pool
    {
        public int chlorinelevel;
        public int waterlevel;
        public Pool(int chlorine, int water)
        {
            chlorinelevel = chlorine;
            waterlevel = water;
        }
        public void PoolInfo()
        {
            Console.WriteLine("Chlorine Level: " + chlorinelevel);
            Console.WriteLine("Water Level: " + waterlevel);
        }
    }
    //inherited class
    public class Spa : Pool
    {
        public int heatlevel;
        public Spa(int chlorine, int water, int heat) : base(chlorine, water)
        {
            heatlevel = heat;
        }
        public void SpaInfo()
        {
            Console.WriteLine("Chlorine Level: " + chlorinelevel);
            Console.WriteLine("Water Level: " + waterlevel);
            Console.WriteLine("Heat Level: " + heatlevel);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Pool pool = new Pool(5, 10);
            pool.PoolInfo();
            Spa spa = new Spa(3, 5, 8);
            spa.SpaInfo();
            Console.WriteLine("using pool info in spa");  
            spa.PoolInfo();
        }
    }
}
