
void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

string[] CreateHandwrittenArray(int m)
{
    string[] array = new string[m];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите значение {i + 1}-го элемента: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void CheckedForLength(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}

Console.WriteLine("Введите количество символов в массиве: ");
int countElements = Convert.ToInt32(Console.ReadLine());

string[] mass = CreateHandwrittenArray(countElements);
string[] resultMass = new string[mass.Length];
CheckedForLength(mass, resultMass);
Console.WriteLine();
PrintArray(mass);
Console.Write(" -> ");
PrintArray(resultMass);