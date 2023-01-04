using Banking;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

bool exit = false;
List<Customer> custlist =  new List<Customer>();

while(!exit)
{                                         
Console.WriteLine("1. Add Customer : ");
Console.WriteLine("2. To Show All Customer : ");
Console.WriteLine("3. Update Customer : ");
Console.WriteLine("4. Serialize");
Console.WriteLine("5. Deserialize");
Console.WriteLine("6. Exit : ");
Console.WriteLine("Enter Choice : ");
string fileName = @"G:\Local Repo\DAC\mydotnet\Assignment\netbanking\customer.json";
switch (int.Parse(Console.ReadLine()))
{
    case 1:
        Console.WriteLine("Enter Customer: Id, Name , Address, Contact, Age");
        custlist.Add(new Customer(int.Parse(Console.ReadLine()), Console.ReadLine(),Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine())));
        Console.WriteLine("Customer Added Succesfully..!!!");
        break;
    case 2:
        foreach(Customer c in custlist){
            Console.WriteLine(c);
        }
        break;
    case 3:
        break;
    case 4:
        try
        {
            var options = new JsonSerializerOptions {IncludeFields=true};
            var custJson = JsonSerializer.Serialize<List<Customer>>(custlist,options);
            File.WriteAllText(fileName,custJson);
        }
        catch (System.Exception)
        { 
            throw new Exception("Not Serialized");
        }
        break;
    case 5:
        try
        {
            string jsonString = File.ReadAllText(fileName);
            List<Customer> deCustlist = JsonSerializer.Deserialize<List<Customer>>(jsonString);  
            Console.WriteLine("Deserializing the Data from json file: ");
            foreach (Customer item in deCustlist)
            {
                Console.WriteLine(item);
            }

        }
        catch (System.Exception)
        {
            throw new Exception("Not Deerialized");
        }
        break;
    case 6:
        exit=true;
        break;
    default:
        break;
}
}