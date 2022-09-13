# Lernbericht
Elias

## Einleitung

Einen Ratesimulator einer generierten Zufallszahl.

## Was habe ich gelernt?

Wie man bestimmt ob die Runde vorbei ist, oder die Zahl noch nicht geraten wurde.

## Beschreibung

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
![2022-09-13](https://user-images.githubusercontent.com/110892658/189839376-084ae68d-7495-4cd0-8c78-7438f136fe99.png)

## Verifikation

Man sieht im einten Video den gezogenen Schwung und eine kleine Beschreibung. 



# Reflektion zum Arbeitsprozess

Mir viel das Arbeiten teilweise sehr schwer, ich wusste oft nicht was man machen musste, weil ich zu schlecht zugehört habe und nicht konzentriert gearbeitet habe.


