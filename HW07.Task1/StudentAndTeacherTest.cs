namespace HW07.Task1
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SayHello();

            var student = new Student();
            student.SetAge(21);
            student.SayHello();
            student.ShowAge();

            var teacher = new Teacher();
            teacher.SetAge(30);
            teacher.SayHello();
            teacher.Explain();
        }
    }
}
