using OOP_03.DesignAndBuildOOPUniversity;

public class Run
{
    public static void run()
    {
        
    Instructor ist1= new Instructor(name:"John",birthDate:new DateTime(1998, 12, 25),salary:5000,joinDate:new DateTime(2023,11,13));
    Instructor ist2= new Instructor(name:"Terry",birthDate:new DateTime(1998, 12, 25),salary:3000,joinDate:new DateTime(2023,11,13));
    Student st1=new Student("Lucas",new DateTime(2008,12,25));
    Course calculus1 = new Course("CalculusI", ist2);
    Department MathsDep = new Department(3000, new DateTime(2000, 5, 6), new DateTime(2024, 6, 7));
    ist1.AssignDepartment(MathsDep);
    ist2.AssignDepartment(MathsDep);
    MathsDep.SetHead(ist1);
    MathsDep.AddCourse(calculus1);
    st1.EnrollInCourse(calculus1);
    }
    
}