namespace Number_Guesser_V._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                

                Console.WriteLine("Willst du den Numberguesser spielen?");
                if (!Console.ReadLine().StartsWith("J", StringComparison.OrdinalIgnoreCase)) break;


                Console.WriteLine("Ok super! Wähle eine Zahl von 1 bis 100");

                

                int Counter = 0;
                Random rnd = new Random();
                int RandomZahl = rnd.Next(1, 101);

                int x = 1;


                while (x == 1)
                {
                    int Guesszahl = Convert.ToInt32(Console.ReadLine());

                
                    if (Guesszahl < RandomZahl)
                    {

                        Console.WriteLine("Wähle eine grössere Zahl.");
                        Counter = Counter + 1;

                    }

                    else if (Guesszahl > RandomZahl)
                    {

                        Console.WriteLine("Wähle eine kleinere Zahl.");
                        Counter = Counter + 1;

                    }


                    else if (Guesszahl == RandomZahl)
                    {

                        
                        Counter = Counter + 1;
                        x = 0;

                    }

                    if (Guesszahl > 100)
                    {
                        Console.WriteLine("Sie muss unter Hundert sein!");
                        Counter = Counter + 2;
                    }


                }


                Console.WriteLine("Gut gemacht! Deine Anzahl Versuche: " + Counter);

            }
        }

    }
}