using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class MetodosPruebas
    {
        #region Parametros
        public string NombreCompleto(string nombres, string apellidos)
        {
            return $"{nombres} {apellidos}";
        }
        public int SumaDosNumeros(int numeroUno, int numeroDos = 2)
        {
            return numeroUno + numeroDos;
        }
        public void SumarUno(int numeroOriginal)
        {
            numeroOriginal += 1;
        }

        public void SumarUnoReferencia(ref int numero)
        {
            numero += 1;
        }

        public void RestarUno(int num)
        {
            num -= 1;
        }

        public void RestarUnoOut(out int num)
        {
            num = 2;
            num -= 1;
        }
        #endregion

        #region SobreCargas

        public void MostrarInfo(string nombre, byte edad)
        {
            Console.WriteLine($"{nombre} su edad en 5 años es:{edad + 5}");
        }

        public void MostrarInfo(string nombre)
        {
            Console.WriteLine($"{nombre}");
        }

        public void MostrarInfo(string nombre, int edad)
        {
            Console.WriteLine($"{nombre} su edad en 5 años es:{edad + 5}");
        }


        #endregion

        public void DividirPorCero(int numero)
        {
            try
            {
                Console.WriteLine("Inicia la division");
                int x = numero + Convert.ToInt32("4567893456782345678");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finalizo el proceso");
            }
        }

        public int ObtenerNumeroRandom()
        {
            try
            {
                int x = new Random().Next() + Convert.ToInt32("4567893456782345678");
                return x;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return 1;
        }


        public void SumarNumeroMasRandom(int numero = 5)
        {
            try
            {
                int x = 1;
                try
                {
                    x = new Random().Next()/* + Convert.ToInt32("4567893456782345678")*/;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);

                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                int resultado = numero + x;
            }
            catch (Exception)
            {

            }

        }


        public void EscribirNumero()
        {
            int numero = 5;
            SumarCinco(ref numero);
            Console.WriteLine(numero);
        }

        public void SumarCinco(ref int numero)
        {
            numero += 5;
        }

        public void metodoConExcepcion()
        {

            try
            {
                
                int x = 832322323 + Convert.ToInt32("4567893456782345678");
            }
            catch (Exception)
            {
                Console.WriteLine(StructMensajes.ErrorSimple);
            }


        }

    }
}
