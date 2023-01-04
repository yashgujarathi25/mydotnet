namespace Banking;
using System.ComponentModel.DataAnnotations;
[Serializable]
public class Customer
{
    public int CustomerId{get;set;}
    [Required]
    public string? Name{get;set;}
    public string? Address{get;set;}
    public string? Contact{get;set;}
    public int Age{set;get;}

    public Customer(){
        this.CustomerId =1;
        this.Name="Yash";
        this.Address="Shirpur";
        this.Contact="9404819492";
        this.Age = 23;
    }

    public Customer(int id, string name, string addr, string contact, int age){
         this.CustomerId = id;
        this.Name = name;
        this.Address = addr;
        this.Contact = contact;
        this.Age = age;
    }
    public override string ToString()
    {
        return string.Format("{0}, {1}, {2}, {3}, {4}",CustomerId,Name,Address,Contact,Age);
    }
}
