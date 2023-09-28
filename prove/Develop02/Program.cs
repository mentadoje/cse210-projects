using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        

        while (true)  
        
        {
            Console.WriteLine("Please select one of the following options");
            Console.WriteLine("1.- Write");
            Console.WriteLine("2.- Display");
            Console.WriteLine("3.- Load");
            Console.WriteLine("4.- Save");
            Console.WriteLine("5.- Quit");
            Console.WriteLine("What would you like to do?");

            int selectedOption = Convert.ToInt32(Console.ReadLine());

            switch(selectedOption)
            {
                    case 1:
                        journal.AddEntry();
                        break;
                    case 2:
                        journal.DisplayAll();
                        break;
                    case 3:
                        Console.WriteLine("Write the name of the file: ");
                        journal.LoadFromFile(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Write the name of the file: ");
                        journal.SaveToFile(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("Program finished");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please, select a valid option");
                        break;

            } 
        }

    }
}