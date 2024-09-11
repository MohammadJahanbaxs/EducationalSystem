namespace EducationalSystem.Entities;

public class Tuition
{
    public Tuition(double amount, int installments, double surplusAmount)
    {
        Amount = amount;
        Installments = installments;
        SurplusAmount = surplusAmount;
    }
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