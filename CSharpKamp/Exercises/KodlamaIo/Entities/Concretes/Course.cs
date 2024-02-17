using KodlamaIo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Entities.Concretes;

public class Course : IEntity
{
    public int Id { get; set; }
    public int InstructorId { get; set; }
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public Course()
    {
        
    }

    public Course(int id, int ınstructorId, int categoryId, string name, string description)
    {
        Id = id;
        InstructorId = ınstructorId;
        CategoryId = categoryId;
        Name = name;
        Description = description;
    }
}
