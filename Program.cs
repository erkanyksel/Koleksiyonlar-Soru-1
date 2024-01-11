using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList primeNumber = new ArrayList();
        ArrayList compositeNumber = new ArrayList();

        Console.WriteLine("Please Enter 20 numbers.");

        Calculations.EnterNumbers(primeNumber, compositeNumber);

        Console.WriteLine("****Sorted Lists****");

        Console.Write("Prime numbers = ");
        Calculations.PrintSortedArray(primeNumber);

        Console.Write("\nComposite numbers = ");
        Calculations.PrintSortedArray(compositeNumber);

        Console.WriteLine("\n\n****Total Number Of Lists****");

        Console.Write("Prime numbers = ");
        Calculations.PrintArrayCount(primeNumber);

        Console.Write("\nComposite numbers = ");
        Calculations.PrintArrayCount(compositeNumber);

        Console.WriteLine("\n\n****Avarage of numbers****");

        Console.Write("Avarage of prime numbers = ");
        Calculations.PrintArrayAverage(primeNumber);

        Console.Write("\nAvarage of composite numbers = ");
        Calculations.PrintArrayAverage(compositeNumber);

    }
}

static class Calculations
{
    public static void EnterNumbers(ArrayList primeNumbers, ArrayList compositeNumbers)
    {
        for (int i = 0; i < 20; i++)
        {

            Console.WriteLine("number " + i + " enter");
            string numberstr = Console.ReadLine();
            if (!int.TryParse(numberstr, out int number) || number < 0 || primeNumbers.Contains(number) || compositeNumbers.Contains(number))
            {
                Console.WriteLine("invalid input Error");
                Environment.Exit(0);
            }
            else if (Calculations.isPrime(number))
                primeNumbers.Add(number);
            else
                compositeNumbers.Add(number);


        }
    }

    public static bool isPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static void PrintSortedArray(ArrayList list)
    {
        list.Sort();
        list.Reverse();
        foreach (var item in list)
            Console.WriteLine(item);
    }

    public static void PrintArrayCount(ArrayList list)
    {
        Console.WriteLine(list.Count);
    }

    public static void PrintArrayAverage(ArrayList list)
    {
        int itemCount = list.Count;
        int itemTotal = 0;

        foreach (var item in list)
        {
            itemTotal += (int)item;
        }

        Console.WriteLine(itemTotal / itemCount);
    }

}