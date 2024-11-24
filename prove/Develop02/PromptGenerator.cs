public class PromptGenerator
{
    public List<string> _prompts = new List<string>{
        "What was the most challenging moment of my day?",
        "What did I learn today that I didn't know before?",
        "How did I show kindness today?",
        "What is something I am grateful for right now?",
        "How did I take care of myself today?",
        "What did I accomplish today that I’m proud of?",
        "What are some things I could improve upon tomorrow?",
        "What moment today made me feel at peace?",
        "What is something I wish I had done differently today?",
        "What am I looking forward to tomorrow?",
        "Who made me feel supported today?",
        "What was the most beautiful thing I saw today?",
        "What’s one thing I can do to make someone else’s day better tomorrow?",
        "What did I do today that made me feel confident?",
        "How did I grow emotionally, spiritually, or mentally today?",
        "What made me laugh today?",
        "What did I do to step outside my comfort zone today?",
        "What was the most peaceful moment of my day?",
        "What lesson did I learn today that I want to remember?",
        "What did I do today that made me feel connected to others?",
        "What has been a highlight of my week so far?",
        "If I could relive today, what would I do differently?",
        "What’s one thing I want to manifest in my life right now?",
        "What part of my day felt most in alignment with my values?",
        "What personal strength did I use today?",
        "Who or what inspired me today?",
        "What is one thing I am excited to accomplish in the coming days?",
        "How did I practice gratitude today?",
        "What fears did I face today?",
        "How can I make tomorrow even better than today?"
    };

    private List<int> generatedNumber = new List<int>();
    public string GetRandomPrompt()
    {
        Random rng = new Random();
        int index = rng.Next(_prompts.Count());        
        return _prompts[index];
        
        // int index;
        // do
        // {
        //     index = rng.Next(_prompts.Count());        
        //     return _prompts[index];
        //     generatedNumber.Add(index);
        // } while (!generatedNumber.Contains(index));

        
    }
}