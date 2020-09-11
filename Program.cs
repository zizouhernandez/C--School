using System;
using System.Threading;

namespace C__School
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(@"
                    _  _ _  _ ____ ____ _  _ _  _ 
                    |\/| |  | [__  |___ |  | |\/| 
                    |  | |__| ___] |___ |__| |  | 
                              ");
            Console.WriteLine("\nVälkommen till DeeZ Museum\nHär är din broschyr");
            Thread.Sleep(1000);
            Console.WriteLine("...");
            Console.WriteLine("Du öppnar broschyren och ser olika alternativ:\n");

            while (true)
            {
            Console.WriteLine(@"    
            
                    Välj ett rum för att besöka det
                    _______ _______ _______ _______ _
                    |\     /|\     /|\     /|\     /|
                    | +---+ | +---+ | +---+ | +---+ |
                    | |   | | |   | | |   | | |   | |
                    | | 1 | | | 2 | | | 3 | | | 4 | |
                    | +---+ | +---+ | +---+ | +---+ |
                    |/_____\|/_____\|/_____\|/_____\|
    9.EXIT <-----    _______ _______ _______ _______ 
                    |\     /|\     /|\     /|\     /|
                    | +---+ | +---+ | +---+ | +---+ |
                    | |   | | |   | | |   | | |   | |
                    | | 5 | | | 6 | | | 7 | | | 8 | |
                    | +---+ | +---+ | +---+ | +---+ |
                    |/_____\|/_____\|/_____\|/_____\|  
                    
                    ");                                                                                                        
                int input = Convert.ToInt32(Console.ReadLine());
                //tom rad innan användarens val körs
                Console.WriteLine(" ");

                if (input >= 1 && input <= 9)
                {Console.WriteLine($"Du är inne i rum {input} och till din häpnad ser du\n..."); 
                Thread.Sleep(1000);
                }
                switch (input)
                {
                    
                    case 1:
                        Console.WriteLine("Ingenting alls. Rummet är tomt. You just got yeeted");
                        break;
                    case 2:
                        Console.WriteLine("Ingenting alls. Rummet är tomt. You just got yeeted");
                        break;

                    case 3:
                        Console.WriteLine("Mona lisa. WOW!");
                        break;

                    case 4:
                        Console.WriteLine("En riktigt stor hand. Du blev precis örfilad");
                        break;

                    case 5:
                        Console.WriteLine("Ingenting alls. Rummet är tomt. You just got yeeted");
                        break;

                    case 6:
                        Console.WriteLine("Gustav. Vänta va? Vad gör du här?");
                        break;
                    
                    case 7:
                        Console.WriteLine("En banan. Wait, is this art?");
                        break;

                    case 8:
                        Console.WriteLine("Ingenting alls. Rummet är tomt. Did i really pay for this?");
                        break;

                    case 9:
                     return;

                    default:
                        Console.WriteLine("Du skrev något annat än 1-9");
                        break;
                }

                //Tom rad innan nästa körning
                Console.WriteLine("Tryck på valfri knapp för att komma till huvudmenyn igen");

                Console.ReadKey();
                Console.Clear();
                
            }
        }
    }
}
