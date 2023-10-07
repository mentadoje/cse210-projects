using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //For God so loved the world, that he 
        //gave his only begotten Son, that whosoever 
        //believeth in him should not perish, but have 
        //everlasting life.
        Reference reference = new Reference("Jhon", 3, 16);
        
        string scriptureText = ("For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life");

        Scripture scriptureReference = new Scripture(reference, scriptureText);
        Console.WriteLine(scriptureReference);
        Console.WriteLine("Press enter to continue or type 'quit' to finish");
        string _userInput = Console.ReadLine();

        while (_userInput != "quit")
        {
            
        }    
        
        
    }
}