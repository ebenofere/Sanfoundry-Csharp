//C# Program to Check whether the Entered Number is Even or Odd

//int i;
//Console.Write("Enter a number : ");
//i = int.Parse(Console.ReadLine());
//if (i % 2 == 0)
//{
//    Console.Write("the entered number is an even number");
//    Console.Read();
//}
//else
//{
//    Console.Write("the entered number is an odd number");
//    Console.Read();
//}




//This is a C# Program to generate odd numbers within a range.

//IEnumerable<int> oddNums = Enumerable.Range(1, 21).Where(x => x % 2 != 0);
//foreach (int n in oddNums)
//{
//    Console.WriteLine(n);
//}
//Console.ReadLine();




//This is a C# Program to generate numbers sequence of numbers within a range.
//IEnumerable<int> GenerateNumber = new List<int> { 1, 2, 3, 4, 5, 6 };
//foreach (int item in GenerateNumber)
//{
//    Console.WriteLine(item);
//}




//This is a C# Program to generate numbers sequence of numbers within a range.
//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

//// Examples of using Enumerable extension methods
//var evenNumbers = numbers.Where(n => n % 2 == 0);
//var squaredNumbers = numbers.Select(n => n * n);

//foreach (var item in evenNumbers)
//{
//    Console.WriteLine(item);
//}

//foreach (var item in squaredNumbers)
//{
//    Console.WriteLine(item);
//}




//C# Program to Accept a Number from the user and Display it if it is Positive
//Console.WriteLine("Enter a number : ");
//int number = Convert.ToInt32(Console.ReadLine());
//if (number > 0)
//{
//    Console.WriteLine("the entered number is positive");
//}
//else if (number == 0 )
//{
//    Console.WriteLine("the entered number is 0");
//}
//else
//{
//    Console.WriteLine("the entered number is negative");
//}
//Console.ReadLine();




//C# Program to Find Greatest among 2 numbers
//int a, b;
//Console.WriteLine("Enter the first number : ");
//a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter the second number : ");
//b = Convert.ToInt32(Console.ReadLine());
//if (a > b)
//{
//    Console.WriteLine("the first number is greater");
//}
//else if (b > a)
//{
//    Console.WriteLine("the second number is greater");
//}
//else
//{
//    Console.WriteLine("Both numbers are equal");
//}




//C# Program to Swap two Numbers
//int num1, num2, temp;
//Console.Write("\nEnter the first number : ");
//num1 = int.Parse(Console.ReadLine());
//Console.Write("\nEnter the second number : ");
//num2 = int.Parse(Console.ReadLine());

//temp = num1;
//num1 = num2;
//num2 = temp;

//Console.Write("\nAfter swapping, here are the results: ");
//Console.Write($"\nFirst number: {num1}");
//Console.Write($"\nSecond number: {num2}");
//Console.Read();




//C# Program to Find whether the Number is Divisible by 2
//int n;
//Console.WriteLine("Enter a number : ");
//n = int.Parse(Console.ReadLine());
//if (n % 2 == 0)
//{
//    Console.WriteLine("the entered number is divisible by 2");
//}
//else
//{
//    Console.WriteLine("the entered number is not divisible by 2");
//}
//Console.ReadLine();




//C# Program to Print the Sum of all the Multiples of 3 and 5 within a range of 100
//int a, b, i, Sum = 0;
//for (i = 1; i < 100; i++)
//{
//    a = i % 3;
//    b = i % 5;
//    if (a == 0 || b == 0)
//    {
//        Console.Write($"{i}\t");
//        Sum = Sum + i;
//    }
//    Console.WriteLine($"\nThe sum of all the multiples of 3 or 5 below 100 : {Sum}");
//    Console.Read();
//}




//C# Program to Print all the Multiples of 17 which are Less than 100
//int a, i;
//Console.WriteLine("The multiples of 17 are : ");
//for (i = 1; i < 100; i++)
//{
//    a = i % 17;
//    if (a == 0)
//    {
//        Console.WriteLine(i);
//    }
//}
//Console.Read();




//C# Program to Get a Number and Display the Sum of the Digits 
//int num, r, sum = 0;
//Console.WriteLine("Enter a number : ");
//num = int.Parse(Console.ReadLine());
//while (num != 0)
//{
//    r = num % 10;
//    num = num / 10;
//    sum += r;
//}
//Console.WriteLine($"The sum of these digits is {sum}");
//Console.ReadLine();




//C# Program to Find Sum of Digits of a Number using Recursion
//int num, result;
//Pro pg = new Pro();
//Console.WriteLine("Enter the number : ");
//num = int.Parse(Console.ReadLine());
//result = pg.sum(num);
//Console.WriteLine($"Sum of digits in {num} is {result}");
//Console.ReadLine();




//C# Program to Get a Number and Display the Number with its Reverse
//int num, reverse = 0;
//Console.WriteLine("Enter a number : ");
//num = int.Parse(Console.ReadLine());
//while (num != 0)
//{
//    reverse = reverse * 10;
//    reverse = reverse + (num % 10);
//    num = num / 10;
//}
//Console.WriteLine($"Reverse of the entered number is : {reverse}");
//Console.ReadLine();