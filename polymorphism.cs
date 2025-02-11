class Program
{
    public class Instrument
    {
        public void Play()
        {
            Console.WriteLine("Playing Instrument");
        }
    }
    public class Guitar : Instrument
    {
        public void Play()
        {
            Console.WriteLine("Playing Guitar");
        }
    }
    public class Piano : Instrument
    {
        public void Play()
        {
            Console.WriteLine("Playing Piano");
        }
    }
    // examples of polymorphism
    public static void Main()
    {
        Instrument instrument = new Instrument();
        instrument.Play();
        Guitar guitar = new Guitar();
        guitar.Play();
        Piano piano = new Piano();
        piano.Play();
    }
}
