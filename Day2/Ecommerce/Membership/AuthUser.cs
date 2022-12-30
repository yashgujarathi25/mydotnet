namespace Membership;
public class AuthUser
{
    public static bool Validate(string email, string password){
        if(email=="yashgujarathi25@gmail.com" && password == "yash2512")
        {
            return true;
        }
        else{
            return false;
        }
    }
}
