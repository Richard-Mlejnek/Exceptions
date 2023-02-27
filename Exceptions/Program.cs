namespace Exceptions;

public class MyException : Exception
{
    public MyException() : base(message:"Pokazilo se to") {}
}

public static class Program
{
    static void Main()
    {
        int[] arr = new int[5];
        int pos = 10;

        try
        {
            arr[pos] = 5;
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Index pole je vetsi nez kapacita pole");
        }

        Console.WriteLine("Program dal bezi");
        
        try
        {
            if (pos >= arr.Length)
            {
                throw new MyException();
            }
        }
        catch (MyException e)
        {
            Console.WriteLine(e);
        }
        
        Console.WriteLine("Program nespadnul a skonci");
    }
}