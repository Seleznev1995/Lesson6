// public class Task1
// {
// public static void Main(string[] args)
// {

// char[,] charArray = new char[,] { { 'a', 'b' }, { 'c', 'd' } };

// string result = CreateStringFrom2DArray(charArray);

// Console.WriteLine(result);
// }

// public static string CreateStringFrom2DArray(char[,] array)
// {
// string result = "";

// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {

// result += array[i, j];
// }
// }
// return result;
// }
// }


// string input = "fBnHDPjjhAQ";

// string result = input.ToLower();

// Console.WriteLine(result);



public class Task3
{
public static void Main(string[] args)
{

string input = "шалаш";

bool isPalindrome = IsPalindrome(input);

Console.WriteLine(isPalindrome ? "Да" : "Нет");
}
public static bool IsPalindrome(string str)
{

string normalized = new
string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();

return normalized.SequenceEqual(normalized.Reverse());
}
}