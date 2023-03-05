// // Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// // Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// // При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// // исключительно массивами.
// // // Примеры:
// // // ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// // // ['1234", "1567", "-2", "computer science"] -> ["-2"]
// // // ["Russia", "Denmark", "Kazan"] -> []

string[] workArray = FillArray(); // присвоение переменой функции "ввод массива" 
string[] resultArray = GenerateNewArray (workArray);// присвоение переменной функции "массив из 3 чисел"
string firstArray = PrintArray(workArray); // массив 1
string secondArray = PrintArray(resultArray); // массив 2
Console.WriteLine(firstArray + " -> " + secondArray);// вывод на консоль

string[] FillArray()//функция для ввода элементов массива  
{
    Console.WriteLine("Введите значения через пробел, по окончании нажмите Enter: ");
    string? enterSymbols = Console.ReadLine();
    if (enterSymbols == null) { enterSymbols = ""; };
    char[] separators = new char[] { ',', ' ' };
    string[] workArray = enterSymbols.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return workArray;
}

string PrintArray(string[] workArray) // функция для вывода
{
    string stringArray = "(";
    for (int i = 0; i < workArray.Length; i++)
    {
        if (i == workArray.Length - 1)
        {
            stringArray += $"\"{workArray[i]}\"";
            break;
        }
        stringArray += ($"\"{workArray[i]}\", ");
    }
    stringArray += ")";
    return stringArray;
}

int CountStringSymbols(string[] workArray)// подсчет количества элементов
{
    int counter = 0;
    foreach (string item in workArray)
    {
        if (item.Length <= 3)
        {
            counter++;
        }
    }
    return counter;
}

string[] GenerateNewArray(string[] workArray)//генерация нового массива из +-3 элементов
{
    int resultArrayLength = CountStringSymbols(workArray);
    string[] resultArray = new string[resultArrayLength];
    int i = 0;
    foreach (string item in workArray)
    {
        if (item.Length <= 3)
        {
            resultArray[i] = item;
            i++;
        }
    }
    return resultArray;
}