namespace HR;

public class SalesManager:SalesEmployee{

    public float Bonus{get; set;}

    public SalesManager():base(){
        this.Bonus = 0;
    }

    public SalesManager(int id, string name, string email, string contact, string location,
                        DateTime dob, float da, float hra, float basicsal, float target, float salesdone, float bonus)
                        :base(id, name, email, contact, location, dob, da, hra, basicsal,target,salesdone){
                this.Bonus= bonus;
    }

    public override void DoWork()
    {
        base.DoWork();
    }

    public override float ComputeSal()
    {
        return base.ComputeSal()+Bonus;
    }

    public override string ToString()
    {
        return base.ToString()+" Bonus = "+ Bonus;
    }
}