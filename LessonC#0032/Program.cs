// Перепишем задачу 0030 через генератор псевдослучайных чисел
void FillArrya(int [] collection)
{
    int length = collection.Length; 
    int index = 0;
    while(index<length)
    {
        collection[index] = new Random().Next(1, 10); 
        index++;
    }

} 

void PrintArrya(int[] col)
{
    int count = col.Length; 
    int position = 0;
    while(position<count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
  
}
int IndexOff(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // если элемента нет то будет -1
    while(index<count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArrya(array);
PrintArrya(array);
System.Console.WriteLine();

int pos = IndexOff(array, 5);
System.Console.WriteLine(pos);

 