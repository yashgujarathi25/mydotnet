namespace Banking;
using EGoverance;


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

}
