using System;

class Program
{
    static void Main(string[] args)
    {
      List<int> numbers = new List<int>();

      int userNumber = -1;
      while (userNumber != 0)
      {
        Console.Write("Enter a number. Add 0 to quit: ");
        string userResponse = Console.ReadLine();
        userNumber = int.Parse(userResponse);

        /*Add all numbers except 0 to the list*/
        if (userNumber != 0)
        {
            numbers.Add(userNumber);
        }
      }
      /*Tp solve for the sum*/
      int sum = 0;
      foreach (int number in numbers)
      {
        sum += number;
      }
      Console.WriteLine($"Then sum is: {sum}");
      /*To find the average*/
      float average = ((float)sum) / numbers.Count;
      Console.WriteLine($"The average is: {average}");
      /*To know the maximum number*/
      int max = numbers[0];
      foreach (int number in numbers)
      {
        if (number > max)
        {
            max = number;
        }
      }
      Console.WriteLine($"The max is: {max}");
    }
}