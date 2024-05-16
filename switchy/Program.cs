namespace switchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kas tahate sisestada midagi? Kirjutage jah kui huvitatud.");
            string e = Console.ReadLine();
            if (e == "jah")
            {
                Console.WriteLine("Valige 0-2");
                switchy();
            }
            else
            {
                Console.WriteLine("NUHUH");
            }
        }
         public static void switchy()
        {
            int a = Convert.ToInt16(Console.ReadLine());
            switch (a)
            {
                case 0:
                    Console.WriteLine("Valisite 0");
                    break;
                case 1:
                    Console.WriteLine("Valisite 1");
                    break;
                case 2:
                    Console.WriteLine("Valisite 2");
                    break;
            }
        }
    }
}
