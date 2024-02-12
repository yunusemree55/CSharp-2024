


using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

string message1 = "Krediler";
int term = 12;

double amount = 2500;

//variables => camelCase
bool isAuthenticated = true;
//Console.WriteLine(message1);


//condition

if (isAuthenticated == true)
{
    //Console.WriteLine("Hoşgeldin!");
}else
{
    //Console.WriteLine("Giriş Yap Butonu");
}

string[] credits = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5" };
List<string> credits2 = new List<string>() { "Kredi-1" , "Kredi-2", "Kredi-3"};

foreach (var credit in credits)
{
    //Console.WriteLine(credit);
    
}
for (int i = 0; i < credits2.Count; i++)
{
    //Console.WriteLine(credits2[i]);
    
}

CourseManager courseManager = new CourseManager(new DapperCourseDal());

foreach (var course in courseManager.GetAll())
{
    Console.WriteLine(course.Name);
}

IndividualCustomer customer1 = new IndividualCustomer();

customer1.Id = 1;
customer1.IdentityNumber = "12345678910";
customer1.FirstName = "Yunus Emre";
customer1.LastName = "Çiçek";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();

customer2.Id = 2;
customer2.IdentityNumber = "5678901234";
customer2.FirstName = "Enes Emir";
customer2.LastName = "Çiçek";
customer2.CustomerNumber = "654321";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlama.IO";
customer3.CustomerNumber = "654128";
customer3.TaxNumber = "987123";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "ABC";
customer4.CustomerNumber = "197356";
customer4.TaxNumber = "208564";


List<BaseCustomer> customerList = new List<BaseCustomer>() { customer1,customer2,customer3,customer4 };


//Polymorphism
foreach (BaseCustomer customer in customerList)
{
    Console.WriteLine(customer.CustomerNumber);


}