public class Person
{
    public readonly string Name;
    public int Turns { get; set; }
    public bool HasInfiniteTurns;


    internal Person(string name, int turns)
    {
        Name = name;
        Turns = turns;

        if (turns == 0 || turns < 0)
        {
            HasInfiniteTurns = true;
        }
        else
        {
            HasInfiniteTurns = false;
        }
    }

    public override string ToString()
    {
        return Turns <= 0 ? $"({Name}:Forever)" : $"({Name}:{Turns})";
    }
}
