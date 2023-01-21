// нахождение max из 9 чисел через массив



int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
// индексы эл  0,1,2,3,4,5,6,7,8
int[] array = { 15, 2, 37, 4, 55, 76, 7, 58, 9 };// тип данных массива[] наименование массива {значаения массива }

int result = Max( //обращаемся к значениям массива через индекс значение массива 
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
   Max(array[6], array[7], array[8])
   );

System.Console.WriteLine(result);
