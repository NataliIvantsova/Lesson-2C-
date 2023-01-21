// нахождение max из 9 чисел через функции
// классический подход

// int a1 = 15;
// int b1 = 12;
// int c1 = 1;
// int a2 = 88;
// int b2 = 17;
// int c2 = 8;
// int a3 = 6;
// int b3 = 655;
// int c3 = 18;

// int max = a1;
// if(b1 > max ) max = b1;
// if(c1 > max ) max = c1;

// if(a2 > max ) max = a2;
// if(b2 > max ) max = b2;
// if(c2 > max ) max = c2;

// if(a3 > max ) max = a3;
// if(b3 > max ) max = b3;
// if(c3 > max ) max = c3;

// System.Console.WriteLine($"{max}");

// через функцию

// int Max(int arg1, int arg2, int arg3);// максимум три аргумента
// {
//     int result = arg1;
//     if(arg2> result) result = arg2;
//     if(arg3> result) result = arg3;
//     return result; // возвращает максимум
// } 

// Ищем максимум из три аргумента

int Max(int arg1, int arg2, int arg3)  // целочисленный возвращаемый тип данных ИНТ с именем фукции МАКС (тип данных размер 1, ...)
{
    int result = arg1;
    if(arg2> result) result = arg2;
    if(arg3> result) result = arg3;
    return result; // возвращает максимум
} 


int a1 = 15;
int b1 = 12;
int c1 = 1;
int a2 = 88;
int b2 = 17;
int c2 = 8;
int a3 = 6;
int b3 = 655;
int c3 = 18;

// int max1 = Max(a1, b1, c1); //результатом работы F max будет является максимальное из трех чисел a1.b1.c1 мы получим максимум из первой тройки игроков
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

int max = Max(
    Max(a1, b1, c1), 
    Max(a2, b2, c2), 
    Max(a3, b3, c3));
System.Console.WriteLine(max);
