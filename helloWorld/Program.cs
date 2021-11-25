using System;
using System.Collections.Generic;
using System.Linq;

namespace helloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ejercicios Alberto Olle");
            //ejercicio1();
            //ejercicio2();
            ejercicio3();
        }

        private static void ejercicio1()
        {
            //https://www.exercisescsharp.com/es/condiciones-b/control-de-acceso
            int intentos = 0;
            Boolean endBucle = false;
            int inputUser, inputPass;

            Console.WriteLine("Porfavor, escribe tu usuario  y contraseña");
            while (!endBucle )
            {
                inputUser = Convert.ToInt32(Console.ReadLine());
                inputPass = Convert.ToInt32(Console.ReadLine()); 

                if(inputUser == 12 && inputPass == 1234)
                {
                    Console.WriteLine("Inicio de sesion correcto");
                    endBucle = true;
                }
                else
                {
                    intentos++;
                    Console.WriteLine("Inicio de sesion incorrecto, intentos restates " + (3 - intentos));
                    if(intentos == 3)
                    {
                        Console.Write("Inicio de sesion fallido, cerrando programa");
                        endBucle = true;
                    }
                }
            }
        }

        public static void ejercicio2()
        {
            //https://www.exercisescsharp.com/es/matrices/buscar-numeros-pares
            int[] matriz = new int[10];
            Console.WriteLine("Porfavor introduce 10 numeros");
            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < matriz.Length; i++)
            {
                if (matriz[i] % 2 == 0)
                {
                    Console.Write(matriz[i]);
                }
            }
        }
        public static void ejercicio3()
        {
            //https://www.exercisescsharp.com/es/funciones-b/funcion-modificar-caracter-de-texto
            string texto, caracter;
            int posicion;
           
            Console.WriteLine("Inserta un texto");
            texto = Console.ReadLine();
            Console.WriteLine("Introduce una posicion del texto");
            posicion = Convert.ToInt32(Console.ReadLine())-1;
            Console.WriteLine("Introduce un caracter para remplazarlo");    
            caracter = Console.ReadLine();

            Console.WriteLine("El nuevo texto es " + cambiarLetra(texto, posicion, caracter));
        }

        public static string cambiarLetra(string texto, int posicion, string caracter)
        {   
            texto = texto.Remove(posicion, 1);
            texto = texto.Insert(posicion, caracter);
            return texto;
        }
    }

}