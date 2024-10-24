using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string scriptureText)
    {
        this.reference = reference;
        words = new List<Word>();

        // Split the scripture text into words and create Word objects
        foreach (string word in scriptureText.Split(' '))
        {
            words.Add(new Word(word));
        }
    }

    public void DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine(reference.GetReferenceDisplay());
        Console.WriteLine();

        // Display the scripture text with hidden words
        foreach (Word word in words)
        {
            Console.Write(word.GetWordDisplay() + " ");
        }

        Console.WriteLine();
    }

    public bool HideRandomWords()
    {
        Random random = new Random();
        int wordsToHide = random.Next(1, 4); // Hide 1-3 random words

        // Filter words that are not already hidden
        var visibleWords = words.Where(w => !w.IsHidden).ToList();

        if (visibleWords.Count == 0)
            return false; // No words left to hide, scripture is fully hidden

        for (int i = 0; i < wordsToHide && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].HideWord();
            visibleWords.RemoveAt(index); // Ensure we don't re-hide the same word
        }

        return true; // Continue hiding words
    }
}
