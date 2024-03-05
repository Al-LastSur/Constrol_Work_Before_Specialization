//the list of methods used

// Method to identify amount of symbols in each element of string array
    void CalculateStringLengths(string[] stringsArray)
    {
        // Pick each element separately
        int size = 0;
        foreach (string str in stringsArray)
        {
            // Identify the amount of symbols inside of element
            int length = str.Length;
            if (length <= 3)
            {
               size++;
            }
            // Выводим результат
            Console.WriteLine($"Строка \"{str}\" содержит {length} символов.");
        }
    }
int CalculateSizeFinalArray (string[] stringsArray)
    {
        // Pick each element separately
        int size = 0;
        foreach (string str in stringsArray)
        {
            // Identify the amount of symbols inside of element
            int length = str.Length;
            if (length <= 3)
            {
               size = size + 1;
            }
        }
        return size;
    }


string[] CreateFinalArray(string[] stringsArray)
{
    string[] finalArray = new string[stringsArray.Length];
    for (int i = 0; i < stringsArray.Length; i++)
    {
        finalArray[i] = stringsArray[i];
    }
    return finalArray;
}


// Solution below

// beforegiven examples arrays - uncomment only one line below
// string [] stringsArray = {"Hello", "2", "world", ":-)"}; // alternatively
string [] stringsArray = {"1234", "1567", "-2", "computer science"}; // alternatively
// string [] stringsArray = {"Russia", "Denmark", "Kazan"};// alternatively

// alternatively create array filled via console

 // Вызываем метод для определения количества символов в каждом элементе массива
        CalculateStringLengths(stringsArray);
        int size = CalculateSizeFinalArray(stringsArray);
Console.WriteLine($"Новый массив содежит {size} элементов.");
