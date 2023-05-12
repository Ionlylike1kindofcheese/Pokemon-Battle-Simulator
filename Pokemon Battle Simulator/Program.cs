namespace pokemon;

public class Charmander
{
    private string name;
    private string strength;
    private string weakness;
    public Charmander(string name, string strength, string weakness)
    {
        this.name = name;
        this.strength = strength;
        this.weakness = weakness;
    }
    public void UseBattleCry(string charmanderName)
    {
        if (charmanderName != "")
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(charmanderName + "! ");
            }
        }
        else
        {
            for (int i = 0;i < 10; i++)
            {
                Console.Write("Charmander! ");
            }
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Give your Charmander a name!: ");
        string givenName = Console.ReadLine();
        Charmander myCharmander = new Charmander(givenName, "fire", "water");
        myCharmander.UseBattleCry(givenName);
        bool voidLoop = true;
        while (voidLoop)
        {
            Console.WriteLine("Type 'rename' to rename your Charmander or 'quit' to exit the program:");
            string incomingCommand = Console.ReadLine();
            switch (incomingCommand)
            {
                case "rename":
                    Console.WriteLine("Enter a new name for your Charmander:");
                    givenName = Console.ReadLine();
                    myCharmander = new Charmander(givenName, "fire", "water");
                    myCharmander.UseBattleCry(givenName);
                    break;
                case "quit":
                    voidLoop = false;
                    break;
                default:
                    Console.WriteLine("Invalid command! Try again!");
                    break;
            }
        }
    }
}