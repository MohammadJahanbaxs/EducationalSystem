namespace EducationalSystem.Entities;

public class Letter
{
    public Letter(string name, string letterId, string text, DateTime timeSend)
    {
        Name = name;
        LetterId = letterId;
        Text = text;
        TimeSend = timeSend;
    }

    public string Name { get; private set; }
    public string LetterId { get; private set; }
    public string Text { get; private set; }
    public DateTime TimeSend { get; private set; }
    
    
}