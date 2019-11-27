using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Colecciones
    {
       
        
        public void ArregloEnteros()
        {
            string[] numerosEnteros = new string[10];
            for (int i = 0; i < numerosEnteros.Length; i++) {
                numerosEnteros[i] = $"Numero : {i}";
                
            }
            

        }

        public void ListaEnteros()
        {

            List<int> numeros = new List<int>();
            for(int i = 0; i < 10; i++)
            {
                numeros.Add(i);
            }
            //int? conteo = numeros?.Count;

        }
    }
}

