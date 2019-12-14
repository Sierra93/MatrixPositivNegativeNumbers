using System;
using System.Collections.Generic;

namespace MatrixPositivNegativeNumbers {
    class Program {
        static void Main() {
            Random r = new Random();
            int[,] aMatrix = new int[10, 10];   // Матрица
            List<int> listPos = new List<int>();     // Коллекция для положительных чисел
            List<int> listNeg = new List<int>();     // Коллекция для отрицательных чисел
            List<int> listIndexZero = new List<int>();
            int lenRow = aMatrix.GetUpperBound(0) + 1;  // Строки
            int lenCol = aMatrix.GetUpperBound(1) + 1;  // Столбцы
            int row = 0, col = 0;   // Для позиций нулевых элементов строки и столбца
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < lenRow; i++) {
                row++;
                for (int j = 0; j < lenCol; j++) {
                    col++;
                    aMatrix[i, j] = r.Next(-10, 10);
                    // Вывод позиций нулевых элементов
                    if (aMatrix[i, j] == 0) {
                        Console.Write($"0 на {row} строке и {col} столбце");
                    }
                    // Добавляет положительные числа
                    if (aMatrix[i, j] >= 0) {
                        listPos.Add(aMatrix[i, j]);                        
                    }
                    // Добавляет отрицательные числа
                    else {
                        listNeg.Add(aMatrix[i, j]);
                    }
                    Console.Write(aMatrix[i, j] + "\t\t");                    
                }
                Console.WriteLine();                
            }
            Console.Write($"Положительных чисел: {listPos.Count}\n");
            Console.Write($"Отрицательных чисел: {listNeg.Count}");
            Console.ReadKey();
        }
    }
}
