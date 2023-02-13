string[] array1 = new string[] { "Hello", "2", "world", ":-)" };
string[] array2 = new string[] { "1234", "1567", "-2", "computer science" };
string[] array3 = new string[] { "Russia", "Denmark", "Kazan" };

Console.WriteLine($"[{string.Join(", ", GetShortStringArray(array1))}]");
Console.WriteLine($"[{string.Join(", ", GetShortStringArray(array2))}]");
Console.WriteLine($"[{string.Join(", ", GetShortStringArray(array3))}]");

string[] GetShortStringArray(string[] array)
{
    int lenght = array.Length;
    string[] result = new string[lenght];
    int count = 0;

    for (int i = 0; i < lenght; i++)
    {
        if (array[i].Length <= 3)
        {
            result[count] = array[i];
            count++;
        }
    }

    Array.Resize(ref result, count);

    return result;
}