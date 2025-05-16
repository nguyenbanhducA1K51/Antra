using  OOP_03.DesignAndBuildOOPUniversity;

public class Student : Person, IStudentService
{
    private Dictionary<Course, char> _courses;

    public Student(string name, DateTime birthDate, decimal salary = 0) 
        : base(name, birthDate, salary) { }

    public void EnrollInCourse(Course course) => _courses[course] = 'N'; // 'N' = Not graded yet

    public double CalculateGPA()
    {
        if (_courses.Count == 0) return 0;
        
        double totalPoints = 0;
        foreach (var grade in _courses.Values)
        {
            totalPoints += grade switch
            {
                'A' => 4,
                'B' => 3,
                'C' => 2,
                'D' => 1,
                _ => 0
            };
        }
        return totalPoints / _courses.Count;
    }
}