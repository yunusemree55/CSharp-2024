using KodlamaIo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Abstract;

public interface ICategoryDal
{
    List<Category> GetAll();
    Category GetCategoryById(int id);
    void Add(Category category);
    void Update(Category category);
    void Delete(int id);



}
