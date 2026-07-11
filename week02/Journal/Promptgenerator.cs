using System.Collections.Generic;

public class PromptGenerator
{
    // create list of prompts
    public List<string> _prompts = new List<string> {
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something new you learned or realized today?",
        "What is something you are grateful for today?",
        "How much time do you spend outside today?",
        "What excites you about this week?",
        "What happened today that made you hopeful for the future?"};




    public string GetRandomPrompt()
    {
        int randomIndex = Random.Shared.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];

        return randomPrompt;
    }
}