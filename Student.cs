// See https://aka.ms/new-console-template for more information
internal class Student
{
    public string name;
    public int grade;

    public override string ToString()
    {
        return this.name + " : " + this.grade;
    }
    
}