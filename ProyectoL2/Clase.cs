public class Clase
{
    public string Codigo { get; set; }
    public string NombreClase { get; set; }
    public int Seccion { get; set; }

    public Clase (string codigo, string nombreClase, int seccion)
    {
        Codigo = codigo;
        NombreClase = nombreClase;
        Seccion = seccion;
    }

}