// See https://aka.ms/new-console-template for more information
Console.Write("Enter FilePath :");
string filepath = Console.ReadLine();
if (File.Exists(filepath))
{
    Console.Write("File Path is Correct");
}
else
{
    Console.Write("Please Enter A valid File Path");
}

