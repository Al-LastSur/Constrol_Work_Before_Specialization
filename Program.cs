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

string[] InputStringArray (int size, string[] result = null, int currentIndex = 0)
{
if (result == null) // for not to create new array every time
    {
       result = new string[size]; 
    }

if (currentIndex < size)
{
    result [currentIndex] = Console.ReadLine();
   return InputStringArray (size, result, currentIndex + 1);
}
else
    {
    return result;
    } 

}



// Solution below

//Choose alternatives to check solution


// beforegiven examples arrays - uncomment only one line below at once
// string [] stringsArray = {"Hello", "2", "world", ":-)"}; // alternatively
// string [] stringsArray = {"1234", "1567", "-2", "computer science"}; // alternatively
// string [] stringsArray = {"1234", "1567", "67", "15", "156","-2", "computer science"}; // alternatively
// string [] stringsArray = {"Russia", "Denmark", "Kazan"};// alternatively
// string [] stringsArray = {" ", "11!", "пос", "weter", "jam"}; // strange coincidence - when input from keyboard the same symbols the out put is [  , 11!, , 12 ] - why spacebar two times and no "пос"?

// alternatively create array filled via console

    Console.Write("Введите количетсво элементов строкового массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] stringsArray = InputStringArray (size);

// Optional output results

// StringLengths(stringsArray); // uncomment to see all the elements and amount of symbols in them
// Console.WriteLine($"Новый массив содежит {SizeOfFinalArray(stringsArray)} элементов."); // uncomment to see amount of elements inside new array

// Final output result

PrintFinalArray(stringsArray);
//helloworld

