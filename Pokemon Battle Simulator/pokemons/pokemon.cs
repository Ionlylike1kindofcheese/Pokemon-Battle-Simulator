namespace Pokemon;

public abstract class Pokemon
{
    private string name;

    public string Name { get { return name; } set { name = value; } }

    public Pokemon(string name)
    {
        this.name = name;
    }

    public abstract void UseBattleCry(string pokemonName);
}