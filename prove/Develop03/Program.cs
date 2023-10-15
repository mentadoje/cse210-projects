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
        string scriptureText = ("For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life");
        string scriptureText2 = ("10. And he said unto the children of men: Follow thou me. Wherefore, my beloved brethren, can we follow Jesus save we shall be willing to keep the commandments of the Father? \n 11 And the Father said: Repent ye, repent ye, and be baptized in the name of my Beloved Son.");
        Reference reference = new Reference("Jhon", 3, 16);
        Scripture scriptureReference = new Scripture(reference, scriptureText);
        
        Console.Clear();
        Console.WriteLine(reference.GetDisplayText());
        Console.WriteLine(scriptureReference.GetDisplayText());

        while (!scriptureReference.IsCompletelyHidden())
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            string userInput = Console.ReadLine();

            if (userInput.Equals("quit"))
            {
                break;
            }
            
            scriptureReference.HideRandomWords(3);
            Console.Clear();

            Console.WriteLine(scriptureReference.GetDisplayText());


        }    
        
        
    }
}