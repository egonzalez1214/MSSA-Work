namespace Assignment_5._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            NotEigenValues();
        }

        static void NotEigenValues() {
            //prompt user for matrix size
            Console.Write("How big is the square matrix: ");
            int matrixSize = Convert.ToInt32(Console.ReadLine());

            //create square matrix with size
            Console.WriteLine("Input each of the matrix's elements:");
            int[,] notEigenMatrix = new int[matrixSize, matrixSize];
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++) {
                    Console.Write($"Element - [{i}],[{j}]: ");
                    notEigenMatrix[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //print matrix
            for (int i = 0; i < matrixSize; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < matrixSize; j++) {
                    Console.Write(notEigenMatrix[i,j] + " ");
                }
                Console.WriteLine("|");
            }

            //calculate sum of right to left diagonal
            int notMainDiagonal = 0;
            for (int i = 0; i < matrixSize; i++) {
                int j = matrixSize - 1 - i;
                notMainDiagonal += notEigenMatrix[i, j];
            }
            
            //print sum of our diagonal
            Console.WriteLine($"The sum of the not Main Diagonal is: {notMainDiagonal}");
        }
    }
}

/*
Write a C# Sharp program to find the sum of the right diagonals of a matrix.
--- Test Data ---
Input the size of the square matrix: 2
Input elements in the first matrix:
element - [0],[0]: 1
element - [0],[1]: 2
element - [1],[0]: 3
element - [1],[1]: 4
Expected Output:
The matrix is:
| 1 2 |
| 3 4 |
Addition of the right Diagonal elements is: 5 
*/