﻿namespace Pokemon;

public abstract class Pokemon
{
    private string name;
    protected string Strength { get; }
    protected string Weakness { get; }

    public string Name { get { return name; } set { name = value; } }

    public Pokemon(string name, string strength, string weakness)
    {
        this.name = name;
        Strength = strength;
        Weakness = weakness;
    }

    public abstract void UseBattleCry(string pokemonName);

    public static string getWeakness(Pokemon pokeObject) { return pokeObject.Weakness; }

    public static string getStrength(Pokemon pokeObject) { return pokeObject.Strength; }
}