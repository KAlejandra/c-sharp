using System;
public class Gato: Mamifero // <- Herencia
{
    public bool EsDomestico { get; set; }

    private bool pelaje;
    private bool Comer;


    public bool GetPelaje()
    {
        return pelaje;
    }

    public void SetPelaje(bool value)
    {
        pelaje = value;
    }

    public new bool Comer { get; set; }
    public new bool Caminar { get; set; }

    public Gato() // <- Polimorfismo
    {
        EsDomestico = true;
        Comer = true;
        Caminar = true;
    }

    public void Maullar() // <- Abstraccion
    {
        Console.WriteLine("Miau miau miau ");
    }

    public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("Es un gato pequeno");
    }

    private void OtroMetodo() // <- Encapsulamiento
    {
        SetPelaje(true);
        Comer = true;
    }
}
