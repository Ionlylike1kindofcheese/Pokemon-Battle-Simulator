namespace Trainer;

using Pokemon;

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