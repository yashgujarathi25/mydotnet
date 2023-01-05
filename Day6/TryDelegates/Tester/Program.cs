using Banking;
using EGoverance;

CentralGov bjpGovt = new CentralGov();
Account acc123 = new Account();
TaxOperation itOperation = new TaxOperation(bjpGovt.IncomeTaxDeduct);
TaxOperation proOperation = new TaxOperation(bjpGovt.ProfessionalTaxDeduct);
TaxOperation serOperation = new TaxOperation(bjpGovt.ServiceTaxDeduct);
Console.WriteLine("Unicast Delegates !!!!!");

//unicast delegate
itOperation(acc123.Balance);
proOperation(acc123.Balance);
serOperation(acc123.Balance);

//Chaining delegate
Console.WriteLine("After Chaining Delegate!!!!!");
TaxOperation? GeneralOperation = null;
GeneralOperation = proOperation;
GeneralOperation += itOperation;
GeneralOperation += serOperation;

GeneralOperation(acc123.Balance);
GeneralOperation-=serOperation;
GeneralOperation(acc123.Balance);

Console.WriteLine("After event !!!!!");
acc123.overBalance+=itOperation;
acc123.overBalance += serOperation;

Console.WriteLine("Enter the Amount to Deposit : ");
acc123.Deposit(double.Parse(Console.ReadLine()));
Console.WriteLine(acc123);

acc123.ProcessTax(acc123);
BankManager bm = new BankManager();
BelowBalance smsSending = new BelowBalance(bm.SMS);
BelowBalance emailSending = new BelowBalance(bm.Email);
BelowBalance blocking = new BelowBalance(bm.Blocked);

acc123.underBalance += smsSending;
acc123.underBalance += emailSending;
acc123.underBalance += blocking;

Console.WriteLine("Enter Amount to Withdraw : ");
acc123.Withdraw(acc123, double.Parse(Console.ReadLine()));


Console.WriteLine("Enter New Account Details :");
Console.WriteLine("int id, string name, string email, string contact, double balance");
Account? acc1234 = new Account(int.Parse(Console.ReadLine()), Console.ReadLine(),
                                Console.ReadLine(),Console.ReadLine(), double.Parse(Console.ReadLine()));
Console.WriteLine("Enter the Amount to Deposit : ");
acc1234.Deposit(double.Parse(Console.ReadLine()));
Console.WriteLine(acc1234);

acc1234.underBalance += smsSending;
acc1234.underBalance += emailSending;
acc1234.underBalance += blocking;

Console.WriteLine("Enter Amount to Withdraw : ");
acc1234.Withdraw(acc1234, double.Parse(Console.ReadLine()));

Console.WriteLine(acc1234);




