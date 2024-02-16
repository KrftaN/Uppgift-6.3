namespace Uppgift_6._1
{
    class Program
    {
        static int Addera(int tal1, int tal2, int tal3)
        {
            return tal1 + tal2 + tal3;
        }
        static int Störst(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                return tal1;
            }
            else
            {
                return tal2;
            }
        }

        static void MenyvalAddera()
        {
            Console.WriteLine("Skriv tre tal separerade med kommatecken [1, 2, 3]");
            int[] numbers = Console.ReadLine().Split(',').Select(x => int.Parse(x.Trim())).ToArray();

            int sum = Addera(numbers[0], numbers[1], numbers[2]);
            Console.WriteLine($"Summan av talen {numbers[0]}, {numbers[1]}, {numbers[2]} är: {sum}");
            Console.WriteLine();
        }

        static void MenyvalStörst()
        {
            Console.WriteLine("Skriv två tal separerad med ett kommatecken");
            int[] numbers = Console.ReadLine().Split(',').Select(x => int.Parse(x.Trim())).ToArray();
            int störst = Störst(numbers[0], numbers[1]);
            Console.WriteLine($"{störst} är störst");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string input = "";

            while (input != "3")
            {
                Console.WriteLine("1. Addera tre tal");
                Console.WriteLine("2. Störst talet av två tal");
                Console.WriteLine("3. Avsluta programmet");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        MenyvalAddera();
                        break;
                    case "2":
                        MenyvalStörst();
                        break;
                    case "3":
                        Console.WriteLine("Hejdå :)");
                        break;

                }
            }
        }
    }
}