using System;
public class mono: Mamifero // <- Herencia

{
    public bool EsDomestico { get; set; }
    public bool Comer{ get; set; }

    public mono() // <- Polimorfismo
    {
        EsDomestico = false;
    }

    public void Maullar() // <- Abstraccion
    {
        Console.WriteLine("Hu hu ha ha");
    }

    public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("A large monkey");
    }

    private void OtroMetodo() // <- Encapsulamiento
    {
        Comer = true;
    }
}
