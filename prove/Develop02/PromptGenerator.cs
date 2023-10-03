using System;
using System.Runtime.InteropServices;



public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
        
    public string GetRandomPrompt()
    {
        //Create a random object and the list of prompts inside a string array
        Random randomPrompt = new Random();
        string[] prompts = 
        {
            "What did you learn today?",
            "What do you like to remember from today?",
            "Why did today was a 'good day'?",
            "What was the best part of your day?",
            "Tell me the funniest moment of your day... ",
        };
        
        // Use the Next method to return a random number inside the prompt list length
        int listIndex = randomPrompt.Next(prompts.Length);
        Console.WriteLine("{0}", prompts[listIndex]);
        return prompts[listIndex];


    }
}