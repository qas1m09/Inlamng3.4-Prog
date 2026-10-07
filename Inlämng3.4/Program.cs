using System;

namespace Inlämng3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur lång är din låt? Skriv 260 om låten är 2 min & 60 sekunder!");
            int låt = int.Parse(Console.ReadLine());

            if (låt > 420)
                Console.WriteLine("Din låt är för lång, den får inte vara med på radion");
            else if (låt < 245)
                Console.WriteLine("Din låt är för kort, den får inte vara med på radion");
            else
                Console.WriteLine("Din låt är perfekt, den får vara med på radion");

        }
    }
}