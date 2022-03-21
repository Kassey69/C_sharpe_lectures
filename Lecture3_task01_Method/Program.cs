//Методы
//Вид1 - Методы которые ничего не возвращают и ничего не принимают
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1(); // так вызывается метод

//Вид2 Методы которые ничего не возвращают, но могут принимать какие то аргументы
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения"); // обычный текст      
Method2(msg: "Текст сообщения");// именованный аргумент, указано к какому аргументу какое значение мы хотим указать

void Method21(string msg, uint count)
{
    int i = 0;
    while( i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Текст", 4); //сколько раз я хочу увидеть это сообщение через запятую, (как и в степенях)
Method21(msg: "Текст", count: 4); // мы можем явно указывать какому аргументу какое значение мы хотим присвоить


// Вид3 Методы что то возвращают , но ничего не принимают
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

//Вид4 Методы которые , что то принимают и что то возвращают
string Method4(int count, string text)
{
    int i = 0;
    // string result = " " или тоже самое String.Empty
    string result =  String.Empty;
    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, " asfr ");
Console.WriteLine(res);