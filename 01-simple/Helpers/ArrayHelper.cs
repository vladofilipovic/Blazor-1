namespace DSS.Helpers
{
    public class ArrayHelper
    {
        public static string ElementsToString(byte[] arr)
        {
            string res = "";
            for (int i = 0; i < arr.Length; i++)
            {
                res += arr[i] + " ";
            }
            return res;
        }

        public static string ElementsToString(string[] arr)
        {
            string res = "";
            foreach (string x in arr)
            {
                res += "'" + x + "' ";
            }
            return res;
        }

        public static string ElementsToString(int[] arr)
        {
            string res = "";
            foreach (int x in arr)
            {
                res += x + " ";
            }
            return res;
        }

        public static double Avg(double[] arr)
        {
            double r = 0;
            foreach (double x in arr)
                r += x;
            return r/arr.Length;
        }

    }
}
