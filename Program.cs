string[] ArrayString1 = new string[7] {"hellow", "2", "world", "1234", "567","yt","nat"};
string[] ArrayString2 = new string[ArrayString1.Length];

void NewArray(string[] array1, string[] array2)
{
    for (int i = 0; i < ArrayString1.Length; i++)
    {
    if(ArrayString1[i].Length <= 3)
        {
        ArrayString2[i] = array1[i];
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
NewArray(ArrayString1, ArrayString2);
PrintArray(ArrayString2);