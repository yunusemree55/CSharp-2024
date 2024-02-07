using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager
{

    private List<Course> courses = new List<Course>();

    public CourseManager()
    {

        Course course1 = new Course();

        course1.Id = 1;
        course1.Name = "C#";
        course1.Description = ".Net 8";
        course1.Price = 0;

        Course course2 = new Course();

        course2.Id = 2;
        course2.Name = "Java";
        course2.Description = "Java 17";
        course2.Price = 10;

        Course course3 = new Course();

        course3.Id = 3;
        course3.Name = "Python";
        course3.Description = "Python 3.12....";
        course3.Price = 20;

        Console.WriteLine("CourseManager constructor çalıştı");
        
        courses.Add(course1);
        courses.Add(course2);
        courses.Add(course3);
    }


    public List<Course> GetAll()
    {
        //datas comes from db

        //foreach (var course in courses)
        //{
        //    Console.WriteLine($"Kurs ID: {course.Id} \nKurs Adı: {course.Name}");
        //}

        return courses;
    }

}
