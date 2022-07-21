namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[9, 9];
            Matrix.InitRandom(matrix, 1, 2);
            Console.WriteLine();

            Matrix.PrintMatrix(matrix);

            Console.WriteLine($"Square: {Matrix.GetMaxSquare(matrix)}");
        }
    }
}