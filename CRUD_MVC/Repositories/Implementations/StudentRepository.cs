using System;
using CRUD_MVC.Helper;
using CRUD_MVC.Models;
using CRUD_MVC.Repositories.Interfaces;

namespace CRUD_MVC.Repositories.Implementations;

public class StudentRepository :Repository<Student>, IStudentRepository
{
    public StudentRepository(SchoolDbContext context) : base(context) { }
}
