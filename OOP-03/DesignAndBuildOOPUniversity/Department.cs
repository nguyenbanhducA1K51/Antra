using OOP_03.DesignAndBuildOOPUniversity;

public class Department : IDepartmentService
{
    private Instructor _head;
    private List<Course> _courses;
    private decimal _budget;
    private DateTime _budgetStartDate;
    private DateTime _budgetEndDate;

    public Department(  decimal budget, DateTime startDate, DateTime endDate)
    {
        _budget = budget;
        _budgetStartDate = startDate;
        _budgetEndDate = endDate;
    }

    
    public void SetHead(Instructor instructor) => _head = instructor;
    
    public void AddCourse(Course course) => _courses.Add(course);
    
    public decimal CalculateBudgetRemaining() => _budget - _courses.Sum(c => c.GetInstructor()?.CalculateSalary() ?? 0);
    
}