namespace kontrolltöö
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string ch = Console.ReadLine();

            switch (ch)
            {
                case "1":
                    Pyramid();
                    break;
                case "2":
                    Filemaker();
                    break;
                case "3":

                default:
                    Console.WriteLine("sellist numbrit ple qwq");
                    break;
            }

            
        }
        static void Pyramid()
        {
            
            int i, j, rows;
            int t = 1;
            Console.WriteLine("siin on numbri püramiid");

            Console.WriteLine("Sisesta 4");

            rows = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= rows; i++)
            {
                for (j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 1 * i - 1; j++)
                {
                    Console.Write("{0} ", t++);

                }
                Console.Write("\n");
            }
        }
        static void Filemaker()
        {
            string p = "yes";
            string s = "no";
            string ps = Console.ReadLine();

            try
            {
                if (ps == p)
                {
                    Console.WriteLine("Kirjuta faili läbi konsooli");

                    string filePath = @"C:/Users/Opilane/Destop/woolo3.txt";
                    string inputText = Console.ReadLine();

                    File.WriteAllText(filePath, inputText);
                }
                else 
                {
                    Console.WriteLine("valisid ei");

                }
            }

            catch (Exception e) 
            {
                Console.WriteLine("error error");
                Console.WriteLine(e.Message);

            }
        }
    }
}
