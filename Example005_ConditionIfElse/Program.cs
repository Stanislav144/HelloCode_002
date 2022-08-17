Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Искрена")
{
    Console.WriteLine("Ура, это же ИСКРЕНА!");    
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}


