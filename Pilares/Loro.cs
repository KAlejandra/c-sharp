using System;
public class Loro: Aves // <- Herencia

{
    public bool EsDomestico { get; set; }
    public new bool Comer { get; set; }

    public Loro() // <- Polimorfismo
    {
        EsDomestico = true;
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
        Comer = true;
    }
}
