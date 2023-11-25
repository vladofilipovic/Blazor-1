// GenericArrayFunctions.cs

using System;
using System.Linq;

namespace ClosestFarthestElements.Modules
{
    public static class GenericArrayFunctions
    {
        public static T FindClosestToAverage<T>(T[] array) where T : IComparable<T>, IConvertible
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array cannot be empty");
            }

            dynamic average = array.Select(x => (double)Convert.ChangeType(x, typeof(double))).Average();
            T closestElement = array[0];
            dynamic minDifference = Math.Abs((double)Convert.ChangeType(array[0], typeof(double)) - average);

            for (int i = 1; i < array.Length; i++)
            {
                dynamic difference = Math.Abs((double)Convert.ChangeType(array[i], typeof(double)) - average);
                if (difference < minDifference || (difference == minDifference && array[i].CompareTo(closestElement) < 0))
                {
                    minDifference = difference;
                    closestElement = array[i];
                }
            }

            return closestElement;
        }

        public static T FindFarthestFromAverage<T>(T[] array) where T : IComparable<T>, IConvertible
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array cannot be empty");
            }

            dynamic average = array.Select(x => (double)Convert.ChangeType(x, typeof(double))).Average();
            T farthestElement = array[0];
            dynamic maxDifference = Math.Abs((double)Convert.ChangeType(array[0], typeof(double)) - average);

            for (int i = 1; i < array.Length; i++)
            {
                dynamic difference = Math.Abs((double)Convert.ChangeType(array[i], typeof(double)) - average);
                if (difference > maxDifference || (difference == maxDifference && array[i].CompareTo(farthestElement) < 0))
                {
                    maxDifference = difference;
                    farthestElement = array[i];
                }
            }

            return farthestElement;
        }
    }
}
