public class menu
{
    private int seleccion;
    private int seleccionEst;
    private int cantidadApuesta;
    private int apuesta;
    private int resultadoRuleta;
    private int cambioBalance;
    private int sumaCambioBalance;
    private int balance;
    private juego JuegoAzar;
    private ruleta Ruleta;


    public menu()
    {
        Ruleta = new ruleta();
        cantidadApuesta = 1;
        balance = 300;
        JuegoAzar = new juego();
        seleccion = -1;
        seleccionEst = -1;

        Console.WriteLine("Bienvenido al juego de la Ruleta. Ingrese el tipo de apuesta que quiere realizar.\n1. Por numero.\n2. Por color.\n3. Por par/impar.\n4. Consultar estadísticas.\n5. Salir.");
        while (seleccion != 5) {
            seleccion = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            if (seleccion == 1)
            {
                Console.WriteLine("Seleccionó apostar por un número en específico.\n");
                while (cantidadApuesta % 10 != 0)
                {
                    Console.WriteLine("Ingrese la cantidad a apostar en múltiplos de 10.\n");
                    cantidadApuesta = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Ingrese el número al que le desea apostar\n");

                apuesta = int.Parse(Console.ReadLine());

                resultadoRuleta = JuegoAzar.tirar();
                Console.WriteLine("El resultado de la ruleta es: {0}", resultadoRuleta);

                cambioBalance = JuegoAzar.evaluarApuesta(apuesta, resultadoRuleta, 0, cantidadApuesta);
                if (cambioBalance >= 0)
                {
                    Console.WriteLine("GANÓ");
                }
                else
                {
                    Console.WriteLine("PERDIÓ");
                }
                sumaCambioBalance += cambioBalance;
                balance = balance + cambioBalance;
                cantidadApuesta = 1;

            }

            if (seleccion == 2)
            {
                Console.WriteLine("Seleccionó apostar por un color.\n");
                while (cantidadApuesta % 10 != 0)
                {
                    Console.WriteLine("Ingrese la cantidad a apostar en múltiplos de 10.\n");
                    cantidadApuesta = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Ingrese el color al que le desea apostar\n1. Rojo.\n2. Negro.\n");

                apuesta = int.Parse(Console.ReadLine());

                resultadoRuleta = JuegoAzar.tirar();

                Console.WriteLine("El resultado de la ruleta es: {0}", resultadoRuleta);

                cambioBalance = JuegoAzar.evaluarApuesta(apuesta, resultadoRuleta, 1, cantidadApuesta);
                if (cambioBalance >= 0)
                {
                    Console.WriteLine("GANÓ");
                }
                else
                {
                    Console.WriteLine("PERDIÓ");
                }
                sumaCambioBalance += cambioBalance;
                cantidadApuesta = 1;
                balance = balance + cambioBalance;

            }

            if (seleccion == 3)
            {
                Console.WriteLine("Seleccionó apostar por un par o impar.\n");
                while (cantidadApuesta % 10 != 0)
                {
                    Console.WriteLine("Ingrese la cantidad a apostar en múltiplos de 10.\n");
                    cantidadApuesta = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Ingrese el número indicando si le quiere apostar a que saldrá un par o impar.\n1. Impar.\n2. Par.\n");

                apuesta = int.Parse(Console.ReadLine());

                resultadoRuleta = JuegoAzar.tirar();
                Console.WriteLine("El resultado de la ruleta es: {0}", resultadoRuleta);

                cambioBalance = JuegoAzar.evaluarApuesta(apuesta, resultadoRuleta, 2, cantidadApuesta);
                if (cambioBalance >= 0)
                {
                    Console.WriteLine("GANÓ");
                }
                else
                {
                    Console.WriteLine("PERDIÓ");
                }
                sumaCambioBalance += cambioBalance;
                balance = balance + cambioBalance;
                cantidadApuesta = 1;
            }

            if (seleccion == 4)
            {
                while (seleccionEst != 9)
                {
                    Console.WriteLine("\n1. Ver la cantidad de resultados rojos.\n2.Ver cantidad de resultados negros.\n3.Ver cantidad de resultados pares.\n4.Ver cantidad de resultados impares.\n5.Ver cantidad de tiros realizados.\n6.Ver balance.\n9. Salir.");
                    seleccionEst = int.Parse(Console.ReadLine());
                    if (seleccionEst == 1)
                    {
                        Console.WriteLine("La cantidad de rojos jugados es: {0}.\n", JuegoAzar.CantidadRojos);
                    }
                    if (seleccionEst == 2)
                    {
                        Console.WriteLine("La cantidad de negros jugados es: {0}.\n", JuegoAzar.CantidadNegros);
                    }
                    if (seleccionEst == 3)
                    {
                        Console.WriteLine("La cantidad de pares jugados es: {0}.\n", JuegoAzar.CantidadPares);
                    }
                    if (seleccionEst == 4)
                    {
                        Console.WriteLine("La cantidad de impares jugados es: {0}.\n", JuegoAzar.CantidadImpares);
                    }
                    if (seleccionEst == 5)
                    {
                        Console.WriteLine("La cantidad de impares jugados es: {0}.\n", JuegoAzar.CantidadTiros);
                    }
                    if (seleccionEst == 6)
                    {
                        Console.WriteLine("Su balance es: {0}.\n", balance);
                    }

                    if(seleccionEst == 7)
                    {
                        JuegoAzar.elementoMasRepetido();
                    }
                    

                }
                seleccionEst = -1;
            }

            if (seleccion != 5)
            {
                Console.WriteLine("Ingrese el tipo de apuesta que quiere realizar.\n1. Por numero.\n2. Por color.\n3. Por par/impar.\n4. Consultar estadísticas.\n5. Salir.");
            }

            if (balance <= 0)
            {
                Console.WriteLine("\n\nSe acabó su balance para apostar.");
                break;
            }
        }

        Console.WriteLine("El monto generado en las apuestas fue de: {0}", sumaCambioBalance);
        
    }
}