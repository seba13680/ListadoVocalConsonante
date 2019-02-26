using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVocalConsonante
{
    class Program
    {
        static void Main(string[] args)
        {

            List<listaNombres> lista = new List<listaNombres>();

            lista.Add(new listaNombres() { ListaNombres = "Alberto"});
            lista.Add(new listaNombres() { ListaNombres = "Juana" });
            lista.Add(new listaNombres() { ListaNombres = "Eliana" });
            lista.Add(new listaNombres() { ListaNombres = "Pedro" });
            lista.Add(new listaNombres() { ListaNombres = "Ezequiel" });
            lista.Add(new listaNombres() { ListaNombres = "Ruben" });
            lista.Add(new listaNombres() { ListaNombres = "Mario" });
            lista.Add(new listaNombres() { ListaNombres = "Alejandro" });
            lista.Add(new listaNombres() { ListaNombres = "Priscila" });
            lista.Add(new listaNombres() { ListaNombres = "Eugenio" });
            lista.Add(new listaNombres() { ListaNombres = "Leandro" });
            lista.Add(new listaNombres() { ListaNombres = "Mario" });
            lista.Add(new listaNombres() { ListaNombres = "Sebastian" });
            lista.Add(new listaNombres() { ListaNombres = "Bruno" });

            // 1) Separar en 2 listas diferentes, aquellos que empiezan con una vocal y en la segunda aquellos
            // que empiezan con una consonante.Mostrar ambas listas

            // Listar nombres por vocal
            Console.WriteLine("-- Listado de nombres (vocales) --");
            foreach (var listaVocal in lista)
            {
                if (listaVocal.ListaNombres.StartsWith("A") ||
                    listaVocal.ListaNombres.StartsWith("E") ||
                    listaVocal.ListaNombres.StartsWith("I") ||
                    listaVocal.ListaNombres.StartsWith("O") ||
                    listaVocal.ListaNombres.StartsWith("U"))
                {
                    Console.WriteLine(listaVocal.ListaNombres);
                }
            }

            // Listar nombres por consonantes
            Console.WriteLine("-- Listado de nombres (consonantes) --");
            foreach (var listaVocal in lista)
            {
                if (!listaVocal.ListaNombres.StartsWith("A") &&
                    !listaVocal.ListaNombres.StartsWith("E") &&
                    !listaVocal.ListaNombres.StartsWith("I") &&
                    !listaVocal.ListaNombres.StartsWith("O") &&
                    !listaVocal.ListaNombres.StartsWith("U"))
                {
                    Console.WriteLine(listaVocal.ListaNombres);
                }
            }

            // 2) Tomar ambas lista y ordenaras alfabeticamente, primero en orden ascendente y luego descendente. Mostrarlas

            // Listar ordenadas alfabeticamente en orden ascendente
            Console.WriteLine("-- Lista nombres ordenados alfabeticamente en orden ascendente --");

            foreach (var listaPersonas in lista.OrderBy(x => x.ListaNombres))
            {
                 Console.WriteLine(listaPersonas.ListaNombres);
            }

            // Listar ordenadas alfabeticamente en orden descendente
            Console.WriteLine("-- Lista nombres ordenados alfabeticamente en orden descendente --");

            foreach (var listaPersonas in lista.OrderByDescending(x => x.ListaNombres))
            {
                Console.WriteLine(listaPersonas.ListaNombres);
            }

            // 3) Tomar ambas listas e invertir todos sus textos, por ejemplo Pricila -> alicirP

            Console.WriteLine("-- Lista nombres invertida --");



            foreach (var listaInvertida in lista.OrderBy(x => x.ListaNombres))
            {
                var nombreInv = "";
                for (int x = listaInvertida.ListaNombres.Length - 1; x >= 0; x--)
                {
                    nombreInv += listaInvertida.ListaNombres[x];
                }

                Console.WriteLine(nombreInv);
            }

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
