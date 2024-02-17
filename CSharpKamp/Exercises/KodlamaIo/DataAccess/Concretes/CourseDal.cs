using KodlamaIo.DataAccess.Abstract;
using KodlamaIo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Concretes;

public class CourseDal : ICourseDal
{
    private List<Course> courses = new List<Course>()
    {
        new Course(1,1,1,"C# Kursu","2024 Güncel C# Kursu"),
        new Course(2,1,1,"Java Kursu","2022 Java Kursu")
    };

    public List<Course> GetAll()
    {
        return courses;
    }

    public List<Course> GetCoursesByInstructorId(int instructorId)
    {
        return courses.Where(c => c.InstructorId == instructorId).ToList();
    }

    public Course GetCourseById(int id)
    {
        return courses.FirstOrDefault(c => c.Id == id);
    }

    public List<Course> GetCoursesByCategoryId(int categoryId)
    {
        return courses.Where(c => c.CategoryId == categoryId).ToList();
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }
    public void Update(Course course)
    {
        Course target = courses.FirstOrDefault(c => c.Id == course.Id);
        
        target.Id = course.Id;
        target.Name = course.Name;
        target.Description = course.Description;

    }
    public void Delete(int id)
    {
        courses = courses.Where(c => c.Id != id).ToList();
    }

    
}
