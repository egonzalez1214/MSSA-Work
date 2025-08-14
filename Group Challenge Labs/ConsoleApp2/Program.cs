namespace ConsoleApp2 {

    internal class Program {

        static void Main(string[] args) {
            Console.WriteLine("Hello, World!\n");

            //case 1
            int[,] matrix1 = new int[,] {
                { 1, 2 },
                { 3, 4 }
            };
            int row = 1;
            int col = 4;
            PrintMatrix(matrix1); //<--- prints original matrix
            MatrixReshape(matrix1, row, col); //<--- prints reshaped matrix

            Console.WriteLine("\n----------------------\n"); // just a divider

            //case 2
            int[,] matrix2 = new int[,] {
                { 1, 2 },
                { 3, 4 },
                { 5, 6 }
            };
            row = 2;
            col = 3;
            PrintMatrix(matrix2);
            MatrixReshape(matrix2, row, col);
        }

        static void MatrixReshape(int[,] matrix, int row, int col) {
            //get matrix dimension to get length of tempArray
            int size = matrix.GetLength(0) * matrix.GetLength(1);
            int[] tempArray = new int[size];

            //check if able to reshape by row * col = size of orginal matrix
            if (row * col != size) {
                Console.WriteLine("Cannot reshape matrix to the given dimensions.");
                for (int r = 0; r < matrix.GetLength(0); r++) {
                    for (int c = 0; c < matrix.GetLength(1); c++) {
                        Console.Write(matrix[r, c] + " ");
                    }
                    Console.WriteLine();
                }
                return;
            }

            //fill tempArray with values from matrix
            int i = 0;
            foreach (int num in matrix) {
                tempArray[i] = num;
                i++;
            }

            //reshape matrix
            i = 0;
            int[,] reshapedMatrix = new int[row, col];
            for (int r = 0; r < row; r++) {
                for (int c = 0; c < col; c++) {
                    reshapedMatrix[r, c] = tempArray[i];
                    i++;
                }
            }

            //print reshaped matrix
            Console.WriteLine();
            PrintMatrix(reshapedMatrix);
        }

        static void PrintMatrix(int[,] matrix) {
            for (int r = 0; r < matrix.GetLength(0); r++) {
                for (int c = 0; c < matrix.GetLength(1); c++) {
                    Console.Write(matrix[r, c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}