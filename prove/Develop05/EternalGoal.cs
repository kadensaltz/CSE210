using System;

public class EternalGoal : Goal
{
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;

    public override void MakeGoal()
    {
        Console.Write(_findGoalName);
        _goalName = Console.ReadLine();
        Console.Write(_findGoalDescription);
        _goalDescription = Console.ReadLine();
        Console.WriteLine("We recommend rewarding 1 point for easy goals, 3 points for medium goals, and 5 points for hard goals.");
        Console.Write(_findGoalPoints);
        _goalPoints = int.Parse(Console.ReadLine());

        Goal.AddGoal(this);
    }

    public override string FormatForFile()
    {
        return $"EternalGoal:{_goalName};{_goalDescription};{_goalPoints}";
    }
    public override string FormatForList()
    {
        return $"[ ] {_goalName} ({_goalDescription})";
    }

    public override int recordGoal()
    {   
        return _goalPoints;
    }

    public override void TakeFromFile(string[] parts)
    {
        _goalName = parts[1];
        _goalDescription = parts[2];
        _goalPoints = int.Parse(parts[3]);
    }
}