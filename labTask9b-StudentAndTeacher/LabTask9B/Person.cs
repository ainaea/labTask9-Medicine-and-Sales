namespace LabTask9B
{
    public class Person
    {
        protected string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"My name is {Name}";
        }
    }
}