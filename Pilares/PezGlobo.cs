using System;
public class PezGlobo: Peces // <- Herencia

{
    public bool NoEsDomestico { get; set; }

    public PezGlobo() // <- Polimorfismo
    {
        EsDomestico = false;
    }

    public PezGlobo(bool NoesDomestico) // <- Polimorfismo
    {
        NoEsDomestico = noesDomestico;
    }

    public void Nadar() // <- Abstraccion
    {
        Console.WriteLine("Nada lento y torpe");
    }

    public void Generalidades()
    {
        Describir();
    }

    private void Describir() // <- Encapsulamiento
    {
        Console.WriteLine("Utiliza su habilidad de inflarse al estar cerca de depredadores");
    }
}