using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number:");
        string valuefromuser = Console.ReadLine();

        int x = int.Parse(valuefromuser);
        int y = 2;
        int z = 5;


        if (!(x < y || x < z) && y < z)
        {
            Console.WriteLine("x is greater than y");
        }
        else if (x == y)
        {
            Console.WriteLine("x is Less than y");
        }
        else
        {
            Console.WriteLine("x is equal to y");
        }

    }

}