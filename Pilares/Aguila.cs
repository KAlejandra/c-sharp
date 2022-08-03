using System;
public class Aguila: Aves // <- Herencia

{
    public bool EsDomestico { get; set; 
    public bool Comer { get; set; }

    public Aguila() // <- Polimorfismo
    {
        EsDomestico = false;
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
        Comer = true;
    }
}
