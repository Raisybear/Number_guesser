# Lernbericht
Elias

## Einleitung

Einen Ratesimulator einer generierten Zufallszahl.

## Was habe ich gelernt?

Wie man bestimmt ob die Runde vorbei ist, oder die Zahl noch nicht geraten wurde.

## Beschreibung
```C#
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
                    
                    
```                   
![2022-09-13](https://user-images.githubusercontent.com/110892658/189839376-084ae68d-7495-4cd0-8c78-7438f136fe99.png)

## Verifikation

Man sieht im einten Video den gezogenen Schwung und eine kleine Beschreibung. 



# Reflektion zum Arbeitsprozess

Mir viel das Arbeiten teilweise sehr schwer, ich wusste oft nicht was man machen musste, weil ich zu schlecht zugehört habe und nicht konzentriert gearbeitet habe.


