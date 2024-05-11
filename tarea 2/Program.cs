

//using System;

//class Program
//{
//    static void PrintEvenNumbers(int number)
//    {
//        if (number > 100)
//        {
//            return;
//        }

//        if (number % 2 == 0)
//        {
//            Console.WriteLine(number);
//        }

//        PrintEvenNumbers(number + 1);
//    }

//    static void Main()
//    {
//        PrintEvenNumbers(1);
//    }
//}

//using System;

//class Program
//{
//    static int CalculateSum(int n)
//    {
//        if (n == 1)
//        {
//            return 1;
//        }
//        else
//        {
//            return n + CalculateSum(n - 1);
//        }
//    }

//    static void Main()
//    {
//        int n = 100; // Puedes cambiar este valor para probar con diferentes números
//        int sum = CalculateSum(n);
//        Console.WriteLine($"La suma de los números del 1 al {n} es: {sum}");
//    }
//}

//using System;

//class Program
//{
//    static void PrintNumberPyramid(int n, int currentLevel = 1)
//    {
//        if (currentLevel > n)
//        {
//            return;
//        }

//        // Imprimir los espacios antes de los números
//        for (int i = 0; i < n - currentLevel; i++)
//        {
//            Console.Write(" ");
//        }

//        // Imprimir los números de la pirámide
//        for (int i = 0; i < currentLevel * 2 - 1; i++)
//        {
//            Console.Write(currentLevel);
//        }

//        Console.WriteLine(); // Pasar a la siguiente línea

//        // Llamada recursiva para el siguiente nivel
//        PrintNumberPyramid(n, currentLevel + 1);
//    }

//    static void Main()
//    {
//        int n = 5; // Puedes cambiar este valor para probar con diferentes números
//        PrintNumberPyramid(n);
//    }
//}using System;

//class Program
//{
//    static void PrintInvertedNumberPyramid(int n)
//    {
//        if (n <= 0)
//        {
//            return;
//        }

//        // Imprimir los espacios antes de los números
//        for (int i = 0; i < n - 1; i++)
//        {
//            Console.Write(" ");
//        }

//        // Imprimir los números de la pirámide invertida
//        for (int i = 0; i < (5 - n) * 2 + 1; i++)
//        {
//            Console.Write(n);
//        }

//        Console.WriteLine(); // Pasar a la siguiente línea

//        // Llamada recursiva para el siguiente nivel
//        PrintInvertedNumberPyramid(n - 1);
//    }

//    static void Main()
//    {
//        int n = 5; // Puedes cambiar este valor para probar con diferentes números
//        PrintInvertedNumberPyramid(n);
//    }
//}

//using System;

//class Program
//{
//    static void PrintMultiplicationTable(int n, int multiplier = 1)
//    {
//        if (multiplier > 10)
//        {
//            return;
//        }

//        Console.WriteLine($"{n} x {multiplier} = {n * multiplier}");

//        // Llamada recursiva incrementando el multiplicador
//        PrintMultiplicationTable(n, multiplier + 1);
//    }

//    static void Main()
//    {
//        int n = 7; // Puedes cambiar este valor para probar con diferentes números
//        PrintMultiplicationTable(n);
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Crear una matriz de números reales (doubles)
//        double[] realNumbers = new double[5]; // Matriz con 5 elementos

//        // Inicializar la matriz con valores
//        realNumbers[0] = 3.14159;
//        realNumbers[1] = 2.71828;
//        realNumbers[2] = 1.61803;
//        realNumbers[3] = 1.41421;
//        realNumbers[4] = 0.57721;

//        // Imprimir la matriz de números reales
//        foreach (double number in realNumbers)
//        {
//            Console.WriteLine(number);
//        }
//    }
////}
//using System;
//using System;

//class Program
//{
//    static void Main()
//    {
//        // Crear una matriz de matrices (jagged array)
//        int[][] jaggedArray = new int[3][];

//        // Inicializar cada elemento de la matriz externa con una matriz de enteros
//        jaggedArray[0] = new int[] { 1, 2, 3 };
//        jaggedArray[1] = new int[] { 4, 5 };
//        jaggedArray[2] = new int[] { 6, 7, 8, 9 };

//        // Imprimir la matriz de matrices
//        foreach (int[] innerArray in jaggedArray)
//        {
//            foreach (int number in innerArray)
//            {
//                Console.Write(number + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}



//using System;

//class Program
//{
//    static void Main()
//    {
//        // Crear una matriz unidimensional con un número impar de elementos
//        int[] array = { 1, 2, 3, 4, 5, 6, 7 };

//        // Verificar si la matriz tiene un número impar de elementos
//        if (array.Length % 2 != 0)
//        {
//            // Calcular el índice del elemento central
//            int middleIndex = array.Length / 2;

//            // Acceder y mostrar el elemento central
//            Console.WriteLine("El elemento central es: " + array[middleIndex]);
//        }
//        else
//        {
//            Console.WriteLine("No hay un elemento central único, la matriz tiene un número par de elementos.");
//        }
//    }
//}
//EJERCICIO 10
//using System;

