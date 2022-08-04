Console.WriteLine("Enter name user");
string username = Console.ReadLine();

if(username.ToUpper() == "МАША")
{
    Console.WriteLine("Машка ты чтоли, ни чё се!!!");
}
else
{
    Console.Write("Ну здравствуй НЕ МАША, а ");
    Console.WriteLine(username);
}