namespace ControlWorkOnTheMainBlock;

class MyLib
{
    //  Создал метод ввод массива пользователем

    public static string[] InputStringArray()
    {
        Console.WriteLine("На какое количество элементов вы хотите создать массив?. Введите целое число: ");
        
        int arrayLenght = Convert.ToInt32(Console.ReadLine());
        string[] array = new string[arrayLenght];
        for (int i = 0; i < arrayLenght; i++)
        {
            Console.WriteLine("Введите строку : ");
            array[i] = Convert.ToString(Console.ReadLine());
        }
        return array;
    }

    // Метод на распечатку одномерного массива

    public static void PrintArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + "  ");

        }
    }
    // Метод на сортировку массива(длинна одного элемента массива не должна быть больше 3-х символов)
    // Создание нового массива, которы содержит только элементы имеющие длинну не более 3-х элементов

    public static string[] SortArray(string[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length < 4)
                count++;

        }


        string[] sortArray = new string[count];
        int j = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length < 4)
            {
                sortArray[j] = array[i];
                j++;
            }

        }
        return sortArray;
    }




}