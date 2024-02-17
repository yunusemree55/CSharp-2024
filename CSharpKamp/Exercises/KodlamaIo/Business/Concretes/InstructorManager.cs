using KodlamaIo.Business.Abstract;
using KodlamaIo.DataAccess.Abstract;
using KodlamaIo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Business.Concretes;

public class InstructorManager : IInstructorService
{

    private readonly IInstructorDal _instructorDal;

    public List<Instructor> GetAll()
    {
        return _instructorDal.GetAll();
    }

    public Instructor GetInstructorById(int id)
    {
        return _instructorDal.GetInstructorById(id);
    }

    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }

    public void Add(Instructor instructor)
    {
        _instructorDal.Add(instructor);
    }
    public void Update(Instructor instructor)
    {
        _instructorDal.Update(instructor);
    }

    public void Delete(int id)
    {
        _instructorDal.Delete(id);
    }
    
}
