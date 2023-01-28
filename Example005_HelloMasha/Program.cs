Console.WriteLine("Привет, назови себя");
string username = Console.ReadLine();
if(username.ToLower() == "маша")
{
Console.WriteLine("Ура, это Маруся!!!");
}
else
{
Console.Write("Привет, ");
Console.WriteLine(username);
}