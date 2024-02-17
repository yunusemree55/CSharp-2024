

using KodlamaIo.Business.Concretes;
using KodlamaIo.DataAccess.Concretes;
using KodlamaIo.Entities.Concretes;

Console.WriteLine("------------Instructor------------");


InstructorManager instructorManager = new InstructorManager(new InstructorDal());

Console.WriteLine("************Okuma************");

foreach (var instructor in instructorManager.GetAll())
{
    Console.WriteLine($"Eğitmen adı soyadı: {instructor.FirstName} {instructor.LastName}");
}

Console.WriteLine("************Ekleme************");

Instructor instructor1 = new Instructor(2,"John","Smith","johnsmith@gmail.com","New York");
 
instructorManager.Add(instructor1);

foreach (var instructor in instructorManager.GetAll())
{
    Console.WriteLine($"Eğitmen adı soyadı: {instructor.FirstName} {instructor.LastName}");
}


Console.WriteLine("************Silme************");


instructorManager.Delete(1);

foreach (var instructor in instructorManager.GetAll())
{
    Console.WriteLine($"Eğitmen adı soyadı: {instructor.FirstName} {instructor.LastName}");
}


Console.WriteLine("----------------------------------\n\n");


Console.WriteLine("------------Course------------");


CourseManager courseManager = new CourseManager(new CourseDal());

Console.WriteLine("************Okuma************");

foreach (var course in courseManager.GetAll())
{
    Console.WriteLine($"Kurs Adı: {course.Name}");
}

Console.WriteLine("************Ekleme************");

Course course1 = new Course(3,2,2,"Vue.js","SPA - Frontend");

courseManager.Add(course1);

foreach (var course in courseManager.GetAll())
{
    Console.WriteLine($"Kurs Adı: {course.Name}");
}


Console.WriteLine("************Silme************");

courseManager.Delete(2);

foreach (var course in courseManager.GetAll())
{
    Console.WriteLine($"Kurs Adı: {course.Name}");
}

Console.WriteLine("************İnstructor'a ait Kurslar************");


foreach (var course in courseManager.GetCoursesByInstructorId(1))
{
    Console.WriteLine($"Kurs Adı: {course.Name}");
}


Console.WriteLine("------------Category------------");

CategoryManager categoryManager = new CategoryManager(new CategoryDal());

Console.WriteLine("************Okuma************");

foreach (var category in categoryManager.GetAll())
{
    Console.WriteLine($"Kategori Adı: {category.Name}");
}

Console.WriteLine("************Ekleme************");

Category category1 = new Category(3, "Mobil Programlama");

categoryManager.Add(category1);

foreach (var category in categoryManager.GetAll())
{
    Console.WriteLine($"Kategori Adı: {category.Name}");
}