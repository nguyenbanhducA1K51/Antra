using  OOP_03.DesignAndBuildOOPUniversity;

public class Course : ICourseService
{
    private List<Student> _students = new List<Student>();
    private Dictionary<Student, char> _grades = new Dictionary<Student, char>();
    private Instructor _instructor;
    public string Name { get; private set; }

    public Course(string name, Instructor instructor)
    {
        Name = name;
        _instructor = instructor;
    }
    public Instructor GetInstructor() => _instructor;
    
    public void AddStudent(Student student) => _students.Add(student);

    public void AssignGrade(Student student, char grade)
    {
        if (!_students.Contains(student)) 
            throw new ArgumentException("Student not enrolled in this course.");
        
        _grades[student] = grade;
    }
}