using KodlamaIo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Entities.Concretes;

public class Instructor : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string City { get; set; }


    public Instructor()
    {
        
    }

    public Instructor(int id, string firstName, string lastName, string email, string city)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        City = city;
    }
}
