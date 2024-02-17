using KodlamaIo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Abstract;

public interface ICourseDal
{
    List<Course> GetAll();
    List<Course> GetCoursesByInstructorId(int instructorId);
    List<Course> GetCoursesByCategoryId(int categoryId);
    Course GetCourseById(int id);
    void Add(Course course);
    void Update(Course course);
    void Delete(int id);

}
