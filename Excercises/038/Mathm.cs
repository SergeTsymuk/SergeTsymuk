namespace _038
{
    public class Mathm
    {
        public int GetSum(int n1, int n2, int n3)
        {
            int sum = n1 + n2 + n3;
            return sum;
        }

        public int GetSum(ref int n1, ref int n2, ref int n3)
        {
            n1++; n2++; n3++;
            int sum = n1 + n2 + n3;
            return sum;
        }

        public int GetSum(int n1, int n2, int n3, bool f)
        {
            int result;
            if (f == true)
            {
                result = GetSum(n1, n2, n3);
            }
            else
            {
                result = GetSum(ref n1, ref n2, ref n3);
            }
            return result;
        }

    }
}
