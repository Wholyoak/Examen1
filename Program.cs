// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography;
string CalcularNoPoCero(int numero)
{
    string Texto = string.Empty;
    //La condicion
    if (numero == 0)
    {
        Texto="\n\tSu Numero es \b Cero (0) \b.";
    }
    else if (numero >= 1)
    {
        Texto="\n\tSu numero '" + numero + "' es \b Positivo \b.";
    }
    else if (numero <= -1)
    {
        Texto="\n\tSu numero '" + numero + "' es \b Negativo \b.";
    }
    return Texto;
}
void ProcesarOpcion1()
{
    //Varibles
    int num;


    //Explicacion del ejercicio
    Console.WriteLine("000  \t\tSaber si el numero es Positivo, Negativo, Cero(0)                        000");
    Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
    bool salirOp1 = false;
    int Respuesta = 0;
    while (!salirOp1)
    {
       
        //Imprimiendo mensaje, el cual pide un dato
        Console.Write("\n\tIngrese un Numero: ");
        num = Int32.Parse(Console.ReadLine());
        Console.Write(CalcularNoPoCero(num));


        Console.WriteLine("\n\t\tDeseas ingresar otro numero?");
        Console.WriteLine("\n\t\tSi = 1");

        Respuesta= Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(salirOp1);
        if (Respuesta != 1)  salirOp1 = true;

        //Console.WriteLine(salirOp1);

    } ;
    
    //Detener el programa, esperando que se presione una tecla
    Console.Write("\n\n\tPresione una tecla para continuar . . .");
    Console.ReadKey();
}
string CalcularNombreDiaSemana(int numero)
{
    string dia=string.Empty;
    switch (numero)
    {
        case 1: dia = "Lunes"; break;
        case 2: dia = "Martes"; break;
        case 3: dia = "Miercoles"; break;
        case 4: dia = "Jueves"; break;
        case 5: dia = "Viernes"; break;
        case 6: dia = "Sabado"; break;
        case 7: dia = "Domingo"; break;
        default:
            Console.WriteLine("\t\tEl numero ingresado NO corresponde a ningun día de la semana");
            dia = "Ninguno";
            break;
    }
    return dia;
}
void ContinuarProcesarOpcion2()
{
bool salirOp1 = false;
    
        int num = 0;
        string dia = string.Empty;
  


        //Imprimiendo mensaje, el cual pide un dato
        Console.Write("\n\tIngrese un Numero de día: ");
        num = Int32.Parse(Console.ReadLine());
        Console.Write("\n\tEl numero de día ingresado es: " + CalcularNombreDiaSemana(num));

}

void ProcesarOpcion2()
{
    bool salirOp1 = false;
    int Respuesta = 0;
    //Explicacion del ejercicio
    Console.WriteLine("000  \t\tImprimir un mensaje según el día de la semana ingresado por el usuario   000");
    Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
    while (!salirOp1)
    {
        ContinuarProcesarOpcion2();

        Console.WriteLine("\n\t\tDeseas ingresar otro numero?");
        Console.WriteLine("\n\t\tSi = 1");

        Respuesta = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(salirOp1);
        if (Respuesta != 1) salirOp1 = true;
    }
}

double CalcularOpcion3()
{ 
    Double Resultado=0;
 for (int i = 0; i < 100; i++)
    {
        Resultado = (Resultado + i); }
    return Resultado;
}
void ProcesarOpcion3()
{
  
        int num = 0;

    //Explicacion del ejercicio
   
    Console.WriteLine("000  \t\tCalcular la suma de los primeros 100 números naturales                   000");
    Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
    Console.WriteLine("    ");
    //Imprimiendo mensaje, el cual pide un dato
    Console.Write("\n\tLa respuesta de la suma es: " + CalcularOpcion3() );
    //Detener el programa, esperando que se presione una tecla
    Console.Write("\n\n\tPresione una tecla para continuar . . .");
    Console.ReadKey();

}
void EscribirNumeros()
{

Console.Write("\n\tIngrese un Numero: ");
int num = 0;
    //Ingresando valor
    num = Int32.Parse(Console.ReadLine());
    //Imprimiendo mensaje, el cual pide un dato
    
    for (int i = 1; i < num+1; i++)
    {
        Console.Write(i+ "\r\n"); ;
    }
}

void ProcesarOpcion4()
{
//Explicacion del ejercicio
    Console.WriteLine("000  \t\tImprimir todos los números desde 1 hasta el número ingresado por el usuario 000");
    Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
    Console.WriteLine("    ");

    EscribirNumeros();

}

