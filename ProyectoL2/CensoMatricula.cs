using System;
using System.Collections.Generic;

public class CensoMatricula
{
    public List<Clase> ListadeClase { get; set; }
    public CensoMatricula()
    {
        ListadeClase = new List<Clase>();

        Clase a = new Clase("IA 044", "Lenguaje de programacion I", 0);
        Clase b = new Clase("IA 065", "Lenguaje de programacion II", 0);
        Clase c = new Clase("IA 086", "Lenguaje de programacion III", 0);
        Clase d = new Clase("IA 117", "Lenguaje de programacion IV", 0);
        Clase e = new Clase("IA 127", "Teoria de sistemas", 0);
        Clase f = new Clase("IA 075", "Sistemas Operativos I", 0);
        Clase g = new Clase("IA 096", "Sistemas Operativos II", 0);
        Clase h = new Clase("IA 106", "Base de Datos I", 0);
        Clase i = new Clase("IA 137", "Base de Datos II", 0);
        Clase j = new Clase("IA 148", "Comunicación Electrónica de Datos", 0);
        Clase k = new Clase("IA 158", "Análisis y Diseño de Sistemas", 0);
        Clase l = new Clase("IA 168", "Recursos Humanos en Informática", 0);
        Clase m = new Clase("IA 179", "Redes de Computadoras", 0);
        Clase n = new Clase("IA 189", "Programación e Implementaciónde Sistemas", 0);
        Clase o = new Clase("IA 210", "Gerencia Informática I", 0);
   

        ListadeClase.Add(a);
        ListadeClase.Add(b);
        ListadeClase.Add(c);
        ListadeClase.Add(d);
        ListadeClase.Add(e);
        ListadeClase.Add(f);
        ListadeClase.Add(g);
        ListadeClase.Add(h);
        ListadeClase.Add(i);
        ListadeClase.Add(j);
        ListadeClase.Add(k);
        ListadeClase.Add(l);
        ListadeClase.Add(m);
        ListadeClase.Add(n);
        ListadeClase.Add(o);
    }

    
    public void listarClases() {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine(" LISTADO DE CLASES DISPONIBLES EN EL CENSO DE MATRICULA");
        Console.WriteLine("********************************************************");
        Console.WriteLine("Codigo, Nombre de la clase y Seccion");

        foreach (var Clase in ListadeClase)
        {
            Console.WriteLine(Clase.Codigo + " | " + Clase.NombreClase + " | " + Clase.Seccion.ToString());
        }

        Console.ReadLine();
    }

    private void movimientoCenso(string codigo, int hora, string tipoMovimiento) {
        foreach (var clase in ListadeClase)
        {
            if (clase.Codigo == codigo) {
                if (tipoMovimiento == "+") {
                    clase.Seccion = clase.Seccion + hora;
                } else {
                    clase.Seccion = clase.Seccion- hora;
                }
            }         
        }
    }

    public void ingresoDeClase() {
        string codigo = "";
        string hora = "";

        Console.Clear();
        Console.WriteLine();

        Console.WriteLine("Ingreso de clase para censo 2022");
        Console.WriteLine("**********************************");
        Console.Write("Ingrese el codigo de la clase: ");
        codigo = Console.ReadLine();
        Console.Write("Ingrese la seccion: ");
        hora= Console.ReadLine();

        movimientoCenso(codigo, Int32.Parse(hora), "+");
    }
    public void cancelarClase() {
        string codigo = "";
        string hora = "";

        Console.Clear();
        Console.WriteLine();

        Console.WriteLine("Cancelacion de clase");
        Console.WriteLine("********************");
        Console.Write("Ingrese el codigo de la clase: ");
        codigo = Console.ReadLine();
        Console.Write("Ingrese la seccion: ");
        hora = Console.ReadLine();

        movimientoCenso(codigo, Int32.Parse(hora), "-");
    }
}
   