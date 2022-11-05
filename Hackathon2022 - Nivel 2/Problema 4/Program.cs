using System;
using System.Diagnostics.CodeAnalysis;

internal class Program
{
    /// <summary>
    /// Convierte los números decimales en Binarios
    /// </summary>
    /// <param name="num">El número decimal que se convertirá en Binario</param>
    /// <returns></returns>
    private static int ConvertirABinario(int num)
    {
        int binario = 0;

        const int DIVISOR = 2;
        int digito = 0;

        for (int i = num % DIVISOR, j = 0; num > 0; num /= DIVISOR, i = num % DIVISOR, j++)
        {
            digito = i % DIVISOR;
            binario += digito * (int)Math.Pow(10, j);
        }
        return binario;
    }

    /// <summary>
    /// Suma de la cantidad de unos en el conjunto de los binarios
    /// </summary>
    /// <param name="binario"> Conjunto de los binarios</param>
    /// <returns></returns>
    private static int SumarBinario(string binario)
    {
        int total = 0;
        foreach (char n in binario)
        {
            if(n == '1')
            {
                total++;
            }
        }
        return total;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Problema 3 - Abuela binaria");

        //Creación de variables
        string confirmacion = "si";
        string binario1;
        string binario2;
        long resultado;
        int num1;
        int num2 = 0;
        int num3 = 0;
        bool validacion = true;

        //Ciclo de utilización del programa
        while (confirmacion == "si")
        {
            //Ingreso de datos y verificacion condiciones
            while (validacion)
            {
                Console.WriteLine("Ingresa el primer número (N)");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el segundo número (Primer número cuya suma sea con el segundo sea N)");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el tercer número (Segundo número cuya suma sea con el primero sea N)");
                num3 = int.Parse(Console.ReadLine());
                if (num1 == num2 + num3)
                {
                    validacion = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("La suma del segundo y tercer número no son iguales al primer número");
                    validacion = true;
                }
            }

            //Conversiones y suma de la cantidad de unos
            binario1 = Convert.ToString(ConvertirABinario(num2));
            binario2 = Convert.ToString(ConvertirABinario(num3));
            resultado = SumarBinario(binario1 + binario2);

            //Respuesta
            Console.WriteLine(string.Format("La abuela le reagalará a su nieta ({0}) ({1} + {2}) avellanas", resultado, binario1, binario2));
            Console.WriteLine("¿Desea volver a realizar otro problema? Ingrese Si o No");
            confirmacion = Console.ReadLine();
            confirmacion = confirmacion.ToLower();
            validacion = true;
            Console.Clear();
        }
    }
}