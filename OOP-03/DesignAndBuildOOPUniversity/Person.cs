using OOP_03.DesignAndBuildOOPUniversity;

public abstract class Person : IPersonService
{
    private string _name;
    private DateTime _birthDate;
    private List<string> _addresses = new List<string>();
    protected decimal _salary;

    public Person(string name, DateTime birthDate, decimal salary)
    {
        if (salary < 0) throw new ArgumentException("Salary cannot be negative.");
        
        _name = name;
        _birthDate = birthDate;
        _salary = salary;
    }

    // Encapsulation: Private fields with controlled access
    public string Name => _name;
    public DateTime BirthDate => _birthDate;
    
    public int CalculateAge() => DateTime.Now.Year - _birthDate.Year;
    
    public virtual decimal CalculateSalary() => _salary;
    
    public void AddAddress(string address) => _addresses.Add(address);
    
    public List<string> GetAddresses() => new List<string>(_addresses); // Return a copy for encapsulation
}