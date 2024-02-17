using KodlamaIo.Business.Abstract;
using KodlamaIo.DataAccess.Abstract;
using KodlamaIo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Business.Concretes;

public class CourseManager : ICourseService
{
    private readonly ICourseDal courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        this.courseDal = courseDal;
    }

    public List<Course> GetAll()
    {
        return courseDal.GetAll();
    }
    public List<Course> GetCoursesByInstructorId(int instructorId)
    {
        return courseDal.GetCoursesByInstructorId(instructorId);
    }
    public List<Course> GetCoursesByCategoryId(int categoryId)
    {
        return courseDal.GetCoursesByCategoryId(categoryId);
    }
    public Course GetCourseById(int id)
    {
        return courseDal.GetCourseById(id);
    }
    public void Add(Course course)
    {
        courseDal.Add(course);
    }
    public void Update(Course course)
    {
        courseDal.Update(course);
    }
    public void Delete(int id)
    {
        courseDal.Delete(id);
    }

    
}
