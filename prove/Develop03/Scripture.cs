using System;
using System.Diagnostics.Contracts;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    private int _hiddenWords;
    
    Random randomWord = new Random();

    

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        ListOfWords(text);
        
    }

    public void HideRandomWords(int numberToHide)
    {
        if (_hiddenWords >= _words.Count)
        {
            return;
        }

        for (int i = 0; i < numberToHide; i++)
        {
            if (_hiddenWords >= _words.Count)
            {
                return;
            }

            int randomIndex;
            do
            {
                randomIndex = randomWord.Next(0, _words.Count);
            } 
            
            while (_words[randomIndex].IsHidden());

            _words[randomIndex].Hide();
            _hiddenWords++;
        }
    }


    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", _words.Select(word => word.IsHidden() ? "____" : word._text));
        return $"{_reference}\n{scriptureText}";
    }

    private void ListOfWords(string text)
    {
        _words = text.Split(" ").Select(word => new Word(word)).ToList();
    }


    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());

    }

}