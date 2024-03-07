//the list of methods used

// Method to identify amount of symbols in each element of string array
using System.Xml.XPath;

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
int CalculateSizeOfElement (string[] stringsArray)
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

// string[] CalculateSizeFinalArray (string[] stringsArray)
//     {
//         // Pick each element separately
//         foreach (string str in stringsArray)
//         {
//             // Identify the amount of symbols inside of element
//             string[] Result = new string[CalculateSizeOfElement(stringsArray)];
//             int index = 0;
//             for (index = 0; index < CalculateSizeOfElement(stringsArray); index++)
//             {
//             Result[index] = str; 
//             }
//         }
//         return Result;
//     }
void PrintFinalArray (string[] stringsArray)
    {
        // Pick each element separately
        string[] Result = new string[CalculateSizeOfElement(stringsArray)];
            int index = 0;
        foreach (string str in stringsArray)
        {
            // Identify the amount of symbols inside of element
            for (index = 0; index < CalculateSizeOfElement(stringsArray); index++)
            {
            Result[index] = str; 
            }
        }
        Console.WriteLine($"Новый массив: {string.Join(", ", Result)}");
    }




// Solution below

// beforegiven examples arrays - uncomment only one line below
string [] stringsArray = {"Hello", "2", "world", ":-)"}; // alternatively
// string [] stringsArray = {"1234", "1567", "-2", "computer science"}; // alternatively
// string [] stringsArray = {"Russia", "Denmark", "Kazan"};// alternatively

// alternatively create array filled via console

 // Вызываем метод для определения количества символов в каждом элементе массива
        CalculateStringLengths(stringsArray);
        int size = CalculateSizeOfElement(stringsArray);
Console.WriteLine($"Новый массив содежит {CalculateSizeOfElement(stringsArray)} элементов.");
PrintFinalArray(stringsArray);

