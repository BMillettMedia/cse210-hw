using System;

class Word
{
    private string wordText;
    private bool isHidden;

    public Word(string wordText)
    {
        this.wordText = wordText;
        isHidden = false;
    }

    public bool IsHidden
    {
        get { return isHidden; }
    }

    public void HideWord()
    {
        isHidden = true;
    }

    public void ShowWord()
    {
        isHidden = false;
    }

    public string GetWordDisplay()
    {
        return isHidden ? "___" : wordText;
    }
}
