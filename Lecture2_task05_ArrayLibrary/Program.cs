/*Перепишем код с прошлой задачи с использование генератора 
псевдо-случайных чисел и с использованием методов
1 этап) Мы возьмем метод, передадим в него массив 
и заполнить массив нужным количеством элементов 
2 этап) Мы опищем метод, который будет выводить все элементы по порядку 
3 этап) Мы превратим код поиска нужного нам индекса опять же в метод
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
}/*
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}*/
void PrintArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write(collection[index] + " ");
        index++;
    }
}
// тестируем наш метод
int[] array = new int[10]; // сначала мы определили массив из 10 элоементов
FillArray(array); // вызвали метод , который заполнил нам массив        
PrintArray(array);  // этот метод нам распечатал массив

// Если метод ничего не возвращает то он называется void методом


