using System;

namespace vn_mode_csharp_dz23
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            int userSum = 0;
            int[] arrayNumbers = new int[1];
            
            while (isOpen)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 15);
                Console.WriteLine("Вывести сумму введёных чисел: sum");
                Console.WriteLine("Выйти из программы: exit");
                Console.SetCursorPosition(0, 0);
                Console.Write("Введёные числа: ");

                for (int i = 1; i < arrayNumbers.Length; i++)
                {
                    Console.Write(arrayNumbers[i] + " ");
                }
                Console.Write("\nВведите число или команду: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "sum":
                        Console.Write("Сумма введёных чисел  = ");
                        for (int i = 0; i < arrayNumbers.Length; i++)
                        {
                            userSum += arrayNumbers[i];
                        }
                        Console.Write(userSum);
                        Console.ReadKey();
                        userSum = 0;
                        break;
                    case "exit":
                        Console.WriteLine("Вы вышли из программы.");
                        isOpen = false;
                        break;
                    default:
                        int[] tempArrayNumbers = new int[arrayNumbers.Length + 1];
                        for (int i = 0; i < arrayNumbers.Length; i++)
                        {
                            tempArrayNumbers[i] = arrayNumbers[i];
                        }
                        tempArrayNumbers[tempArrayNumbers.Length - 1] = Convert.ToInt32(userInput);
                        arrayNumbers = tempArrayNumbers;
                        break;
                }
            }
        }
    }
}
