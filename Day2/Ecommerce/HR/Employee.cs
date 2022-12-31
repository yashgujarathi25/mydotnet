namespace HR;
public abstract class Employee
{

    public int Id{get; set;}
    public string Name{get; set;}
    public string Email{get; set;}
    public string ContactInfo{get; set;}
    public string Location{get; set;}
    public DateTime DOB{get; set;}
    public float DA{get; set;}
    public float HRA{get; set;}
    public float BasicSalary{get; set;}

    public Employee():this(1,"Tanmay", "tan@gmail.com","9404819492","Dholpur",new DateTime(2000,01,20),10000,10000,40000){

    }
    public Employee(int id, string name, string email, string contact, string location, 
                    DateTime dob, float da, float hra, float basicsal)
    {
        this.Id=id;
        this.Name= name;
        this.Email = email;
        this.ContactInfo = contact;
        this.DOB = dob;
        this.Location = location;
        this.BasicSalary = basicsal;
        this.DA = da;
        this.HRA=hra;   
    }

    public override string ToString(){
        string str = "ID = "+Id+" Name = "+Name+" Email = "+Email+" ContactInfo = "+ContactInfo+
        " Location = "+Location+" DOB = "+DOB+" Daily Alloance = "+DA+" HRA = "+HRA+" Basic Salary = "+BasicSalary;
        return str;
    }

    public virtual float ComputeSal(){
        float sal = (DA*30)+HRA+BasicSalary;
        return sal;
    }

    public abstract void DoWork();
}
