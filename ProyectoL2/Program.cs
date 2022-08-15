using System;

namespace censo
{
    class Program
    {        
        static void Main(string[] args)
        {
            string opcion = "";
            CensoMatricula censoMatricula = new CensoMatricula();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("CENSO DE MATRICULA III PAC");
                Console.WriteLine("**************************");
                Console.WriteLine("");
                Console.WriteLine("1 - Clase");
                Console.WriteLine("2 - Ingreso de clase");
                Console.WriteLine("3 - Cancelar clase");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": 
                        censoMatricula.listarClases();
                        break;
                    case "2":
                        censoMatricula.ingresoDeClase();
                        break;                        
                    case "3":
                        censoMatricula.cancelarClase();
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