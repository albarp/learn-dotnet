using Xunit;
using app.domain;

public class StatisticsTest {

    [Fact]
    public void Average()
    {
        // Given
        Statistics s = new Statistics();
    
        // When
        var source = new int[] { 2, 2 };
    
        // Then
        var avg = s.Average(source);

        Assert.Equal(2, avg);
    }
}