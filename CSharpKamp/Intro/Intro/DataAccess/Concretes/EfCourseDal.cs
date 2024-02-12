﻿using Intro.DataAccess.Abstracts;
using Intro.Entities;

namespace Intro.DataAccess.Concretes;

public class EfCourseDal:ICourseDal
{

    private List<Course> courses = new List<Course>();

    public EfCourseDal()
    {
        Course course1 = new Course();

        course1.Id = 1;
        course1.Name = "JavaScript";
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

        courses.Add(course1);
        courses.Add(course2);
        courses.Add(course3);
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }

    public List<Course> GetAll()
    {
        //Burada DB işlemleri yapılır
        return courses;
    }




}
