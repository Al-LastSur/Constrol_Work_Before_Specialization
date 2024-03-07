//the list of methods used

// // optional method to identify the amount of symbols in each element
// void StringLengths(string[] stringsArray) // working successfully
//     {
//         // Pick each element separately
//         int size = 0;
//         foreach (string str in stringsArray)
//         {
//             // Identify the amount of symbols inside of element
//             int length = str.Length;
//             if (length <= 3)
//             {
//                size++;
//             }
//         Console.WriteLine($"Строка \"{str}\" содержит {length} символов.");
//         }
//     }

int SizeOfFinalArray (string[] stringsArray) // method to identify the amount of elements corresponding the requirements at the existing array
    {
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

string[] FinalArray (string[] stringsArray) // to form up new array of elements of initial array corresponding to the specified requirements
    {
        
        string[] Result = new string[SizeOfFinalArray(stringsArray)];

            int index = 0;
// Pick each element separately
        foreach (string str in stringsArray)
        {
            // Identify the amount of symbols inside of element
            int length = str.Length;
            if (length <= 3)
            {
               Result[index] = str;
               index++;
            }
        }
        return Result;
    }

void PrintFinalArray (string[] stringsArray) // separated output from FinalArray method
{
    Console.WriteLine($"Итоговый Массив соответствующий заданию: [ {string.Join(", ", FinalArray(stringsArray))} ]");
}


// Solution below

//Choose alternatives to check solution

// beforegiven examples arrays - uncomment only one line below at once
// string [] stringsArray = {"Hello", "2", "world", ":-)"}; // alternatively
// string [] stringsArray = {"1234", "1567", "-2", "computer science"}; // alternatively
// string [] stringsArray = {"1234", "1567", "67", "15", "156","-2", "computer science"}; // alternatively
string [] stringsArray = {"Russia", "Denmark", "Kazan"};// alternatively

// alternatively create array filled via console

// Optional output results

// StringLengths(stringsArray); // uncomment to see all the elements and amount of symbols in them
// Console.WriteLine($"Новый массив содежит {SizeOfFinalArray(stringsArray)} элементов."); // uncomment to see amount of elements inside new array

// Final output result
PrintFinalArray(stringsArray);

