using System;

namespace censo
{
    class Program
    {
        static string[,] clases = new string[15,3]
        {
            { "IA - 044 ", "Lenguaje de programacion I", "0" },
            { "IA - 065 ", "Lenguaje de programacion II", "0" },
            { "IA - 086 ", "Lenguaje de programacion III", "0" },
            { "IA - 117 ", "Lenguaje de programacion IV", "0" },
            { "IA - 127 ", "Teoria de sistemas", "0" },
            { "IA - 075 ", "Sistemas Operativos I", "0" },
            { "IA - 096 ", "Sistemas Operativos II", "0" },
            { "IA - 106 ", "Base de Datos I", "0" },
            { "IA - 137 ", "Base de Datos II", "0" },
            { "IA - 148 ", "Comunicación Electrónica de Datos", "0" },
            { "IA - 158 ", "Análisis y Diseño de Sistemas", "0" },
            { "IA - 168 ", "Recursos Humanos en Informática.", "0" },
            { "IA - 179 ", "Redes de Computadoras", "0" },
            { "IA - 189 ", "Programación e Implementaciónde Sistemas.", "0" },
            { "IA - 210 ", "Gerencia Informática I", "0" },
        };

        static void listarClasesParaCenso() {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Listado de clases");
            Console.WriteLine("********************");
            Console.WriteLine("Codigo, Nombre  y Seccion de la Clase");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(clases[i, 0] + " | " + clases[i, 1] + " | " + clases[i, 2]);
            }

            Console.ReadLine();
        }

        static void movimientoCenso(string codigo, int Seccion, string tipoMovimiento) {
            for (int i = 0; i < 5; i++)
            {
                if (clases[i, 0] == codigo) {
                    if (tipoMovimiento == "+") {
                        clases[i, 2] = (Int32.Parse(clases[i, 2]) + Seccion).ToString();
                    } else {
                        clases[i, 2] = (Int32.Parse(clases[i, 2]) - Seccion).ToString();
                    }
                }
            }
        }

        static void ingresoDeClase() {
            string codigo = "";
            string Seccion = "";

            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("Ingreso de Clases al Censo de Matricula");
            Console.WriteLine("**********************************");
            Console.Write("Ingrese el codigo de la clase: ");
            codigo = Console.ReadLine();
            Console.Write("Ingrese la seccion del producto: ");
            Seccion = Console.ReadLine();

            movimientoCenso(codigo, Int32.Parse(Seccion), "+");
        }
        static void EliminarClaseDelCenso() {
            string codigo = "";
            string Seccion = "";

            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("Cancelar clase ingresada al censo");
            Console.WriteLine("**********************************");
            Console.Write("Ingrese el codigo de la clase: ");
            codigo = Console.ReadLine();
            Console.Write("Ingrese la seccion de la clase: ");
            Seccion = Console.ReadLine();

            movimientoCenso(codigo, Int32.Parse(Seccion), "-");
        }


        
        static void Main(string[] args)
        {
            string opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("CENSO DE MATRICULA III PAC");
                Console.WriteLine("**************************");
                Console.WriteLine("");
                Console.WriteLine("1 - Clases");
                Console.WriteLine("2 - Ingreso de Clase");
                Console.WriteLine("3 - Cancelar clase");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": 
                        listarClasesParaCenso();
                        break;
                    case "2":
                        ingresoDeClase();
                        break;
                    case "3":
                        EliminarClaseDelCenso();
                        break;
                    default:
                    break;
                }

                if (opcion == "0") {
                    break;
                }
            }            
        }
    }
}