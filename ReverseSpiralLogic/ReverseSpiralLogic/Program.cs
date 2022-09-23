namespace ReverseSpiralLogic
{
    public class Program
    {
        static void Main(string[] args)
        {
            int rows = 0, cols = 0, number = 0, i = 0, j = 0;

            Console.Write("Enter Numbers of Rows = ");
            rows = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter Numbers of Columns = ");
            cols = Convert.ToInt16(Console.ReadLine());

            int[,] arr = new int[rows, cols];

            int interation = rows % 2 == 0 ? rows / 2 : (rows / 2) + 1;
            number = rows * cols;

            for (int k = 0; k < interation; k++)
            {
                for (j = k; j < cols - k; j++, number--)
                {
                    if (number == 0)
                        break;
                    arr[i, j] = number;
                }
                j--;
                for (i = k + 1; i < rows - k; i++, number--)
                {
                    if (number == 0)
                        break;
                    arr[i, j] = number;
                }
                i--;
                for (j = cols - (k + 2); j >= k; j--, number--)
                {
                    if (number == 0)
                        break;
                    arr[i, j] = number;
                }
                j++;
                for (i = rows - (k + 2); i > k; i--, number--)
                {
                    if (number == 0)
                        break;
                    arr[i, j] = number;
                }
                i++;
            }

            Console.WriteLine("Reverse = ");
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < cols; y++)
                {
                    Console.Write(arr[x, y] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
