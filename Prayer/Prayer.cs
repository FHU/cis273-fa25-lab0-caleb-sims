namespace Prayer;

public class Prayer
{
    public string Title { get; set; } = "";
    public string Subtitle { get; set; } = "";
    public string Body { get; set; } = "";
    public List<ScriptureReferences> ScriptureReferences { get; set; } = new();
    public Author Author { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public override string ToString()
    {
        return $"{Title}: {Subtitle} - {Author}";
    }
}

