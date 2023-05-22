namespace Trainer;

// Trainer-related classes

using Main;
using Pokemon;

public class Trainer
{
    private string name;
    private List<Pokeball> belt;

    public string Name { get { return name; } set { name = value; } }
    public List<Pokeball> Belt { get { return belt; } }


    public Trainer(string name)
    {
        this.name = Program.FirstCharToUpper(name.ToLower());
        this.belt = new List<Pokeball>();

        for (int index = 1; index < 3; index++)
        {
            Pokeball charBall = new Pokeball(new Charmander("Charmander" + index));
            Pokeball sqBall = new Pokeball(new Squirtle("Squirtle" + index));
            Pokeball bulbBall = new Pokeball(new Bulbasaur("Bulbasaur" + index));
            this.belt.Add(charBall);
            this.belt.Add(sqBall);
            this.belt.Add(bulbBall);
        }
    }


    public static int beltCount(Trainer curTrainer)
    {
        return curTrainer.belt.Count;
    }


    public void throwPokeball(string trainerName, Pokemon pokemonObj)
    {
        if (pokemonObj != null) { Console.WriteLine(trainerName + " throws a pokeball. " + pokemonObj.Name + " releases out of it's ball!"); }
        else { Console.WriteLine(trainerName + " throws an empty ball..."); }
    }


    public void returnToPokeball(string trainerName, Pokemon pokemonObj)
    {
        if (pokemonObj != null) { Console.WriteLine(trainerName + " returns " + pokemonObj.Name + " back to it's pokeball!"); }
        else { Console.WriteLine(trainerName + " returns the empty pokeball!"); }
    }
}


public class Pokeball
{
    private Pokemon pokemon;
    private bool isEmpty;


    public Pokeball(Pokemon pokemon = null)
    {
        this.pokemon = pokemon;
        this.isEmpty = pokemon == null;
    }


    public static Pokemon getPokemon(Pokeball curBall)
    {
        return curBall.pokemon;
    }
}
