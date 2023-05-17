using RomanToInt;


class Program
{
    static void Main()
    {
        Console.WriteLine("Roman numerals: \nI = 1\nV = 5\nX = 10\nL = 50\nC = 100\nD = 500\nM = 1000");

        Console.WriteLine("Enter a Roman numeral: ");
        string RomanToNumeral = Console.ReadLine().ToUpper();

        int result = RomanToIntConverter.RomanToInt(RomanToNumeral);
        Console.WriteLine("The equivalent integer value is: " + result);
    }

}