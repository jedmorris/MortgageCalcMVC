namespace MortgageCalcMVC.Models;

public class MortgageCalc
{
    public double InterestRate { get; set; }
    
    public int LoanPrincipal { get; set; }
    
    public int LoanBalance { get; set; }
    
    public int LoanTerm { get; set; }
    
    public int MonthlyInterest { get; set; }
    
    public int MonthlyPayment { get; set; }
    
    
}