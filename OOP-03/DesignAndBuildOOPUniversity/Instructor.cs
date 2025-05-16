using  OOP_03.DesignAndBuildOOPUniversity;

public class Instructor : Person, IInstructorService
{
    private Department _department;
    private DateTime _joinDate;
    private bool _isHead;

    public Instructor(string name, DateTime birthDate, decimal salary, DateTime joinDate) 
        : base(name, birthDate, salary) 
    {
        _joinDate = joinDate;
    }

    public void AssignDepartment(Department department) => _department = department;
    
    public void SetAsHeadOfDepartment() => _isHead = true;
    
    public int CalculateExperienceYears() => DateTime.Now.Year - _joinDate.Year;
    
    public decimal CalculateBonusSalary() => CalculateExperienceYears() * 1000;
    
    public override decimal CalculateSalary() => _salary + (_isHead ? 5000 : 0) + CalculateBonusSalary();
}