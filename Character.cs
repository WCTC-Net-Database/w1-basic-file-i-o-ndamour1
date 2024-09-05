public class Character
{
    public string name { get; set; }
    public string characterClass { get; set; }
    public int level { get; set; }
    public string[] equipment { get; set; }

    public override string ToString()
    {
        return $"{name} the {characterClass}, Level {level}, {equipment}";
    }
}