// Перепишем задачу 0030 через генератор псевдослучайных чисел
void FillArrya(int [] collection)// void ничего не возвравращающий метод оператор не содержит return
// FillArrya название нашего метода
// collection название массива
{
    int length = collection.Length; // ищем длину массива (переменная length) через инструмент Length
    int index = 0;// позиция индекса прдположим нулевая
    while(index<length)
    {
        collection[index] = new Random().Next(1, 10); // обратиться к числу collectione 
        // на позицию index и положить туда новое случайное число от 1 до 10
        index++;
    }

} 

void PrintArrya(int[] col)// метод который будет печатать массив
{
    int count = col.Length; //количество элементов массива col
    int position = 0;
    while(position<count)
    {
        System.Console.WriteLine(col[position]);//будем выводить на экран(консоль) значение текущего элемента
        position++;
    }
  
}

int[] array = new int[10];// массив arrya ссодержит 10 элементов || 
//new int[10] -  создай новый массив в котором будет 10 элементов/ 
// и по умолчанию он заполнен нулями // выше преобразование через метод этих нулей в числа

FillArrya(array);//таким образом мы определили массив из 10 элементов
//FillArrya(array) вызывает создание массива из 10 чисел
PrintArrya(array); //PrintArrya(array); печатает массива из 10 чисел

 