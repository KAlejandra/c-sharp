using System;
public class Aguila: Aves // <- Herencia

{
    public bool NoEsDomestico { get; set; }

    public Aguila() // <- Polimorfismo
    {
        EsDomestico = false;
    }

    public Aguila(bool NoesDomestico) // <- Polimorfismo
    {
        NoEsDomestico = noesDomestico;
    }

    public void VolarAlto() // <- Abstraccion
    {
        Console.WriteLine("Aletea hasta el cielo");
    }

    public void Generalidades()
    {
        Describir();
        OtroMetodo();
    }

    private void Describir() // <- Encapsulamiento
    {
        Console.WriteLine("Aguila capaz de volar muy alto");
    }

    private void OtroMetodo() // <- Encapsulamiento
    {

    }
}