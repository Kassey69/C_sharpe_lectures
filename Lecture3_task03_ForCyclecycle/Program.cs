/* Методы Цикл в цикле
for(int i=0; i< 10; i++)
{
    for(int j=0; j<10; j++)
    {
        Console.WriteLine(i*j);
    }
    Console.WriteLine();
}
*/

//string res = Method4(10, "z");
//Console.WriteLine(res);

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}"); 
        // это тоже самое что и раньше с морем кавычек только выделение
        //вывеврнутые кавычки наоборот, 
        //Console.WriteLine(i + " x " + j + " = " + (i * j));
    }
    Console.WriteLine();
}

