using KodlamaIo.DataAccess.Abstract;
using KodlamaIo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Concretes;

public class InstructorDal : IInstructorDal
{
    private List<Instructor> _instructors = new List<Instructor>()
    {
        new Instructor(1,"Engin","Demiroğ","engingdemirog@hotmail.com","Ankara"),

    };

    public List<Instructor> GetAll()
    {
        return _instructors;
    }

    public Instructor GetInstructorById(int id)
    {
        return _instructors.FirstOrDefault(i => i.Id == id);
    }

    public void Add(Instructor instructor)
    {
        _instructors.Add(instructor);
    }

    public void Update(Instructor instructor)
    {

        var target = _instructors.FirstOrDefault(i => i.Id == instructor.Id);

        target.Id = instructor.Id;
        target.FirstName = instructor.FirstName;
        target.LastName = instructor.LastName;
        target.Email = instructor.Email;

    }

    public void Delete(int id)
    {
        _instructors = _instructors.Where(i => i.Id != id).ToList();
    }

    

    
}
