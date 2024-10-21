using System;

class Program
{
    static void Main()
    {
        int numero;
        int suma = 0;
        int contador = 0;

        do
        {
            Console.Write("Ingrese un número (0 para finalizar): ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero != 0)
            {
                suma += numero;
                contador++;
            }

        } while (numero != 0);

        if (contador > 0)
        {
            double promedio = (double)suma / contador;
            Console.WriteLine("El promedio de los números ingresados es: " + promedio);
        }
        else
        {
            Console.WriteLine("No se ingresaron números.");
        }

        Console.WriteLine("Programa terminado.");
    }
}