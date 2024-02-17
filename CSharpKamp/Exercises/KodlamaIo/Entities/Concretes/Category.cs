using KodlamaIo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Entities.Concretes;

public class Category : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Category()
    {
            
    }

    public Category(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
