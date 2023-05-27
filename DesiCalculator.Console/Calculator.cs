namespace DesiCalculator.Console;

public class Calculator
{
    private double height;
    private double width;
    private double length;
    private double volume;
    private double weight;
    private const double DesiFactor = 5000;
    
    public Calculator(double height, double width, double length, double? weight)
    {
        this.height = height;
        this.width = width;
        this.length = length;
        this.weight = weight ?? 0;
    }
    
    private double CalculateVolume()
    {
        volume = height * width * length;
        return volume;
    }
    
    public double CalculateDesi()
    {
        if (volume == 0)
        {
            CalculateVolume();
        }
        
        return volume / DesiFactor;
    }
 
}