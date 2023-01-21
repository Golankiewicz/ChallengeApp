var name = "Ewa";
var sex = "kobieta";
int age = 33;

if (sex == "kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}

if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat "+ age);
}

if(sex=="mężczyzna"&& age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}

if(name == "Paweł" && sex=="mężczyzna"&& age == 59)
{
    Console.WriteLine("Paweł, szczęśliwy mężczyzna, lat " + age);
}
