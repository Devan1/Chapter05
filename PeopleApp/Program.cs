using Packt.Shared;
using static System.Console;
using System;

//var bob = new Person(); //c# 1.0 or later
Person bob = new(); // c# 9.0 or later
Console.WriteLine(bob.ToString());

bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 12, 22);//c# 1 and later. 

WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
    arg0: bob.Name,
    arg1: bob.DateOfBirth);
WriteLine($"{bob.Name} was born on {bob.DateOfBirth}");

Person alice = new()
{
    Name = "Alice",
    DateOfBirth = new(1998, 3, 7)
};

WriteLine(format: "{0} was born on {1: dd MMM yy}",
    arg0: alice.Name,
    arg1: alice.DateOfBirth);

bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;

WriteLine(format: "{0}'s favorite wonder is the {1}. Its integer is number is{2}.",
    arg0: bob.Name,
    arg1: bob.FavoriteAncientWonder,
    arg2: (int)bob.FavoriteAncientWonder);

bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

bob.Children.Add(new Person { Name = "Alfred" });
bob.Children.Add(new() { Name = "Zoe" });

WriteLine($"{bob.Name} has {bob.Children.Count} children.");

for(int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
{
    WriteLine($"{bob.Children[childIndex].Name}");
}

foreach(var child in bob.Children)
{
    WriteLine(child.Name);
}

BankAccount.InterestRate = 0.012M;//store a shared value

BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400.00M;

WriteLine(format: "{0} earned {1:C} interest.",
    arg0: jonesAccount.AccountName,
    arg1: jonesAccount.Balance * BankAccount.InterestRate);

BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98M;

WriteLine(format: "{0} earned {1:C} interest.",
    arg0: gerrierAccount.AccountName,
    arg1: gerrierAccount.Balance* BankAccount.InterestRate);
