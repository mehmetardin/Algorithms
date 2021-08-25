namespace MaximumSumSubArray
{
    public static class BruteForceSolution
    {
        public static int MaximumSumSubArray(int[] arr)
        {
            int sum = 0;
            int maxSum = int.MinValue;

           for(int i =0 ; i<arr.Length; i++)
           {
               sum = arr[i];
               for(int j= i+1; j< arr.Length; j++)
               {
                   sum += arr[j];
                   
                   if(maxSum < sum)
                   maxSum = sum;
               }
           }
           
           return maxSum;
        }
    }
}