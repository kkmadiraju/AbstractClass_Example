using AbstractClass_Example;
using AbstractClass_Example.Banking;
using AbstractClass_Example.CloudResources;

Animal a = new Dog();
a.MakeSound(); // Woof! Woof!
a.Sleep();     // Zzz...

Animal b = new Cat();
b.MakeSound(); // Meow...
b.Sleep();

//Bankng Example
BankAccount acc1 = new SavingsAccount
{
    AccountNumber = "SB123",
    CustomerName = "Kiran"
};

acc1.Deposit(5000);
acc1.Withdraw(4500); // Minimum balance rule kicks in
acc1.PrintStatement();

BankAccount acc2 = new CurrentAccount
{
    AccountNumber = "CA456",
    CustomerName = "TechNova Solutions"
};

acc2.Deposit(10000);
acc2.Withdraw(15000); // Overdraft allowed
acc2.PrintStatement();
//=====================================
//CloudResource AbstractClass_Example

CloudResource vm = new AzureVM { Name = "Prod-VM-01", Region = "Central India" };
vm.Provision();
vm.TagResource();

CloudResource lambda = new AWSLambda { Name = "TxnProcessor", Region = "ap-south-1" };
lambda.Provision();

CloudResource bucket = new GCPBucket { Name = "backup-bucket", Region = "asia-south1" };
bucket.Provision();
