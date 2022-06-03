RegexProblems.RegExpresion reg = new RegexProblems.RegExpresion();
Console.WriteLine("Enter User details:");
Console.Write("First Name:");
string fName = Console.ReadLine();
Console.Write("Last Name:");
string lName = Console.ReadLine();
Console.Write("Email ID:");
string email = Console.ReadLine();
Console.Write("Mobile No:");
string mobile = Console.ReadLine();
Console.Write("Password:");
string pass = Console.ReadLine();
reg.RegexFirstNameChecker(fName);
reg.RegexLastNameChecker(lName);
reg.RegexEmailChecker(email);
reg.RegexMobileChecker(mobile);
reg.RegexPasswordChecker(pass);
Console.WriteLine("\nSample emails validation:\n");
string[] sample = File.ReadAllLines(@"D:\Suraj\Projects\Reguler_Expression\SampleEmails.txt");
for (int i = 0; i < sample.Length; i++)
{
    string ret = reg.RegexSampleMailChecker(sample[i]);
    Console.WriteLine(sample[i] +"  ->  "+ ret);
}