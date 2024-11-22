using System;

public class EternalGoal : Goal
{
    private string goalName;
    private string goalDescription;
    private int goalPoints;

    public override void MakeGoal()
    {
        Console.Write(_findGoalName);
        goalName = Console.ReadLine();
        Console.Write(_findGoalDescription);
        goalDescription = Console.ReadLine();
        Console.WriteLine("We recommend rewarding 1 point for easy goals, 3 points for medium goals, and 5 points for hard goals.");
        Console.Write(_findGoalPoints);
        goalPoints = int.Parse(Console.ReadLine());

        Goal.AddGoal(this);
    }

    public override string FormatForFile()
    {
        return $"EternalGoal:{goalName};{goalDescription};{goalPoints}";
    }
    public override string FormatForList()
    {
        return $"[ ] {goalName} ({goalDescription})";
    }

    public override int recordGoal()
    {   
        return goalPoints;
    }

    public override void TakeFromFile(string[] parts)
    {
        goalName = parts[1];
        goalDescription = parts[2];
        goalPoints = int.Parse(parts[3]);
    }
}