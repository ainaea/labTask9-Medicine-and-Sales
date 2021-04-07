namespace LabTask9B
{
    public class Student : Person
    {
        public Student(string name) : base(name)
        {}

        public void Study()
        {
            System.Console.WriteLine($"{Name} is studying");
        }
    }
}