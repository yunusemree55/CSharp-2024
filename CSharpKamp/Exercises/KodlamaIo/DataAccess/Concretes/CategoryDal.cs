using KodlamaIo.DataAccess.Abstract;
using KodlamaIo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Concretes;

public class CategoryDal : ICategoryDal
{
    private List<Category> _categories = new List<Category>() 
    {
        new Category(1,"Backend"),
        new Category(2,"Frontend")
    };

    public void Add(Category category)
    {
        _categories.Add(category);
    }

    public void Delete(int id)
    {
        _categories = _categories.Where(c => c.Id !=  id).ToList();
    }

    public List<Category> GetAll()
    {
        return _categories;
    }

    public Category GetCategoryById(int id)
    {
        return _categories.FirstOrDefault(c => c.Id == id);
    }

    public void Update(Category category)
    {
        Category target = _categories.FirstOrDefault(c => c.Id == category.Id);

        target.Id = category.Id;
        target.Name = category.Name;
        
    }
}
