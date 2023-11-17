using System;
class Program
{
    static void Main(string[] args)
    {
        int num = 0;
        do
        {
            Console.WriteLine(num);
            num++;
        } while (num <= 50);



        int num2 = 30;
        do
        {
            Console.WriteLine(num2);
            num2--;
        } while (num2 >= -20);

        int num3 = 1;
        do
        {
            Console.WriteLine(num3);
            num3 *= 10;
        } while (num3 <= 1000000);


        int n;
        bool flag = false;
        do
        {
            Console.WriteLine("Enter an integer: ");
            flag = int.TryParse(Console.ReadLine(), out n);

            if (!flag)
            {
                Console.WriteLine("The value you entered is not valid");
            }
        } while (!flag);
        Console.WriteLine($"Good job! Your number is {n}");





    }
}

/*

        int num4;
        do
        {
            Console.WriteLine("Please enter an integer between 0 and 100");
            num4 = int.Parse(Console.ReadLine());
        } while (num4 < 0 || num4 > 100);
        Console.WriteLine($"Good job! Your number is {num4}");















































*/