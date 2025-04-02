namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Executor executor = new Executor();
            //Manager manager = new Manager();
            //manager.Evaluate(executor);
            //Console.WriteLine(executor.KPI);

            //int[] prices = new int[] { 5, 3, 7 };
            //int minPrice = int.MaxValue;

            int[] nums = new int[] { 5, 7, 7, 2 };

            int[] arrayProducts = ProductExceptSelf(nums);

            foreach (int item in arrayProducts)
            Console.WriteLine(item);



        }

        //static int[] ProductExceptSelf(int[] nums)
        //{
        //    var result = new int[nums.Length];
        //    int zeroIndex = 0;
        //    int zeroCount = 0;
        //    int product = 1;

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        int position = i;
        //        if (nums[i] != 0)
        //        {
        //            if (i == position)
        //                continue;

        //            product *= nums[i];
        //        }

        //        else
        //        {
        //            zeroCount++;
        //            zeroIndex = i;
        //        }

        //        if (zeroCount > 1)
        //            return result;
        //    }

        //    if (zeroCount == 1)
        //    {
        //        result[zeroIndex] = product;
        //        return result;
        //    }

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        result[i] = product;
        //    }

        //    return result;
        //}

        static int[] ArrProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                int position = i;
                result[i] = ProductExceptSelf(nums, position);
            }
            return result;
        }

        static int ProductExceptSelf(int[] nums, int position)
        {
            int product = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == position)
                {
                    continue;
                }

                product *= nums[i];
            }

            return product;
        }

        static int[] ProductExceptSelf(int[] nums)
        {
            int[] productsArr = new int[nums.Length];
            int leftProduct = 1;
            int rightProduct = 1;

            for (int position = 0; position < nums.Length; position++)
            {
                for (int i = 0; i < position; i++)
                {
                    leftProduct *= nums[i];
                }

                for (int i = 0; i > position; i++)
                {
                    rightProduct *= nums[i];
                }

                productsArr[position] = leftProduct * rightProduct;
            }

            return productsArr;
        }

    }
}
