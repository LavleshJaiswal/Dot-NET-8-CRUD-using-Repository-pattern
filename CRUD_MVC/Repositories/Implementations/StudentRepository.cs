using CRUD_MVC.Helper;
namespace CRUD_MVC.Repositories.Implementations;

public class StudentRepository :Repository<Student>, IStudentRepository
{
    public StudentRepository(SchoolDbContext context) : base(context) { }
}
