
// This this my parent class called Person.
class Person
{
    private string name;
    public Person(string name)
    {
        this.name = name;
    }
    // My virtual public allows the string toString() to be overwritten by the class or Program. 
    public virtual string toString()
    {
        return "Name: " + name;
    }
}
// This is my child which inherits the varables of the parent: Person.
class Employe : Person
{
    private int employeeID;
    public Employe(string name, int employeeID) : base(name)
    {
        this.employeeID = employeeID;
    }
    // This is designed to override the toString() method in Person as the program allows the exception with of virtual. 
    public override string toString()
    {
        return "Employee ID: " + employeeID + " " + base.toString();
    }

}

// The class of Program allows to make an instance of employee, so that it can override Person. 
class Program
{
    public static void Main(string[] args)
    {
        Employe employe = new Employe("James", 294573490);
        Console.WriteLine(employe.toString());
    }
}