using Math_Game;

var menu = new Menu();

var date = DateTime.UtcNow;

string name = GetName();

menu.ShowMenu(name, date);

string GetName()
{
    Console.Write("Please enter your name: ");
    var name = Console.ReadLine();
    return name;
}