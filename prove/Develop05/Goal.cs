using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;

public abstract class Goal
{
    protected string _findGoalName = "What is the name of your goal? ";
    protected string _findGoalDescription = "What is a short description of it? ";
    protected string _findGoalPoints = "How many points is this goal worth? ";
    private static int earnedPoints = 0;
    private static List<Goal> goals = new List<Goal>();

    public static int GetEarnedPoints()
    {
        return earnedPoints;
    }

    public static void AddEarnedPoints(int points)
    {
        earnedPoints += points;
    }

    public static void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public static void ListGoals()
    {
        Console.WriteLine("The goals are: ");
        int i = 1;
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"{i}. {goal.FormatForList()}");
            i++;
        }
    }

    public static void SaveGoals(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(earnedPoints);
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.FormatForFile());
            }
        }
    }

    public static void LoadGoals(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        earnedPoints = int.Parse(lines[0]);

        foreach (string line in lines[1..])
        {
            string[] parts = line.Split(";");
            string goalType = parts[0].Split(":")[0];
            
            Goal newGoal;

            if (goalType == "SimpleGoal")
            {
                newGoal = new SimpleGoal();
            }
            else if (goalType == "EternalGoal")
            {
                newGoal = new EternalGoal();
            }
            else if (goalType == "ChecklistGoal")
            {
                newGoal = new ChecklistGoal();
            }
            else
            {
                break;
            }

            newGoal.TakeFromFile(parts);
            goals.Add(newGoal);
        }
    }

    public static void recordGoals()
    {
        Console.WriteLine("The goals are: ");
        int i = 1;
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"{i}. {goal.FormatForList()}");
            i++;
        }
        Console.WriteLine("What goal did you accomplish? ");
        int goalNumber = int.Parse(Console.ReadLine());
        Goal userGoal = goals[goalNumber - 1];
        int pointsEarned = userGoal.recordGoal();
        AddEarnedPoints(pointsEarned);
        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
    }

public static void redeemPoints()
{
    Console.WriteLine($"You have {earnedPoints} points.");
    Console.WriteLine("Here is a list of available rewards:");
    Console.WriteLine("\t1. 5 points - watch an episode of your favorite show");
    Console.WriteLine("\t2. 10 points - listen to your favorite album");
    Console.WriteLine("\t3. 15 points - treat yourself to some ice cream");
    Console.WriteLine("\t4. 20 points - take a nap");
    Console.WriteLine("\t5. 25 points - buy yourself something you've been wanting");

    Console.WriteLine("Enter the number of the reward you want to redeem: ");
    string rewardChoice = Console.ReadLine();

    int cost = 0;
    string reward = "";

    switch(rewardChoice)
    {
        case "1": cost = 5; reward = "watch an episode of your favorite show"; break;
        case "2": cost = 10; reward = "listen to your favorite album"; break;
        case "3": cost = 15; reward = "treat yourself to some ice cream"; break;
        case "4": cost = 20; reward = "take a nap"; break;
        case "5": cost = 25; reward = "buy yourself something you've been wanting"; break;
        default: Console.WriteLine("Invalid choice. No points deducted"); return;
    }
    if (earnedPoints >= cost)
    {
        earnedPoints = earnedPoints - cost;
        Console.WriteLine($"You have redeemed {reward}.\nYou now have {earnedPoints} points remaining.");
    }
    else
    {
        Console.WriteLine("Sorry, you don't have enough points for that reward.");
    }
}

public abstract void MakeGoal();
public abstract string FormatForFile();
public abstract string FormatForList();
public abstract int recordGoal();
public abstract void TakeFromFile(string[] parts); 

}