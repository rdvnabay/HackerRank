namespace Implementation.Solutions;

public class StrangeCounter
{
    public static long Run(long t)
    {
        long initTime = 1;
        long capacity = 3;

        while (t > initTime + capacity - 1)
        {
            initTime = initTime + capacity;
            capacity = capacity * 2;
        }

        long diff = t - initTime;
        long result = capacity - diff;

        return result;
    }
}