double CalcularAreaCirculo(double radio )
{
    
    double area = Math.PI * Math.Pow(radio, 2);

    return area; 
}
void ProcesarOpcion5()
{
    //Explicacion del ejercicio
    Console.WriteLine("000 \t\tCalcular el área de un círculo utilizando el radio ingresado por el usuario   000");
    Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
    Console.WriteLine("    ");
    bool salirOp1 = false;
    int Respuesta = 0;

    while (!salirOp1)
    {
        Console.WriteLine("Ingrese el radio del círculo:");

        double radio = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("El área del círculo es: " + CalcularAreaCirculo(radio));


        Console.WriteLine("\n\t\tDeseas realizar otro calculo?");
        Console.WriteLine("\n\t\tSi = 1");

        Respuesta = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(salirOp1);
        if (Respuesta != 1) salirOp1 = true;

        //Console.WriteLine(salirOp1);

    };


}

void MostrarArray()
{
    int[] array2 = [1, 2, 3, 4, 5, 6, 8, 9, 10];
    for (int i = 0; i < 9; i++)
    {
        //Mostrar el Array
        Console.Write(array2[i] + "\r\n"); ;
    }


}
void ProcesarOpcion6()
{    //Explicacion del ejercicio
  
    Console.WriteLine("000  \t\tMostrar los elementos de un arreglo unidimensional predefinido           000");
    Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
    Console.WriteLine("    ");

    MostrarArray();


}
void MostrarNombres()

{
 List<string> Nombres = new List<string>(); 
    Nombres.Add("Julio");
    Nombres.Add("Gian Carlo");
    Nombres.Add("Maria Teresa");
    Nombres.Add("Wilmer");
    Nombres.Add("Joaquin");
    Nombres.Remove("Marialejandra");

    foreach (var name in Nombres)
    {
        Console.WriteLine($"Me llamo {name}!");
    }
}

void ProcesarOpcion7()
{ //Explicacion del ejercicio
    Console.WriteLine("000  \t\tMostrar nombres de personas almacenados en una lista predefinida         000");
    Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
    Console.WriteLine("    ");


    MostrarNombres();
}
void ProcesarOpcion8()
{
    // Salir de la aplicación.
    Environment.Exit(0);
}
void MostrarCabecera()
{
    // Mostrar la Cabecera de la aplicación.
    Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
    Console.WriteLine("000---------------------------  1er Examen (05-04-2024)  --------------------------------000");
    Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
}



//Comienza el programa*******************************************************************+
bool salir = false;

MostrarCabecera();

while (!salir)
{

    try
    {
        
        Console.WriteLine("   ");
        Console.WriteLine("000---------------------------  SELECCIONAR UNA OPCIÓN   --------------------------------000");
        Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
        Console.WriteLine("000   1. Determinar si un número ingresado por el usuario es positivo                    000");
        Console.WriteLine("000   2. Imprimir un mensaje según el día de la semana ingresado por el usuario          000");
        Console.WriteLine("000   3. Calcular la suma de los primeros 100 números naturales                          000");
        Console.WriteLine("000   4. Imprimir todos los números desde 1 hasta el número ingresado por el usuario     000");
        Console.WriteLine("000   5. Calcular el área de un círculo utilizando el radio ingresado por el usuario.    000");
        Console.WriteLine("000   6. Mostrar los elementos de un arreglo unidimensional predefinido.                 000");
        Console.WriteLine("000   7. Mostrar nombres de personas almacenados en una lista predefinida.               000");
        Console.WriteLine("000   8. Salir                                                                           000");
        Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");

     // Console.WriteLine("000                              Has elejido la opción 1                                 000");
        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
                Console.WriteLine("000                              Has elejido la opción 1                                 000"); ;
                ProcesarOpcion1();
                break;

            case 2:
                Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
                Console.WriteLine("000                              Has elejido la opción 2                                 000"); ;
                ProcesarOpcion2();
                break;

            case 3:
                Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
                Console.WriteLine("000                              Has elejido la opción 3                                 000"); ;
                ProcesarOpcion3();
                break;
            case 4:
                Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
                Console.WriteLine("000                              Has elejido la opción 4                                 000"); ;
                ProcesarOpcion4();
                break;
            case 5:
                Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
                Console.WriteLine("000                              Has elejido la opción 5                                 000"); ;
                ProcesarOpcion5();
                break;
            case 6:
                Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
                Console.WriteLine("000                              Has elejido la opción 6                                 000"); ;
                ProcesarOpcion6();
                break;
            case 7:
                Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
                Console.WriteLine("000                              Has elejido la opción 7                                 000"); ;
                ProcesarOpcion7();
                break;
            case 8:
                Console.WriteLine("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
                Console.WriteLine("000                              Has elejido la opción 8                                 000"); ;
                salir = true;
                break;
            default:
                Console.WriteLine("Elige una opcion entre 1 y el 8");
                break;
        }

    }
    catch (FormatException e)
    {
        Console.WriteLine(e.Message);
    }
}