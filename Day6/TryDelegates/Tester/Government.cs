namespace EGoverance;
public delegate double TaxOperation(double amount);

public class CentralGov{

    public CentralGov(){

    }

    public double IncomeTaxDeduct(double amount){
        Console.WriteLine(amount*0.2+" =  20% income tax is deducted from your account");
        return amount*0.8;
    }

    public double ServiceTaxDeduct(double amount){
        Console.WriteLine(amount*0.15+ " = 15% income tax is deducted from your account");
         return amount*0.85;
    }

    public double ProfessionalTaxDeduct(double amount){
        Console.WriteLine(amount*0.1+ " = 10% income tax is deducted from your account");
         return amount*0.9;
    }
}