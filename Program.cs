
Console.WriteLine("Skriv ett nummer mellan 1 och 100");
string str = Console.ReadLine();
int tal = int.Parse(str);
while (tal <= 101)
{
  Console.WriteLine(tal++);
}