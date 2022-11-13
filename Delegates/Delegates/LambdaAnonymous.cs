namespace Delegates
{
    delegate int SumCount(int[,] data);
    static class LambdaAnonymous
    {
        static int GetSum(int[,] data)
        {
            int sum = 0;
            foreach (int element in data)
                sum += element;
            return sum;
        }

        public static SumCount CountAnonymousFunction = delegate (int[,] data)
        {
            return GetSum(data);
        };

        public static SumCount CountLambda = (data) => GetSum(data);
    }
}
