using System;

public abstract class Peces: Animal
{
    public int NumerodeAletas { get; set; }

    public void Nadar()
    {
        Console.WriteLine("Nadando...");
    }
}