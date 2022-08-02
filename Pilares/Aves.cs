using System;

public abstract class Aves: Animal
{
    public int ColordePlumaje { get; set; }

    public void Volar()
    {
        Console.WriteLine("Volando...");
    }
}