//class Program
//{
//    static int[,] ResizeMatrix(int[,] matrix, int newRows, int newCols)
//    {
//        int[,] resizedMatrix = new int[newRows, newCols];
//        int minRows = Math.Min(matrix.GetLength(0), newRows);
//        int minCols = Math.Min(matrix.GetLength(1), newCols);

//        for (int i = 0; i < minRows; i++)
//        {
//            for (int j = 0; j < minCols; j++)
//            {
//                resizedMatrix[i, j] = matrix[i, j];
//            }
//        }

//        return resizedMatrix;
//    }

//    static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
//    {
//        int rows1 = matrix1.GetLength(0);
//        int cols1 = matrix1.GetLength(1);
//        int rows2 = matrix2.GetLength(0);
//        int cols2 = matrix2.GetLength(1);

//        int newRows = Math.Max(rows1, rows2);
//        int newCols = Math.Max(cols1, cols2);

//        int[,] resizedMatrix1 = ResizeMatrix(matrix1, newRows, newCols);
//        int[,] resizedMatrix2 = ResizeMatrix(matrix2, newRows, newCols);

//        int[,] result = new int[newRows, newCols];

//        for (int i = 0; i < newRows; i++)
//        {
//            for (int j = 0; j < newCols; j++)
//            {
//                result[i, j] = resizedMatrix1[i, j] + resizedMatrix2[i, j];
//            }
//        }

//        return result;
//    }

//    static void Main()
//    {
//        // Matriz 1 (3x2)
//        int[,] matrix1 = {
//            { 1, 2 },
//            { 3, 4 },
//            { 5, 6 }
//        };

//        // Matriz 2 (2x3)
//        int[,] matrix2 = {
//            { 1, 2, 3 },
//            { 4, 5, 6 }
//        };

//        // Sumar las matrices
//        int[,] result = AddMatrices(matrix1, matrix2);

//        // Imprimir el resultado
//        for (int i = 0; i < result.GetLength(0); i++)
//        {
//            for (int j = 0; j < result.GetLength(1); j++)
//            {
//                Console.Write(result[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}
//EJERCICIO 11


//using System;

//class Program
//{
//    static void MultiplyMatrixByScalar(int[,] matrix, int scalar)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                matrix[i, j] *= scalar;
//            }
//        }
//    }

//    static void Main()
//    {
//        // Matriz 3x3
//        int[,] matrix = {
//            { 1, 2, 3 },
//            { 4, 5, 6 },
//            { 7, 8, 9 }
//        };

//        int scalar = 2; // Número por el que se multiplicará la matriz

//        // Mostrar la matriz original
//        Console.WriteLine("Matriz original:");
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write(matrix[i, j] + " ");
//            }
//            Console.WriteLine();
//        }

//        // Multiplicar la matriz por el escalar
//        MultiplyMatrixByScalar(matrix, scalar);

