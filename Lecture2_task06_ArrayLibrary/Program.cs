/*Опять решаем туже задачу но с использованием метода и находим определенный элемент find
*/
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
/* По сути эти методы одинаковые , изменяется только тело while
но для развития ума мы немного изменим , хотя не обязательно
void PrintArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write(collection[index] + " ");
        index++;
    }
}*/
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}
int Indexof(int[] collection, int find)
{
    int count = collection.Length;;
    int index = 0;
    //int position = 0;
    int position = -1; //(если числа 4 нет в 10 элементах то -1 
                      //будет означать то такой элемент не найден, вместо 0)
    while (index < count)
    {
       if(collection[index]==find)
       {
           position = index;
           break; // отключит программу сразу как найдет 1 элемент 4
       }
        index++;
    }
        return position;
}
// тестируем наш метод
int[] array = new int[10]; // сначала мы определили массив из 10 элоементов
FillArray(array); // вызвали метод , который заполнил нам массив        
PrintArray(array);  // этот метод нам распечатал массив
Console.WriteLine();
int pos = Indexof(array, 4);
Console.Write(pos);

// Если метод ничего не возвращает то он называется void методом


