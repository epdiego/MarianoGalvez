using System;

internal class Program
{
    static void Main(string[] args)
    {
        int n1, n2, suma, resta, mlt, divi, residuo, opcion;
        opcion = 0;

        while (opcion != 6)
        {
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Residuo");
            Console.WriteLine("6. Salir \n");

            Console.WriteLine("Por favor elija una opcion: ");
            opcion = int.Parse(System.Console.ReadLine());

            switch (opcion)
                {
                 case 1:
                     Console.WriteLine("Por favor, ingrese el primer numero: ");
                     n1 = int.Parse(System.Console.ReadLine());
                     Console.WriteLine("Por favor, ingrese el segundo numero: ");
                     n2 = int.Parse(System.Console.ReadLine());

                     suma = n1 + n2;
                     Console.WriteLine("\nLa suma de los numeros es: " + suma + "\n");

                    break;

                 case 2:

                    Console.WriteLine("Por favor, ingrese el primer numero: ");
                    n1 = int.Parse(System.Console.ReadLine());
                    Console.WriteLine("Por favor, ingrese el segundo numero: ");
                    n2 = int.Parse(System.Console.ReadLine());

                    resta = n1 - n2;
                    Console.WriteLine("\nLa resta de los numeros es: "+resta+ "\n");


                    break;

                 case 3:

                    Console.WriteLine("Por favor, ingrese el primer numero: ");
                    n1 = int.Parse(System.Console.ReadLine());
                    Console.WriteLine("Por favor, ingrese el segundo numero: ");
                    n2 = int.Parse(System.Console.ReadLine());

                    mlt = n1 * n2;
                    Console.WriteLine("\nLa multiplicacion de los numeros es: " + mlt + "\n");

                    break;

                case 4:

                    Console.WriteLine("Por favor, ingrese el primer numero: ");
                    n1 = int.Parse(System.Console.ReadLine());
                    Console.WriteLine("Por favor, ingrese el segundo numero: ");
                    n2 = int.Parse(System.Console.ReadLine());

                    divi = n1 / n2;
                    Console.WriteLine("\nLa division de los numeros es: " + divi + "\n");
                    break;

                case 5:

                    Console.WriteLine("Por favor, ingrese el primer numero: ");
                    n1 = int.Parse(System.Console.ReadLine());
                    Console.WriteLine("Por favor, ingrese el segundo numero: ");
                    n2 = int.Parse(System.Console.ReadLine());

                    residuo = n1 % n2;
                    Console.WriteLine("\nEl residuo de la division de los numeros es: " + residuo + "\n");

                    break;

                case 6:

                    Console.WriteLine("\nGracias por usar la calculadora.");
                    Console.WriteLine("\nSaliendo... ");

                    break;

                default:

                    Console.WriteLine("\nEl caracter ingresado no es valido." + "\n");

                    break;
            }
        }

}   
}