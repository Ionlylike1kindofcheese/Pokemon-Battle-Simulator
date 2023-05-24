namespace Main;

using Pokemon;
using Trainer;

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