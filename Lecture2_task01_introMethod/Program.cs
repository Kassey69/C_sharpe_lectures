// Поищем максимум из 9 чисел
// Код программы классический подход  
    int a1 = 15;
    int b1 = 21;
    int c1 = 30;
    int a2 = 50;
    int b2 = 50;
    int c2 = 30;   
    int a3 = 80;
    int b3 = 44;
    int c3 = 99;
    int max = a1;
    if (b1 > max) max = b1;
    if (c1 > max) max = c1;
    if (a2 > max) max = a2;
    if (b2 > max) max = b2;
    if (c2 > max) max = c2;
    if (a3 > max) max = a3;
    if (b3 > max) max = b3;
    if (c3 > max) max = c3;
    Console.WriteLine(max);
