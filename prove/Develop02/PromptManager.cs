using System;
using System.Collections.Generic;

class PromptManager {

    List<string> _journalEntries = new List<string>
    {
        "What is one new thing you learned today?",
        "Describe a recent challenge you overcame and how you did it.",
        "What are three things you're grateful for today?",
        "What are your short-term goals for the week?",
        "Reflect on a time when you felt truly proud of yourself.",
        "How did you make someone else's day better recently?",
        "What are some things you could improve upon?",
        "Who is someone you admire and why?",
        "Write about a favorite memory from your childhood.",
        "How do you usually handle stress, and is there a better way?",
        "What was the last book or article you read, and what did you learn from it?",
        "Describe a person who has had a positive impact on your life.",
        "What is something you would like to try that you haven’t done before?",
        "What are some qualities you admire in others?",
        "Write about a time when you felt misunderstood and how you handled it.",
        "What are your long-term goals for the next year?",
        "Reflect on how you've grown over the past year.",
        "What are your core values, and why are they important to you?",
        "Describe a moment that made you smile recently.",
        "If you could change one thing about your daily routine, what would it be and why?"
    };

    public string GetRandomJournalEntry() {
        Random random = new Random();
        int index = random.Next(_journalEntries.Count);
        return _journalEntries[index];
    }
}