//the list of methods used

void StringLengths(string[] stringsArray) // working successfully
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

int CalculateSizeOfFinalArray (string[] stringsArray) // working successfully
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
        }
        return size;
    }


void PrintFinalArray (string[] stringsArray)
    {
        // Pick each element separately
        string[] Result = new string[CalculateSizeOfFinalArray(stringsArray)];
            int index = 0;
        foreach (string str in stringsArray)
        {
            // Identify the amount of symbols inside of element
            int length = str.Length;
            if (length <= 3)
            {
               Result[index] = str;
               index++;
            }
            // for (index = 0; index < CalculateSizeOfFinalArray(stringsArray); index++)
            // {

            //         Result[index] = str;
            // }
        }
        Console.WriteLine($"Новый массив: [ {string.Join(", ", Result)} ]");
    }





// Solution below

// beforegiven examples arrays - uncomment only one line below
// string [] stringsArray = {"Hello", "2", "world", ":-)"}; // alternatively
// string [] stringsArray = {"1234", "1567", "-2", "computer science"}; // alternatively
string [] stringsArray = {"1234", "1567", "67", "15", "156","-2", "computer science"}; // alternatively
// string [] stringsArray = {"Russia", "Denmark", "Kazan"};// alternatively

// alternatively create array filled via console

 // Вызываем метод для определения количества символов в каждом элементе массива
StringLengths(stringsArray);
Console.WriteLine($"Новый массив содежит {CalculateSizeOfFinalArray(stringsArray)} элементов.");
PrintFinalArray(stringsArray);

