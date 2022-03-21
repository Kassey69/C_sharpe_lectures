/* Цикл for в методах
for (int = 0; i < 10; int++)
{
    Console.WriteLine(i);
}
*/
string Method4(int count, string text)
{
    string result = String.Empty; // string result = " " или тоже самое String.Empty
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, " asfr ");
Console.WriteLine(res);