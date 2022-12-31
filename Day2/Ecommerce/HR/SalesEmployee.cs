namespace HR;

public class SalesEmployee:Employee{

    public float Target{get; set;}
    public float Incentive{get;set;}
    public float SalesDone{get;set;}

    public SalesEmployee():base(){
        this.Incentive=0;
        this.SalesDone =0;
        this.Target = 0;
    }

    public SalesEmployee(int id, string name, string email, string contact, string location, 
                    DateTime dob, float da, float hra, float basicsal, float target, float salesdone)
                        :base(id, name, email, contact, location, dob, da, hra, basicsal){
                this.SalesDone=salesdone;
                this.Target = target;
                this.Incentive = 0;
    }
    public override void DoWork(){
        if(SalesDone >= Target){
            this.Incentive = 5000;
        }
        else{
            this.Incentive = 0;
        }
    }

    public override float ComputeSal()
    {
        return base.ComputeSal() + this.Incentive;
    }

    public override string ToString()
    {
        return base.ToString() + " Target = "+Target+" SalesDone = "+SalesDone+ " Incentive = " +Incentive;
    }
}