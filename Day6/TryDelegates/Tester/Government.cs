namespace EGoverance;

public delegate void TaxOperation(double amount);

public class CentralGov{

    public void IncomeTaxDeduct(double amount){
        Console.WriteLine("20% income tax is deducted from your account");
    }

    public void ServiceTaxDeduct(double amount){
        Console.WriteLine("15% income tax is deducted from your account");
    }

    public void ProfessionalTaxDeduct(double amount){
        Console.WriteLine("10% income tax is deducted from your account");
    }
}