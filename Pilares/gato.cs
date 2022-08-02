using System;
public class gato: Mamifero // <- Herencia
{
    public bool EsDomestico { get; set; }
    public string Pelaje { get; set; }

    public gato() // <- Polimorfismo
    {
        EsDomestico = true;
    }

    public gato(bool esDomestico) // <- Polimorfismo
    {
        EsDomestico = esDomestico;
    }

    public void Maullar() // <- Abstraccion
    {
        Console.WriteLine("Miau miau miau");
    }
    
    public void Tamano()
    {
        DescribirTamano();
    }

    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("A small cat");
    }

}