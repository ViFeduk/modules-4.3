namespace modules_4._3._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            var temp = 0;
            
            
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        for (int k = 0; k < arr.GetLength(1)-1; k++)
                        {
                            if (arr[i, k] > arr[i, k + 1])
                            {
                                temp = arr[i, k];
                                arr[i,k]= arr[i, k + 1];
                                arr[i, k +1]= temp;
                            }
                        }

                    }
                }
                for (int i = 0;i < arr.GetLength(0); i++)
                {

                        for (int j = 0;j < arr.GetLength(1); j++)
                            Console.Write(arr[i,j]+" ");
                    Console.WriteLine();

                }



        }
    }
}
