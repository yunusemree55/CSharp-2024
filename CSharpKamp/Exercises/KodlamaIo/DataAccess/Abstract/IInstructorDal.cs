using KodlamaIo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Abstract;

public interface IInstructorDal
{
    List<Instructor> GetAll();
    Instructor GetInstructorById(int id);
    void Add(Instructor instructor);
    void Update(Instructor instructor);
    void Delete(int id);
    


}
