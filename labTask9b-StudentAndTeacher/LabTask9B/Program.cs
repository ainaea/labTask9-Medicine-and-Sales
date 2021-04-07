using System;

namespace LabTask9B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name of teacher");
            string teacher = Console.ReadLine();

            Console.WriteLine("Enter name of student1");
            string student1 = Console.ReadLine();

            Console.WriteLine("Enter name of student2");
            string student2 = Console.ReadLine();

            Teacher teacherObj = new Teacher(teacher);
            Student student1Obj = new Student(student1);
            Student student2Obj = new Student(student2);

            Person[] persons = {teacherObj, student1Obj, student2Obj};

            teacherObj.Explain();
            student1Obj.Study();
            student2Obj.Study();
        }
    }
}
