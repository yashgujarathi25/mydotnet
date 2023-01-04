namespace Banking;
public delegate void BelowBalance();
public class BankManager{

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