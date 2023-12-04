# fibonacci-sequence


# Menu

Se hace uso de un Menu el cual permite acceder a los diferentes programas que el ejercicio propone

```c#
string text;
do 
{
    Console.Clear();
    Console.WriteLine("1-N numero de Fibonnacci");
    Console.WriteLine("2-Numero de la secuencia Fibonnacci");
    Console.WriteLine("3-N primeros numeros de Fibonnacci");
    Console.WriteLine("4-Salir");
    text=Console.ReadLine();
    switch (text)
    {
        case "1":
            MyFunctions.nNumberInFibonnacci();
            break;
        case "2":
            MyFunctions.NumberIntoFibonnacci();
            break;
        case "3":
            MyFunctions.SequenceFibonnaci();
            break;
        case "4":
            break;
        default:
            Console.Clear();
            Console.WriteLine("Opcion Invalida");
            Console.ReadLine();
            break;
    }
} while (text != "4");
```

# MyFunctions.cs File

Este archivo almacena las funciones con las que se hacen las diferentes opciones

# Funcion nNumberInFibonnacci()

```c#
public static void nNumberInFibonnacci()
{
    string text;
    int number;
    int a=0;
    int b=1;
    int temp;
    Console.Clear();
    Console.WriteLine("Ingrese el numero: ");
    text=Console.ReadLine();
    while (!int.TryParse(text, out number) || number < 2)
    {
        Console.Clear();
        Console.WriteLine("Ingrese un numero valido: ");
        text=Console.ReadLine();
    }
    for (int i = 0; i <= number; i++)
    {
        temp = a;
        a = b;
        b = temp + b;
        if (i+1 == number)
        {
            Console.Clear();
            Console.WriteLine($"F{number} = {a}");
            Console.ReadLine();
        }
    } 
}
```

# Funcion NumberIntoFibonnacci()

```c#
public static void NumberIntoFibonnacci()
{
    string text;
    int number;
    int a=0;
    int b=1;
    int temp;
    bool isFibo=false;
    Console.Clear();
    Console.WriteLine("Ingrese el numero: ");
    text=Console.ReadLine();
    while (!int.TryParse(text, out number) || number < 2)
    {
        Console.Clear();
        Console.WriteLine("Ingrese un numero valido: ");
        text=Console.ReadLine();
    }
    for (int i = 0; i < number; i++)
    {
        if (number == a)
            isFibo=true;
        temp = a;
        a = b;
        b = temp + b;
    }
    if (isFibo)
    {
        Console.Clear();
        Console.WriteLine($"{number} es numero de Fibonnacci");
        Console.ReadLine();
    }
    else 
    {
        Console.Clear();
        Console.WriteLine($"{number} no es numero de Fibonnacci");   
        Console.ReadLine();
    }
}
```

# Funcion SequenceFibonnaci()

```c#
public static void SequenceFibonnaci()
{
    string text;
    int number;
    int a=0;
    int b=1;
    int temp;
    Console.Clear();
    Console.WriteLine("Ingrese el numero: ");
    text=Console.ReadLine();
    while (!int.TryParse(text, out number) || number < 2)
    {
        Console.Clear();
        Console.WriteLine("Ingrese un numero valido: ");
        text=Console.ReadLine();
    }
    Console.Clear();
    Console.WriteLine($"Los primeros {number} numeros de Fibonnacci son: ");
    for (int i = 0; i < number; i++)
    {
        Console.Write($"{a} ");
        temp = a;
        a = b;
        b = temp + b;
    }
    Console.ReadLine();
}
```

