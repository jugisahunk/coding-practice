namespace CodingPractice
{
    public class ASum
    {
        public static long findNb(long m)
        {
            long remainingArea = m;
            long i = 0; //top cube 'n' value

            while (remainingArea > 0)
            {
                i++;
                long currentArea = (i * i * i);
                remainingArea -= currentArea;
            }

            return remainingArea == 0 ? i : -1;
        }
    }
}
