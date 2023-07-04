string permisson = ""; //|Manager
int level = 20;
//Console.WriteLine(level > 55 ? "Welcome, Super Admin user": "Welcome, Admin user");

if (level > 55 && permisson.Contains("Admin") ){
    Console.WriteLine("Welcome, Super Administrtador");
}
else if(level <= 55 && permisson.Contains("Admin")){
    Console.WriteLine("Welcome, Admin user.");
}
else if (permisson.Contains("Manager") && level >=20){
    Console.WriteLine("contact an Admin for access");
}
else if (level < 20 && permisson.Contains("Manager")){
Console.WriteLine("You do not havd sufficient priveleges");
}
else if (!permisson.Contains("Admin") || (!permisson.Contains("Manager"))) {
    Console.WriteLine("You do not have sufficient privileges");
}

//segunda possibilidade
/*
string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}
*/

