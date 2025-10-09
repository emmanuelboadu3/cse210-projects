using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName() => _shortName;
    public string GetDescription() => _description;
    public int GetPoints() => _points;

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();

    // Factory method for loading goals
    public static Goal CreateGoalFromString(string type, string details)
    {
        string[] parts = details.Split(",");

        if (type == "SimpleGoal")
        {
            return new SimpleGoal(parts[0], parts[1], int.Parse(parts[2]), bool.Parse(parts[3]));
        }
        else if (type == "EternalGoal")
        {
            return new EternalGoal(parts[0], parts[1], int.Parse(parts[2]));
        }
        else if (type == "ChecklistGoal")
        {
            return new ChecklistGoal(parts[0], parts[1], int.Parse(parts[2]),
                int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
        }
        else
        {
            throw new Exception("Unknown goal type");
        }
    }
}
