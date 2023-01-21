var name = "Ewa";
var sex = "kobieta";
int age = 33;

if (sex == "kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}

else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat " + age);
}

else if (sex == "mężczyzna" && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}

else if (name == "Paweł" && sex == "mężczyzna" && age == 59)
{
    Console.WriteLine("Paweł, szczęśliwy mężczyzna, lat " + age);
}

else
{
    Console.WriteLine("Osobnik niezidentyfikowany");
}
