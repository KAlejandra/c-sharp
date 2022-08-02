using System;
public class Loro: Aves // <- Herencia

{
    public bool NoEsDomestico { get; set; }

    public Loro() // <- Polimorfismo
    {
        EsDomestico = false;
    }

    public Loro(bool NoesDomestico) // <- Polimorfismo
    {
        NoEsDomestico = noesDomestico;
    }

    public void Hablar() // <- Abstraccion
    {
        Console.WriteLine("Habla palabras aprendidas");
    }

    public void Generalidades()
    {
        Describir();
        OtroMetodo();
    }

    private void Describir() // <- Encapsulamiento
    {
        Console.WriteLine("Loro es capaz de imitar lo que su dueño hable o personas a su entorno");
    }

    private void OtroMetodo() // <- Encapsulamiento
    {

    }
}