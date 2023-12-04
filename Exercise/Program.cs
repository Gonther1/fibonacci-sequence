using Exercise;

internal class Program
{
    private static void Main(string[] args)
    {
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
    }
}