//        // Mostrar la matriz resultante
//        Console.WriteLine("\nMatriz resultante después de multiplicarla por " + scalar + ":");
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write(matrix[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//EJERCICIO 12)

//using System;

//class Program
//{
//    static double CalculateMatrixMean(int[,] matrix)
//    {
//        int sum = 0;
//        int totalElements = matrix.GetLength(0) * matrix.GetLength(1);

//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                sum += matrix[i, j];
//            }
//        }

//        return (double)sum / totalElements;
//    }

//    static void Main()
//    {
//        // Matriz 3x3
//        int[,] matrix = {
//            { 1, 2, 3 },
//            { 4, 5, 6 },
//            { 7, 8, 9 }
//        };

//        // Calcular la media de los elementos de la matriz
//        double mean = CalculateMatrixMean(matrix);

//        // Mostrar la media
//        Console.WriteLine("La media de los elementos de la matriz es: " + mean);
//    }
//}


//EJERCICIO 13)

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Tamaño de la matriz
//        int filas = 100;
//        int columnas = 100;

//        // Crear una instancia de Random para generar números aleatorios
//        Random random = new Random();

//        // Crear la matriz
//        double[,] matriz = new double[filas, columnas];

//        // Llenar la matriz con números aleatorios
//        for (int i = 0; i < filas; i++)
//        {
//            for (int j = 0; j < columnas; j++)
//            {
//                matriz[i, j] = random.NextDouble();
//            }
//        }

//        // Imprimir la matriz (opcional)
//        for (int i = 0; i < filas; i++)
//        {
//            for (int j = 0; j < columnas; j++)
//            {
//                Console.Write(matriz[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//EJERCICIO 14

//using System;
//using System.Linq;
//using System.Collections.Generic;

//class Program
//{
//    static double Mean(IEnumerable<int> numbers)
//    {
//        return numbers.Average();
//    }

//    static double Median(IEnumerable<int> numbers)
//    {
//        List<int> sortedNumbers = numbers.OrderBy(n => n).ToList();
//        int count = sortedNumbers.Count;
//        if (count % 2 == 0)
//        {
//            return (sortedNumbers[count / 2 - 1] + sortedNumbers[count / 2]) / 2.0;
//        }
//        else
//        {
//            return sortedNumbers[count / 2];
//        }
//    }

//    static double StandardDeviation(IEnumerable<int> numbers)
//    {
//        double mean = Mean(numbers);
//        double sumOfSquaredDifferences = numbers.Select(n => (n - mean) * (n - mean)).Sum();
//        return Math.Sqrt(sumOfSquaredDifferences / (numbers.Count() - 1));
//    }

//    static void Main()
//    {
//        // Matriz 3x3 de ejemplo
//        int[,] matrix = {
//            { 1, 2, 3 },
//            { 4, 5, 6 },
//            { 7, 8, 9 }
//        };

//        // Aplanar la matriz a una lista unidimensional
//        List<int> flattenedMatrix = new List<int>();
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                flattenedMatrix.Add(matrix[i, j]);
//            }
//        }

//        // Calcular la media, la mediana y la desviación estándar
//        double mean = Mean(flattenedMatrix);
//        double median = Median(flattenedMatrix);
//        double standardDeviation = StandardDeviation(flattenedMatrix);

//        // Mostrar los resultados
//        Console.WriteLine("Media: " + mean);
//        Console.WriteLine("Mediana: " + median);
//        Console.WriteLine("Desviación estándar: " + standardDeviation);
//    }
//}

//EJERCICIO 15

//using System;

//class Program
//{
//    static int FindMaxElement(int[,] matrix)
//    {
//        int max = int.MinValue; // Inicializar con el valor mínimo posible de un entero

//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                if (matrix[i, j] > max)
//                {
//                    max = matrix[i, j]; // Actualizar el valor máximo si se encuentra un elemento mayor
//                }
//            }
//        }

//        return max;
//    }

//    static void Main()
//    {
//        // Matriz 3x3 de ejemplo
//        int[,] matrix = {
//            { 1, 2, 3 },
//            { 4, 5, 6 },
//            { 7, 8, 9 }
//        };

//        // Encontrar el elemento máximo
//        int maxElement = FindMaxElement(matrix);

//        // Mostrar el elemento máximo
//        Console.WriteLine("El elemento máximo de la matriz es: " + maxElement);
//    }
//}
//EJERCICIO 16

//using System;

//class Program
//{
//    static int[,] FindMaxSumSubmatrix(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);
//        int maxSum = int.MinValue;
//        int[] maxSubmatrix = new int[4]; // Indices de la submatriz (top, left, bottom, right)

//        for (int top = 0; top < rows; top++)
//        {
//            int[] currentRow = new int[cols];

//            for (int bottom = top; bottom < rows; bottom++)
//            {
//                for (int col = 0; col < cols; col++)
//                {
//                    currentRow[col] += matrix[bottom, col];
//                }

//                int start = 0;
//                int end = 0;
//                int currentSum = 0;

//                for (int i = 0; i < cols; i++)
//                {
//                    currentSum += currentRow[i];

//                    if (currentSum > maxSum)
//                    {
//                        maxSum = currentSum;
//                        start = end;
//                        end = i + 1;
//                        maxSubmatrix[0] = top;
//                        maxSubmatrix[1] = start;
//                        maxSubmatrix[2] = bottom;
//                        maxSubmatrix[3] = end;
//                    }

//                    if (currentSum < 0)
//                    {
//                        currentSum = 0;
//                        start = i + 1;
//                    }
//                }
//            }
//        }

//        // Extraer la submatriz de mayor suma
//        int[,] maxSumSubmatrix = new int[maxSubmatrix[2] - maxSubmatrix[0] + 1, maxSubmatrix[3] - maxSubmatrix[1] + 1];
//        for (int i = maxSubmatrix[0]; i <= maxSubmatrix[2]; i++)
//        {
//            for (int j = maxSubmatrix[1]; j <= maxSubmatrix[3]; j++)
//            {
//                maxSumSubmatrix[i - maxSubmatrix[0], j - maxSubmatrix[1]] = matrix[i, j];
//            }
//        }

//        return maxSumSubmatrix;
//    }

//    static void Main()
//    {
//        // Matriz cuadrada de ejemplo
//        int[,] matrix = {
//            { 1, -2, 3 },
//            { -4, 5, -6 },
//            { 7, -8, 9 }
//        };

//        // Encontrar la submatriz de mayor suma
//        int[,] maxSumSubmatrix = FindMaxSumSubmatrix(matrix);

//        // Mostrar la submatriz de mayor suma
//        Console.WriteLine("Submatriz de mayor suma:");
//        for (int i = 0; i < maxSumSubmatrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < maxSumSubmatrix.GetLength(1); j++)
//            {
//                Console.Write(maxSumSubmatrix[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}