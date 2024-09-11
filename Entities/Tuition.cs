namespace EducationalSystem.Entities;

public class Tuition
{
    
    public double Amount { get; private set; }
    public int Installments { get; private set; }
    public double SurplusAmount { get; private set; }
    
    public enum Type
    {
        Free,   // دولتی                               
        TuitionPayer,                     // شهریه پرداز
        NonProfit    // غیر انتفاعی                    
    }
}