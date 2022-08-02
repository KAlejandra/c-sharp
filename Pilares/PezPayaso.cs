using System;
public class PezPayaso: Aves // <- Herencia

{
    public bool NoEsDomestico { get; set; }

    public PezPayaso() // <- Polimorfismo
    {
        EsDomestico = false;
    }

    public PezPayaso(bool NoesDomestico) // <- Polimorfismo
    {
        NoEsDomestico = noesDomestico;
    }

    public void Nadar() // <- Abstraccion
    {
        Console.WriteLine("Nada en arrecifes coralinos y lagunas marina");
    }

    public void Generalidades()
    {
        Describir();
        Tamano();
    }

    private void Describir() // <- Encapsulamiento
    {
        Console.WriteLine("Es una especie de pez perciforme de la familia Pomacentridae");
    }

    private void Tamano() // <- Encapsulamiento
    {
        Console.WriteLine("Su tamano es de 10 a 18 centímetros");
    }
}