using System;

public class ChecklistGoal : Goal
{
    private string goalName;
    private string goalDescription;
    private int goalPoints;
    private int completion;
    private int bonusPoints;
    private int times = 0;
    private bool _isCompleted = false;

    public override void MakeGoal()
    {
        Console.Write(_findGoalName);
        goalName = Console.ReadLine();
        Console.Write(_findGoalDescription);
        goalDescription = Console.ReadLine();
        Console.WriteLine("We recommend rewarding 1 point for easy goals, 3 points for medium goals, and 5 points for hard goals.");
        Console.Write(_findGoalPoints);
        goalPoints = int.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be completed for a bonus? ");
        completion = int.Parse(Console.ReadLine());
        Console.Write("How many bonus points will you recieve when the goal is completed? ");
        bonusPoints = int.Parse(Console.ReadLine());

        Goal.AddGoal(this);
    }

    public override string FormatForFile()
    {
        return $"ChecklistGoal:{goalName};{goalDescription};{goalPoints};{completion};{bonusPoints};{times};{_isCompleted}";
    }

    public override string FormatForList()
    {
        string status = _isCompleted ? "X" : " ";
        return $"[{status}] {goalName} ({goalDescription}) -- Currently completed {times}/{completion}";
    }

    public override int recordGoal()
    {
        if (_isCompleted)
        {
            Console.WriteLine("This goal has already been completed.");
            return 0;
        }

        times++;

        if (times == completion)
        {
            _isCompleted = true;
            Console.WriteLine($"Congratulations! You've completed the goal and earned a bonus of {bonusPoints} points!");
            return goalPoints + bonusPoints;
        }

        Console.WriteLine($"{times}/{completion} times completed.");
        return goalPoints;
    }

    public override void TakeFromFile(string[] parts)
    {
        goalName = parts[1];
        goalDescription = parts[2];
        goalPoints = int.Parse(parts[3]);
        completion = int.Parse(parts[4]);
        bonusPoints = int.Parse(parts[5]);
        times = int.Parse(parts[6]);
        _isCompleted = bool.Parse(parts[7]);
    }
}