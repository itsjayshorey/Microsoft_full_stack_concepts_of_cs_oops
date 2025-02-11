class Program
{
    public interface IInstrument
    {
        void Play();
    }
    public class Guitar : IInstrument
    {
        public void Play()
        {
            Console.WriteLine("Playing Guitar");
        }
    }
    public class Piano : IInstrument
    {
        public void Play()
        {
            Console.WriteLine("Playing Piano");
        }
        public void run()
        {
            Console.WriteLine("running Piano");
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Guitar guitar = new Guitar();
        guitar.Play();
        Piano piano = new Piano();
        piano.Play();
        piano.run();

    }
}
