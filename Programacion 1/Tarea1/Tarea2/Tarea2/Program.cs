using System;

internal class Program
{
    static void Main(string[] args)
    {
        int n1, n2, suma, resta, mlt, divi, residuo, opcion;
        opcion = 0;

        do
        {
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Residuo");
            Console.WriteLine("6. Factorial");
            Console.WriteLine("7. Fibonacci");
            Console.WriteLine("8. Salir \n");

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
                    Console.WriteLine("\nIngrese un valor: ");
                    n1 = int.Parse(System.Console.ReadLine());
                    int factorial = 1;

                    for (int i = 1; i <= n1; i++)
                    {
                        factorial *= i;
                    }

                    Console.WriteLine("El valor factorial es: " + factorial);

                    break;

                case 7:
                    int f1, f2, f3;
                    Console.WriteLine("\nIngrese un valor: ");
                    n1 = int.Parse(System.Console.ReadLine());
                    f1 = 0;
                    f2 = 1;
                    f3 = f1 + f2;

                    if (n1 == 0)
                    {
                        Console.WriteLine("El valor de la serie fibonacci para el numero ingresado es: " + f1);
                    }
                    else if (n1 == 1)
                    {
                        Console.WriteLine("El valor de la serie fibonacci para el numero ingresado es: " + f2);
                    }
                    else
                    {
                        for (int i =2 ; i <= n1; i++)
                        {
                            f3 = f1 + f2;
                            f1 = f2;
                            f2 = f3;
                        }

                        Console.WriteLine("El valor de la serie fibonacci para el numero ingresado es: " + f2);
                    }
                    break;

                case 8:

                    Console.WriteLine("\nGracias por usar la calculadora.");
                    Console.WriteLine("\nSaliendo... ");

                    break;

                default:

                    Console.WriteLine("\nEl caracter ingresado no es valido." + "\n");

                    break;
            }

            Console.WriteLine("\nDesea continuar?: \n");

            Console.WriteLine("Oprima 1: SI");
            Console.WriteLine("Oprima 0: NO");
            opcion = int.Parse(Console.ReadLine());

            if(opcion == 0)
            {
                opcion = 8;
            }

            Console.Clear();
        } while (opcion != 8);

        Console.WriteLine("\nGracias por usar la calculadora.");
        Console.WriteLine("\nSaliendo... ");

    }
}