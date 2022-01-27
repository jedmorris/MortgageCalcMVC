namespace MortgageCalcMVC.Models;

public class MortgageCalc
{
    public double Rate { get; set; }
    
    public int Principal { get; set; }
    
    public int Balance { get; set; }
    
    public int Term { get; set; }
    
    public int MonthlyInterest { get; set; }
    
    public int MonthlyPayment { get; set; }
    
    
}