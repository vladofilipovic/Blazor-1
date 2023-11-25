namespace ClosestFarthestElements.Modules
{
    public static class ArrayFunctions
    {
        public static int IndexOfClosestToAverage(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array cannot be empty");
            }

            double average = array.Average();
            int closestIndex = 0;
            double minDifference = Math.Abs(array[0] - average);

            for (int i = 1; i < array.Length; i++)
            {
                double difference = Math.Abs(array[i] - average);
                if (difference < minDifference || (difference == minDifference && array[i] < array[closestIndex]))
                {
                    minDifference = difference;
                    closestIndex = i;
                }
            }

            return closestIndex;


        }

        public static int IndexOfFarthestFromAverage(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array cannot be empty");
            }

            double average = array.Average();
            int farthestIndex = 0;
            double maxDifference = Math.Abs(array[0] - average);

            for (int i = 1; i < array.Length; i++)
            {
                double difference = Math.Abs(array[i] - average);
                if (difference > maxDifference || (difference == maxDifference && array[i] < array[farthestIndex]))
                {
                    maxDifference = difference;
                    farthestIndex = i;
                }
            }

            return farthestIndex;


        }
    }
}
