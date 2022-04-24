Console.Write("Введите имя пользователя: ");
string userName = Console.ReadLine();

if(userName.ToLower() == "маша") 
{
    Console.WriteLine("Ура! Жто же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(userName);
}