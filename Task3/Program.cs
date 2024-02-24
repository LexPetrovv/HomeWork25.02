//  Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1



string PrintArray(int [] array)
{
    return string.Join(", ",array);
}

int [] ArraySwap(int [] array,int index)
{

    if (index <= 0)
    {
        return array;
    }
    int temp = array[index];
    array[index] = array[array.Length - index-1];
    array[array.Length - index-1] = temp;
    return ArraySwap(array,index -= 2);
}

int [] array = new int[] {1, 57, 5, 0, 10, 3};
System.Console.WriteLine($"Произвольный массив => [{PrintArray(array)}]");
System.Console.WriteLine($"Перевернутый массив => [{PrintArray(ArraySwap(array,array.Length-1))}]");