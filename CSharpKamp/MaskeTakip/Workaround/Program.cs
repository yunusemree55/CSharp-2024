using Business.Concrete;
using Entities.Concrete;

Console.WriteLine("Hello, World!!!");


//Person person1 = new Person();



SelamVer();
Topla(3, 5);

//Diziler / Arrays

string student1 = "Yunus Emre";
string student2 = "Enes Emir";
string student3 = "Mert Ali";

string[] students = { student1, student2, student3 };

foreach (string student in students)
{
    Console.WriteLine(student);
}

static void SelamVer()
{
    Console.WriteLine("Merhaba");
}


static int Topla(int x1, int x2)
{
    int result = x1 + x2;
    Console.WriteLine(result);
    return result;

}

Person person1 = new Person();

person1.Id = 1;
person1.FirstName = "Yunus Emre";
person1.LastName = "Çiçek";
person1.DateOfBirthYear = 2001;
person1.IdentityNumber = "12345678910";

PttManager pttManager = new PttManager(new PersonManager());

pttManager.GiveMask(person1);



