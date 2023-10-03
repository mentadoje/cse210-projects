using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry()
    {
        //The add entry function will create an Entry object and store it in the _entries list
        Entry entry = new Entry();
        entry.Write();
        _entries.Add(entry);

    }

    public void DisplayAll()
    {
        //This function will display all the entries
        foreach(Entry entry in _entries)
        {
            entry.Display();
        }
    } 

    public void SaveToFile(string fileName)
    {
        // This function will print the list of Entries into a file.
        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {

            string printedList = "";
            foreach(Entry entry in _entries)
                {
                    printedList = $"Date: {entry._date}~~Prompt: {entry._promptText}~~Entry: {entry._entryText}";
                    
                    outputFile.WriteLine(printedList);
                }
            

        }
    }

    public void LoadFromFile(string fileName)
    {
 

        List<Entry> userEntry = new List<Entry>();

        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");
            
            Entry entry = new Entry(); 
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            
            _entries.Add(entry);
            userEntry.Add(entry);
        }

    }

        

}