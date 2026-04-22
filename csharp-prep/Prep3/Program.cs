using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        foreach (string color in colors)
        {
            Console.WriteLine(color);
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }


        string response;

        do. 
        {
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        } while (response == "yes");

        Console.WriteLine("Hello Prep3 World!");
        


    }
}