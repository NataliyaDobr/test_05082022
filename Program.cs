string[] ArrayString1 = new string[7] {"hellow", "2", "world", "1234", "567","yt","nat"};
string[] ArrayString2 = new string[ArrayString1.Length];

void NewArray(string[] array1, string[] array2)
{
    for (int i = 0; i < ArrayString1; i++)
    {
    if(ArrayString1[i].Length <= 3)
        {
        ArrayString2[count] = array1[i];
        }
    }
}