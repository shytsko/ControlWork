string[] sourceStringArray = GetArray(0);

int lenghtResultArray = 0;
for (int sourceIndex = 0; sourceIndex < sourceStringArray.Length; sourceIndex++)
{
    if (sourceStringArray[sourceIndex].Length <= 3)
    {
        lenghtResultArray++;
    }
}

string[] resultStringArray = new string[lenghtResultArray];
for (int sourceIndex = 0, resultIndex = 0; sourceIndex < sourceStringArray.Length; sourceIndex++)
{
    if (sourceStringArray[sourceIndex].Length <= 3)
    {
        resultStringArray[resultIndex++] = sourceStringArray[sourceIndex];
    }
}

Console.WriteLine("Исходный массив:");
Console.WriteLine(PrintArray(sourceStringArray));
Console.WriteLine();
Console.WriteLine("Результат:");
Console.WriteLine(PrintArray(resultStringArray));

string[] GetArray(int numberArray)
{
    if (numberArray == 1)
    {
        return new string[] { "hello", "2", "world", ":-)" };
    }
    else if (numberArray == 2)
    {
        return new string[] { "1234", "1567", "-2", "computer science" };
    }
    else if (numberArray == 3)
    {
        return new string[] { "Russia", "Denmark", "Kazan" };
    }
    else if (numberArray == 4)
    {
        return new string[] { };
    }
    else
    {
        string[] array = new string[new Random().Next(0, 10)];
        for (int i = 0; i < array.Length; i++)
        {
            char simbol = Convert.ToChar(new Random().Next(Convert.ToInt32('a'), Convert.ToInt32('z') + 1));
            array[i] = new string(simbol, new Random().Next(1, 10));
        }
        return array;
    }
}

string PrintArray(string[] array)
{
    string output = "[ ";

    for (int i = 0; i < array.Length; i++)
    {
        output += array[i];
        if (i < array.Length - 1)
        {
            output += ", ";
        }
    }
    output += " ]";

    return output;
}