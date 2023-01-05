namespace Banking;
public delegate void BelowBalance(Account obj);
public class BankManager{

    public void Blocked(Account obj){
        Console.WriteLine("Blocking Account "+ obj.AccNo +" due to insufficient Balance...!!!");
        
    }

    public void Email(Account obj){
        Console.WriteLine("Sending Email to "+obj.Name+" on "+obj.Email);
    }

    public void SMS(Account obj){
        Console.WriteLine("Sending SMS to "+ obj.Name+" on "+obj.ContactNo );
    }
}