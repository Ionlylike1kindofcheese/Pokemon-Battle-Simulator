namespace Pokemon;

public abstract class Pokemon
{
    private string name;

    public string Name { get { return name; } set { name = value; } }
    protected string Strength { get; }
    protected string Weakness { get; }

    public Pokemon(string name, string strength, string weakness)
    {
        this.name = name;
        Strength = strength;
        Weakness = weakness;
    }

    public abstract void UseBattleCry(string pokemonName);
}