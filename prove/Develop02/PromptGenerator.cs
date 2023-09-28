using System;
using System.Runtime.InteropServices;



public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
        
    public string GetRandomPrompt()
    {
        //Create a random object and the list of prompts
        Random randomPrompt = new Random();
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
        };
        
        // Use the Next method to return a random number inside the prompt list length
        int listIndex = randomPrompt.Next(prompts.Length);
        Console.WriteLine("{0}", prompts[listIndex]);
        return prompts[listIndex];

    }
}