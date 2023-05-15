namespace pokemon;

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
            Charmander trainer1Pokemon = Pokeball.getPokemon(firstTrainer.Belt[index]);
            firstTrainer.throwPokeball(firstTrainer.Name, trainer1Pokemon);
            trainer1Pokemon.UseBattleCry(trainer1Pokemon.Name);

            Charmander trainer2Pokemon = Pokeball.getPokemon(secondTrainer.Belt[index]);
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


public class Charmander
{
    private string name;
    private string strength;
    private string weakness;

    public string Name { get { return name; } set { name = value; } }


    public Charmander(string name, string strength, string weakness)
    {
        this.name = name;
        this.strength = strength;
        this.weakness = weakness;
    }


    public void UseBattleCry(string charmanderName)
    {
        Console.Write(charmanderName + " uses it's battle cry: \"");
        for (int i = 0; i < 10; i++)
        {
            if (charmanderName != "") { Console.Write(charmanderName + "! "); }
            else { Console.Write("Charmander! "); }
        }
        Console.WriteLine("\"");
    }
}


public class Pokeball
{
    private Charmander pokemon;
    private bool isEmpty;


    public Pokeball(Charmander pokemon = null)
    {
        this.pokemon = pokemon;
        this.isEmpty = pokemon == null;
    }


    public static Charmander getPokemon(Pokeball curBall)
    {
        return curBall.pokemon;
    } 
}


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

        for (int index = 1; index < 7; index++)
        {
            Pokeball pokeball = new Pokeball(new Charmander("Charmander" + index, "fire", "water"));
            this.belt.Add(pokeball);
        }
    }


    public static int beltCount(Trainer curTrainer)
    {
        return curTrainer.belt.Count;
    }


    public void throwPokeball(string trainerName, Charmander pokemonObj)
    {
        if (pokemonObj != null) { Console.WriteLine(trainerName + " throws a pokeball. " + pokemonObj.Name + " releases out of it's ball!"); }
        else { Console.WriteLine(trainerName + " throws an empty ball..."); }
    }


    public void returnToPokeball(string trainerName, Charmander pokemonObj)
    {
        if (pokemonObj != null) { Console.WriteLine(trainerName + " returns " + pokemonObj.Name + " back to it's pokeball!"); }
        else { Console.WriteLine(trainerName + " returns the empty pokeball!"); }
    }
}