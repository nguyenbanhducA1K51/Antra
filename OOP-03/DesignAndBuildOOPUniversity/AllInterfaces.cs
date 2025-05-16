namespace OOP_03.DesignAndBuildOOPUniversity;

public class AllInterfaces
{
    
}

public interface IPersonService
{
    int CalculateAge();
    decimal CalculateSalary();
    List<string> GetAddresses();
}

public interface IStudentService : IPersonService
{
    void EnrollInCourse(Course course);
    double CalculateGPA();
}

public interface IInstructorService : IPersonService
{
    void AssignDepartment(Department department);
    void SetAsHeadOfDepartment();
    decimal CalculateBonusSalary();
}

public interface ICourseService
{
    void AddStudent(Student student);
    void AssignGrade(Student student, char grade);
}

public interface IDepartmentService
{
    void SetHead(Instructor instructor);
    void AddCourse(Course course);
    decimal CalculateBudgetRemaining();
}