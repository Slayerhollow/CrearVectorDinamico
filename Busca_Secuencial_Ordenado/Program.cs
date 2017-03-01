using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrearVectorDinamico
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un objeto de la clase random para generar numeros dinamicamente
            Random rnd = new Random();
            //Instanciar un arreglo entero de tamaño 1
            int[] arreglo = new int[1];
            //el numero 10 de abajo determina la cantidad elementos
            for (int i = 0; i < 10; i++)
            {
                //solo el primer caso es diferente
                if (i == 0)
                {
                    arreglo = new int[i + 1];
                    arreglo[i] = rnd.Next(1, 10);
                }
                else
                {
                    //creamos un vector llamado "aux" el cual almacena el arreglo anterior
                    int[] aux = arreglo;
                    //se instancia de nuevo el arreglo principal
                    arreglo = new int[i + 1];
                    //se almacena el nuevo valor al final del vector
                    arreglo[i] = rnd.Next(1, 10);
                    //en este ciclo almacenamos los antiguos valores
                    for (int j = 0; j < aux.Length; j++)
                    {
                        arreglo[j] = aux[j];
                    }
                }               
            }
            //se imprime el ultimo valor
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i]);
            }
            Console.ReadLine();
        }
    }
}
