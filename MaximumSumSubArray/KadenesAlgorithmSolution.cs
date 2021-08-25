namespace MaximumSumSubArray
{
    public static class KadenesAlgorithmSolution
    {
        public static int MaximumSumSubArray(int[] arr)
        {
            int maxSum = int.MinValue;
            int currentSum = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                currentSum  += arr[i];

                if(currentSum > maxSum)
                    maxSum = currentSum;

                if(currentSum < 0)
                    currentSum = 0;
            }
            return maxSum;
        }
    }
}