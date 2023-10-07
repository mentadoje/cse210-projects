using System;
using System.Diagnostics.Contracts;

public class Scripture
{
    public List<Word> _words = new List<Word>();
    Reference _reference;
    
    Random randomWord = new Random();

    

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
 

        string[] words = text.Split(' ');
        foreach (string word in words)
        {
       
        }
        Console.WriteLine(words);
        // Add the word to the list of hidden words
        
    }

    public void HideRandomWords(int numberToHide)
    {

        
        
        
        var wordsToHide = _words.OrderBy(_ => randomWord.Next()).Take(numberToHide);

        // Replace the selected Word objects with "_____"
        foreach (Word word in wordsToHide)
        {
            int index = _words.IndexOf(word);
            _words[index] = new Word("_____");
        }
    }

    public string GetDisplayText()
    {
        string  scriptureReferenceToDisplay = $"{_reference} - ";
        
        return scriptureReferenceToDisplay ;
    }

    public bool IsCompletelyHidden()
    {
        
        return true ;
    }

}