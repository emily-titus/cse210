using System;

public class Assignment
{
    protected string _studentName;
    private string _topic;

    public Assignment()
    {
        _studentName = "none";
        _topic = "none";
    }
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public String GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}