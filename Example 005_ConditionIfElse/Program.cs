Console.Write("Введи имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "anna")
{
    Console.WriteLine("Приветсвую, о царица гусениц!");
}
else 
{
    Console.Write("Ну привет, ");
    Console.WriteLine(username);
}