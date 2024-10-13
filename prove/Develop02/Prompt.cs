
//Prompt Generator
using System;
using System.Collections.Generic;

public class Prompt
{
    //attributes list
    private List<string> prompts;

    //constructor
    public Prompt()
    {
        prompts = new List<string>
        {
            "There is never a dull day for you, what made your day interesting?",
            "You live a pretty cool life, did you do anything you think was cool today?",
            "There is always something new to learn, what did you learn today?",
            "Life is full of problems to solve, how did you solve your problems today?",
            "We all have something to be grateful for, what are you grateful for today?",
            "We always seem to have a pretty busy day, how busy were you?",
            "There is always something interesting in the world going on, is there any news you learned you thought was interesting?",
            "It is important to be kind to others, What act of kindness did you do today?",
            "There is nothing wrong in treating yourself once in a while, how did you treat yourself today?",
            "It cannot be all work and no play every day, what did you do for fun today?"
        };
    }

    //behaviors
    public string GetPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}
