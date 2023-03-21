// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please input a string: ");
String toCheck = Console.ReadLine();

char[] strArray = toCheck.ToCharArray();

Array.Reverse(strArray);

String reverseString = new string(strArray);


if (toCheck.Equals(reverseString))
{
    Console.WriteLine(toCheck + " is a palindrome.");
}
else
{
    Console.WriteLine(toCheck + " is not a palindrome.");
}
