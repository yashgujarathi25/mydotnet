﻿using Membership;
using HR;
Console.WriteLine("**********************************************************");
Console.WriteLine("Mazak me Tanmay Ka flower");
Console.WriteLine("**********************************************************");

Console.WriteLine("Enter Email :- ");
string email = Console.ReadLine();
Console.WriteLine("Enter Password :- ");
string password = Console.ReadLine();

if(AuthUser.Validate(email,password)){
    Console.WriteLine("Welcome to Tanmay ka Flower Bazaar");
    Employee emp = new Employee();
    Console.WriteLine(emp);
}
else{
    Console.WriteLine("Invalid User...!!!!");
}