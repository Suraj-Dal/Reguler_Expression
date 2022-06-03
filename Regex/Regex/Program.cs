RegexProblems.RegExpresion reg = new RegexProblems.RegExpresion();
Console.WriteLine("Enter User details:");
Console.Write("First Name:");
string fName = Console.ReadLine();
Console.Write("Last Name:");
string lName = Console.ReadLine();
reg.RegexFirstNameChecker(fName);
reg.RegexLastNameChecker(lName);