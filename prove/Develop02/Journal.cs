using System;
using System.ComponentModel;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        //The add entry function will create an Entry object and store it
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

    public void SaveToFile(string file)
    {
        
    }

    public void LoadFromFile(string file)
    {

    }
}