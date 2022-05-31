using PooProject.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Knight knight = new Knight("Arus", 42, "Knight", 469, 749, 72, 72);
        Ninja ninja = new Ninja("Wedge", 42, "Ninja", 292, 574, 89, 89);
        WhiteWizard whiteWizard = new WhiteWizard("Jenica", 42, "White Wizard", 325, 601, 474, 482);
        BlackWizard blackWizard = new BlackWizard("Topapa", 42, "Black Wizard", 106, 385, 611, 641);


        Console.WriteLine("\n********Welcome to Dungeon DIO********");
        Console.WriteLine();
        Console.WriteLine("Select your Hero:");
        Console.WriteLine("\n1 - Knight\n2 - Ninja\n3 - White Wizard\n4 - Black Wizard\n5 - exit\n");

        int userInput = 0;

        while (!int.TryParse(Console.ReadLine(), out userInput))
        {
            Console.WriteLine("\nPlease enter a numerical value\n");
        }

        switch (userInput)
        {
            case 1:
                Console.WriteLine(knight.ToString());
                Console.WriteLine(knight.Attack());
                break;

            case 2:
                Console.WriteLine(ninja.ToString());
                Console.WriteLine(ninja.Attack());
                break;
            
            case 3:
                Console.WriteLine(whiteWizard.ToString());
                Console.WriteLine(whiteWizard.Attack());
                break;
            
            case 4:
                Console.WriteLine(blackWizard.ToString());
                Console.WriteLine(blackWizard.Attack());
                break;
            
            case 5:
                Console.WriteLine("See you next time");
                break;

            default:
                System.Console.WriteLine("\nPlease enter a valid option");
                break;
        
        }
               
    }
}