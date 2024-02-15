namespace modules_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var arr = new int[] { 5, -6, 9, -1, 2, 3, -4 };
            int temp;
            int sum=0;
            int quantity = 0;
            Console.WriteLine("Сортировка массива");
            for (int i = 0; i < arr.Length; i++)
            {
                 for(int j=0; j<arr.Length-1-i; j++)
                 {

                 
                        if(arr[j] > arr[j+1])
                        {
                            temp = arr[j];
                            arr[j] = arr[j +1];
                            arr[j + 1]=temp;
                        }
                 }
            }
            for (int i = 0;i < arr.Length;i++)
                Console.Write(arr[i]);
            Console.WriteLine();
            
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($"Сумма всех чисел равна {sum}");

            for (int i = 0;i< arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    quantity++;
                }
            }
            Console.WriteLine("Кол-во положительных чисел равно "+quantity);

        }
    }
}
