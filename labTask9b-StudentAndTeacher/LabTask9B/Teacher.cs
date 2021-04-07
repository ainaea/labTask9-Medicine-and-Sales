namespace LabTask9B
{
    public class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {}
        public void Explain()
        {
            System.Console.WriteLine($"{Name} is explaining");
        }
    }
}