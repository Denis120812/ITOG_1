/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/

// Ввод исходного массива строк  пользователем с клавиатуры
Console.WriteLine("Введите элементы массива через пробел:");
string[] inputArray = Console.ReadLine().Split();

// Создание нового массива для хранения строк
string[] resultArray = new string[inputArray.Length];
int resultIndex = 0;

// заполнение нового массива до 3 элементов
foreach (string str in inputArray)
{
    if (str.Length <= 3)
    {
        resultArray[resultIndex] = str;
        resultIndex++;
    }
}


// Создание окончательного массива 
string[] finalResultArray = new string[resultIndex];
Array.Copy(resultArray, finalResultArray, resultIndex);

