
class Program
{
    static void Main(string[] args)
    {
        string[] originalArray =  { "Hello", "2", "world", ":-)" };                              
        string[] newArray = new string[originalArray.Length];
        int newIndex = 0;
        for (int i = 0; i < originalArray.Length; i++)
        {
            if(originalArray[i].Length <= 3)
            {
                newArray[newIndex] = originalArray[i];
                newIndex++;
            }
        }
        Console.WriteLine("Новый массив строк:");
        for (int i = 0; i < newIndex; i++)
        {
            Console.WriteLine(newArray[i]);
        }
    }
}


