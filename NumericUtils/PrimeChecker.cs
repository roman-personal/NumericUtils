namespace NumericUtils
{
    public class PrimeChecker
    {
        public bool IsPrime(int value)
        {
            if (value <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(value); i++)
            {
                if (value % i == 0)
                    return false;
            }

            return true;
        }
    }
}