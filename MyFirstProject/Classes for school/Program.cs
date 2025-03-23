namespace Classes_for_school
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School hogwarts = new School();

            Group gryffindorYear1 = new Group();
            Group slytherinYear3 = new Group();

            hogwarts.Groups.Add(gryffindorYear1);
            hogwarts.Groups.Add(slytherinYear3);

            Student student1 = new Student();
            student1.Name = "Harry";
            student1.Surname = "Potter";
            student1.DateOfBirth = DateOnly.Parse("12.08.2000");
            student1.Group = gryffindorYear1;

            Student student2 = new Student();
            student2.Name = "Ginny";
            student2.Surname = "Weasley";
            student2.DateOfBirth = DateOnly.Parse("22.11.1999");
            student2.Group = gryffindorYear1;

            gryffindorYear1.Students.Add(student1);
            gryffindorYear1.Students.Add(student2);

            Subject transfiguration = new Subject("Transfiguration");
            Subject potions = new Subject("Potions");
            Subject spells = new Subject("Spells");

            hogwarts.Subjects = new List<Subject> { transfiguration, potions, spells };

            Teacher teacher1 = new Teacher();
            teacher1.Name = "Mrs. McGonagall";
            teacher1.DateOfBirth = DateOnly.Parse("20.02.1973");
            teacher1.Subject = transfiguration;
            teacher1.Group = gryffindorYear1;

            Teacher teacher2 = new Teacher();
            teacher2.Name = "Mr. Snape";
            teacher2.DateOfBirth = DateOnly.Parse("20.02.1973");
            teacher2.Subject = potions;
            teacher2.Group = slytherinYear3;

            hogwarts.Teachers = new List<Teacher> { teacher1, teacher2 };
        }
    }
}