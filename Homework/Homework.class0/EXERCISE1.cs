// See https://aka.ms/new-console-template for more information

//EXERCISE NUMBER 1

Console.WriteLine("Enter a number: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter another number: ");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter an operation: +, -, *, / ");
char operation = char.Parse(Console.ReadLine());

int result = 0;

switch (operation)
{
    case '+':
        result = number1 + number2;
        break;
        case '-':
        result = number1 - number2;
        break;
    case '*':
        result = number1 * number2;
        break;
    case '/':
        result = number1 / number2;
        break;
    default:
        Console.WriteLine("That operation does not exist!");
        break;

}

Console.WriteLine($"The result is: {result}");

//EXERCISE NUMBER 2

//Console.WriteLine("Enter four numbers to calculate their average:");

//Console.Write("Enter the first number: ");
//int num1 = int.Parse(Console.ReadLine());

//Console.Write("Enter the second number: ");
//int num2 = int.Parse(Console.ReadLine());

//Console.Write("Enter the third number: ");
//int num3 = int.Parse(Console.ReadLine());

//Console.Write("Enter the fourth number: ");
//int num4 = int.Parse(Console.ReadLine());

//int average = (num1 + num2 + num3 + num4) / 4;

//Console.WriteLine($"The average of {num1}, {num2}, {num3}, and {num4} is {average}");

////EXERCISE NUMBER 3 

//Console.WriteLine("Enter two numbers:");
//int numb1 = int.Parse(Console.ReadLine());
//int numb2 = int.Parse(Console.ReadLine());

//Console.WriteLine("Before swap:");
//Console.WriteLine("numb1 = " + numb1);
//Console.WriteLine("numb2 = " + numb2);

//int temporary = numb1;
//numb1 = numb2;
//numb2 = temporary;

//Console.WriteLine("After swap:");
//Console.WriteLine("numb1 = " + numb1);
//Console.WriteLine("numb2 = " + numb2);

//Console.ReadLine();