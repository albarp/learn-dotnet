namespace app.domain;

public class Statistics
{
    public double Average(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Numbers array cannot be null or empty");
        }
        
        return numbers.Average();
    }
} 