/*Заполнение массива какими то числами*/

void FillArray(int[] collection) //метод случайных чисел // collectoin - название аргумента //void не возвращает значение
{
    int length = collection.Length; //длинна массива
    int index = 0; // позиция индекса с 0
    while (index < length) //пока индекса меньше длины. делаем...
    {
        collection[index] = new Random{}.Next(1, 10);// обратиться к аргументу на позицию индекс и положить случайное число от 1 до 10
        index++;//...делаем индекс +1
    }
}

void PrintArray(int[] col) //печать массива // col - наименование
{
    int count = col.Length; //колличесвто элементов
    int position = 0; // текущая позиция
    while (position < count ) //пока позиция меньше чем колличесвто элементов...
    {
        Console.WriteLine(col[position]); //...Выводи текущую позицию
        position++; // Добавить +1 позицию
    }
}

int IndexOf(int [] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //если элемента нет то будет -1,
    while (index < count)
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

int[] array = new int [10]; //создай массив где 10 элементов

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);
