using System;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    PromptGenerator generator = new PromptGenerator();

    public Entry(){}
    public Entry(string date, string prompt, string entry)
    { 
        _date = date;
        _promptText = prompt;
        _entryText = entry;
    }

    public void Display()
    {
        // The display function will show the date, the prompt and the entry of the user
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText} \n Entry: {_entryText}");

    }

    public void Write()
    {
        // The write function will use the prompt generator class and the datetime function to display the entry
        // and write it in the txt file
        _promptText = generator.GetRandomPrompt();
        _entryText = Console.ReadLine();
        _date = DateTime.Now.ToString();
    }
}