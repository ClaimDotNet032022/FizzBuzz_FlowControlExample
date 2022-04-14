// Print the numbers from 1 to 100
// EXCEPT:
// * If the number is divisible by 3,
//      print the word "Fizz" and NOT
//      the number.
// * If the number is divisible by 5,
//      print the word Buzz and NOT
//      the number.
// BUT if the number is divisible by
//      BOTH 3 and 5, then instead
//      print the word "FizzBuzz".

int max = 100;
for(int n = 1; n <= max; ++n)
{
    if (n % 3 == 0 && n % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (n % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (n % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(n);
    }
}