using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            MetodosPruebas obj = new MetodosPruebas();
            string nombre = obj.NombreCompleto("Jonathan Steven", "Soto Orjuela");
            int resultado = obj.SumaDosNumeros(3);

            int numeroInicial = 5;
            obj.SumarUno(numeroInicial);
            obj.SumarUnoReferencia(ref numeroInicial);

            int numeroInicialDos = 3;
            obj.RestarUno(numeroInicialDos);
            int numeroInicialDosOut;
            obj.RestarUnoOut(out numeroInicialDosOut);

            //obj.DividirPorCero(900000000);
            //obj.SumarNumeroMasRandom();
            obj.metodoConExcepcion();
            obj.EscribirNumero();

            // Arreglos 

            Colecciones cm = new Colecciones();
            cm.ArregloEnteros();
            cm.ListaEnteros();


            Console.ReadKey();

        }
    }
}
