using KodlamaIo.Business.Abstract;
using KodlamaIo.DataAccess.Abstract;
using KodlamaIo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Business.Concretes;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        this.categoryDal = categoryDal;
    }

    public void Add(Category category)
    {
        categoryDal.Add(category);
    }

    public void Delete(int id)
    {
        categoryDal.Delete(id);
    }

    public List<Category> GetAll()
    {
        return categoryDal.GetAll();
    }

    public Category GetCategoryById(int id)
    {
        return categoryDal.GetCategoryById(id);
    }

    public void Update(Category category)
    {
        categoryDal.Update(category);
    }
}
