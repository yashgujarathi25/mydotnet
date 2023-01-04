using Banking;
using EGoverance;

CentralGov bjpGovt = new CentralGov();
Account acc123 = new Account(4000);
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

acc123.ProcessTax();

BelowBalance smsSending = new BelowBalance(acc123.SMS);
BelowBalance emailSending = new BelowBalance(acc123.Email);
BelowBalance blocking = new BelowBalance(acc123.Blocked);

acc123.underBalance += smsSending;
acc123.underBalance += emailSending;
acc123.underBalance += blocking;

Console.WriteLine("Enter Amount to Withdraw : ");
acc123.Withdraw(double.Parse(Console.ReadLine()));







