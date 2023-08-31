using ControlWorkOnTheMainBlock;

namespace ControlWorkOnTheMainBlok;

class Program
{
    static void Main(string[] args)
    {
        // Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше,
        // либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
        // При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

        string[] array = MyLib.InputStringArray();
        Console.WriteLine("Элементы вашего массива: ");
        MyLib.PrintArray(array);
        Console.WriteLine();
        Console.WriteLine("Ваш отсортированный массив(содержит только элементы в которых не более 3-х символов: )");

        string [] sortArray = MyLib.SortArray(array);
        if(sortArray.Length == 0) Console.WriteLine("В вашем массиве нет элементов длинной <=3!");
        else MyLib.PrintArray(sortArray);

    }
}
