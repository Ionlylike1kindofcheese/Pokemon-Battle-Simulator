namespace pokemon;


// Main execution!!!

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Give the first trainer a name: ");
        Trainer firstTrainer = new Trainer(Console.ReadLine());
        Console.Write("Give the second trainer a name: ");
        Trainer secondTrainer = new Trainer(Console.ReadLine());
        for (int index = 0; index < Trainer.beltCount(firstTrainer); index++)
        {
            Pokemon trainer1Pokemon = Pokeball.getPokemon(firstTrainer.Belt[index]);
            firstTrainer.throwPokeball(firstTrainer.Name, trainer1Pokemon);
            trainer1Pokemon.UseBattleCry(trainer1Pokemon.Name);

            Pokemon trainer2Pokemon = Pokeball.getPokemon(secondTrainer.Belt[index]);
            secondTrainer.throwPokeball(secondTrainer.Name, trainer2Pokemon);
            trainer2Pokemon.UseBattleCry(trainer2Pokemon.Name);

            firstTrainer.returnToPokeball(firstTrainer.Name, trainer1Pokemon);
            secondTrainer.returnToPokeball(secondTrainer.Name, trainer2Pokemon);
            Console.WriteLine();
        }
        Console.ReadLine();
    }


    public static string FirstCharToUpper(string input)
    {
        switch (input)
        {
            case null: throw new ArgumentNullException(nameof(input));
            case "": throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
            default: return input[0].ToString().ToUpper() + input.Substring(1);
        }
    }
}


// Pokemon-related classes

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


public class Charmander : Pokemon
{
    private const string strength = "fire";
    private const string weakness = "water";

    public Charmander(string name) : base(name) { }

    public override void UseBattleCry(string pokemonName)
    {
        Console.Write(pokemonName + " uses it's battle cry: \"");
        for (int i = 0; i < 10; i++)
        {
            if (pokemonName != "") { Console.Write(pokemonName + "! "); }
            else { Console.Write("Charmander! "); }
        }
        Console.WriteLine("\"");
    }
}


public class Squirtle : Pokemon
{
    private const string strength = "water";
    private const string weakness = "grass";

    public Squirtle(string name) : base(name) { }

    public override void UseBattleCry(string pokemonName)
    {
        Console.Write(pokemonName + " uses it's battle cry: \"");
        for (int i = 0; i < 10; i++)
        {
            if (pokemonName != "") { Console.Write(pokemonName + "! "); }
            else { Console.Write("Squirtle! "); }
        }
        Console.WriteLine("\"");
    }
}


public class Bulbasaur : Pokemon
{
    private const string strength = "grass";
    private const string weakness = "fire";

    public Bulbasaur(string name) : base(name) { }

    public override void UseBattleCry(string pokemonName)
    {
        Console.Write(pokemonName + " uses it's battle cry: \"");
        for (int i = 0; i < 10; i++)
        {
            if (pokemonName != "") { Console.Write(pokemonName + "! "); }
            else { Console.Write("Bulbasaur! "); }
        }
        Console.WriteLine("\"");
    }
}


// Trainer-related classes

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