namespace Banking;
using EGoverance;

public delegate void BelowBalance();
public class Account{
    public event TaxOperation overBalance;
    public event BelowBalance underBalance;
    public double Balance{get;set;}
    public Account(){
        this.Balance = 10000;
    }

    public Account(double amount){
        this.Balance = amount;
    }

    public void Deposit(double amount){
        this.Balance+=amount;
    }

    public void Withdraw(double amount){
        if(this.Balance < 5000){
            underBalance();
        }
        this.Balance-=amount;
    }

    public override string ToString()
    {
        return base.ToString()+ "   Balance = "+this.Balance;
    }
    public void ProcessTax(){
        if(this.Balance > 250000){
            overBalance(this.Balance);
        }
    }


    public void Blocked(){
        Console.WriteLine("Blocking Account due to insufficient Balance...!!!");
    }

    public void Email(){
        Console.WriteLine("Sending Email to Account Holder");
    }

    public void SMS(){
        Console.WriteLine("Sending SMS to Account Holder");
    }
}
