using System;

public class ChecklistGoal : Goal
{
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;
    private int _completion;
    private int _bonusPoints;
    private int _times = 0;
    private bool _isCompleted = false;

    public override void MakeGoal()
    {
        Console.Write(_findGoalName);
        _goalName = Console.ReadLine();
        Console.Write(_findGoalDescription);
        _goalDescription = Console.ReadLine();
        Console.WriteLine("We recommend rewarding 1 point for easy goals, 3 points for medium goals, and 5 points for hard goals.");
        Console.Write(_findGoalPoints);
        _goalPoints = int.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be completed for a bonus? ");
        _completion = int.Parse(Console.ReadLine());
        Console.Write("How many bonus points will you recieve when the goal is completed? ");
        _bonusPoints = int.Parse(Console.ReadLine());

        Goal.AddGoal(this);
    }

    public override string FormatForFile()
    {
        return $"ChecklistGoal:{_goalName};{_goalDescription};{_goalPoints};{_completion};{_bonusPoints};{_times};{_isCompleted}";
    }

    public override string FormatForList()
    {
        string status = _isCompleted ? "X" : " ";
        return $"[{status}] {_goalName} ({_goalDescription}) -- Currently completed {_times}/{_completion}";
    }

    public override int recordGoal()
    {
        if (_isCompleted)
        {
            Console.WriteLine("This goal has already been completed.");
            return 0;
        }

        _times++;

        if (_times == _completion)
        {
            _isCompleted = true;
            Console.WriteLine($"Congratulations! You've completed the goal and earned a bonus of {_bonusPoints} points!");
            return _goalPoints + _bonusPoints;
        }

        Console.WriteLine($"{_times}/{_completion} times completed.");
        return _goalPoints;
    }

    public override void TakeFromFile(string[] parts)
    {
        _goalName = parts[1];
        _goalDescription = parts[2];
        _goalPoints = int.Parse(parts[3]);
        _completion = int.Parse(parts[4]);
        _bonusPoints = int.Parse(parts[5]);
        _times = int.Parse(parts[6]);
        _isCompleted = bool.Parse(parts[7]);
    }
}