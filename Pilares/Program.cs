using System;

namespace Pilares
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilidades.EnviarCorreo();

            Perro p = new Perro();
            p.Nombre = "Firulais";
            p.Patas = 4;
            p.EsDomestico = true;
            p.Comer();
            p.Caminar();
            p.Ladrar();
            p.Tamano();

            Console.WriteLine(p.Nombre);
            Console.WriteLine(p.Patas);

            Gato g = new Gato();
            g.Nombre = "Garfield";
            g.Patas = 4;
            g.Comer();
            g.Caminar();
            g.Maullar();

            Console.WriteLine(g.Nombre);
            Console.WriteLine(g.Patas);

            mono m = new mono();
            m.Nombre = "Miki";
            m.Patas = 4;
            m.Comer();
            m.Caminar();
            m.Maullar();

            Console.WriteLine(m.Nombre);
            Console.WriteLine(m.Patas);

            Aguila Aa = new Aguila();
            Aa.Nombre = "Velss";
            Aa.ColordePlumaje = 2;
            Aa.Comer();
            Aa.VolarAlto();
            Aa.Generalidades();

            Console.WriteLine(Aa.Nombre);
            Console.WriteLine(Aa.ColordePlumaje);

            Loro L = new Loro();
            L.Nombre = "Lorencio";
            L.ColordePlumaje= 3;
            L.Comer();
            L.Volar();
            L.Generalidades();

            Console.WriteLine(L.Nombre);
            Console.WriteLine(L.ColordePlumaje);

            PezGlobo G = new PezGlobo();
            G.Nombre = "Lorencio";
            G.NumerodeAletas= 2;
            G.Comer();
            G.Nadar();
            G.Generalidades();

            Console.WriteLine(G.Nombre);
            Console.WriteLine(G.NumerodeAletas);

            PezPayaso P = new PezPayaso();
            P.Nombre = "Lorencio";
            P.NumerodeAletas= 2;
            P.Describir();
            P.Nadar();
            P.Generalidades();

            Console.WriteLine(P.Nombre);
            Console.WriteLine(P.NumerodeAletas);


        }
    }
}
