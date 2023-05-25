namespace DesiCalculator.Console;

public class Calculator
{
    private double heightInCm;
    private double widthInCm;
    private double lengthInCm;
    private double volume;
    private double? weightInKg;
    private double DESI_FACTOR = 5000;
    
    public Calculator(double height, double width, double length, double? weight)
    {
        heightInCm = height;
        widthInCm = width;
        lengthInCm = length;
        weightInKg = weight ?? 0;
    }
    
    private double calculateVolume()
    {
        volume = heightInCm * widthInCm * lengthInCm;
        return volume;
    }
    
    public double calculateDesi()
    {
        if (volume == 0)
        {
            calculateVolume();
        }
        
        return volume / DESI_FACTOR;
    }
 
}