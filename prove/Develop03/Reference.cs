using System;

class Reference
{
    private string book;
    private int chapter;
    private string endVerse;

    public Reference(string book, int chapter)
    {
        this.book = book;
        this.chapter = chapter;
        this.endVerse = null; // Single verse
    }

    public Reference(string book, int chapter, string endVerse)
    {
        this.book = book;
        this.chapter = chapter;
        this.endVerse = endVerse; // Verse range
    }

    public string GetReferenceDisplay()
    {
        if (endVerse == null)
            return $"{book} {chapter}";
        else
            return $"{book} {chapter}:{endVerse}";
    }
}
