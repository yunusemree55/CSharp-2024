


using Intro.Business;
using Intro.Entities;

string message1 = "Krediler";
int term = 12;

double amount = 2500;

//variables => camelCase
bool isAuthenticated = true;
Console.WriteLine(message1);


//condition

if (isAuthenticated == true)
{
    Console.WriteLine("Hoşgeldin!");
}else
{
    Console.WriteLine("Giriş Yap Butonu");
}

string[] credits = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5" };
List<string> credits2 = new List<string>() { "Kredi-1" , "Kredi-2", "Kredi-3"};

foreach (var credit in credits)
{
    Console.WriteLine(credit);
    
}
for (int i = 0; i < credits2.Count; i++)
{
    Console.WriteLine(credits2[i]);
    
}

CourseManager courseManager = new CourseManager();

foreach (var course in courseManager.GetAll())
{
    Console.WriteLine(course.Name);
}








