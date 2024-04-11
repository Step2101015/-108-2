/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

class Program
{
    static void Main()
    {
        string binaryNumber;
        bool isValidInput = false;
        
        do
        {
            Console.WriteLine("Введите число в двоичной системе счисления (состоящее из 0 и 1):");
            binaryNumber = Console.ReadLine();
            
            // Проверка на правильность ввода
            isValidInput = IsBinaryNumber(binaryNumber);
            if (!isValidInput)
            {
                Console.WriteLine("Число введено неверно. Повторите ввод.");
            }
        } while (!isValidInput);
        
        int decimalNumber = Convert.ToInt32(binaryNumber, 2);
        
        Console.WriteLine($"Число в десятичной системе счисления: {decimalNumber}");
    }
    
    static bool IsBinaryNumber(string input)
    {
        foreach (char ch in input)
        {
            if (ch != '0' && ch != '1')
            {
                return false;
            }
        }
        return true;
    }
}