using System.Collections.Generic;

interface Menu
{
    List<string> Options { get; set; }
    string QuitOption { get; set; }
    void SelectOption();
}
