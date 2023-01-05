namespace Banking;
using EGoverance;


public class Account
{
    public event TaxOperation overBalance;
    public event BelowBalance underBalance;
    public double Balance { get; set; }
    public int AccNo { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string ContactNo { get; set; }
    public Account()
    {
        this.AccNo = 0;
        this.Name = "Yash";
        this.Email = "Y@gamil.com";
        this.ContactNo = "9999999999";
        this.Balance = 10000;
    }
    //public static int AccountCounter=1;

    public Account(int id, string name, string email, string contact, double balance)
    {
        this.AccNo = id;
        this.Name = name;
        this.Email = email;
        this.ContactNo = contact;
        this.Balance = balance;
        //AccountCounter++;
    }

    public Account(double amount)
    {
        this.Balance = amount;
    }

    public void Deposit(double amount)
    {
        this.Balance += amount;
    }

    public void Withdraw(Account accObj, double amount)
    {
        if (accObj.Balance < 5000 || accObj.Balance - amount < 5000)
        {
            underBalance(accObj);
            // Console.WriteLine("dfsg");
            // BelowBalance ub = underBalance;
            // if (ub != null)
            // {
            //     ub(accObj);
            // }
        }
        else
        {
            accObj.Balance -= amount;
        }
    }

    public override string ToString()
    {
        return base.ToString() + " Account No = " + this.AccNo + "Name = " + this.Name + " Email = " + this.Email + " Conatact = " + this.ContactNo + " Balance = " + this.Balance;
    }
    public void ProcessTax(Account obj)
    {
        if (obj.Balance > 250000)
        {
            overBalance(obj.Balance);
        }
    }

}
