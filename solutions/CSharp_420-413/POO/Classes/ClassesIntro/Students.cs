using System;
using System.Collections.Generic;

namespace CSharp_420_413.POO.Classes.ClassesIntro
{
    internal class Student
    {
        public int Id { get; private set; }
        public int Age { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student(int id, string firstName, string lastName, int age, string subject)
        {
            this.Id = id;
            this.Age = age;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Subject = subject;

        }

        public string FullName { get { return $"{FirstName} {LastName}"; } }
        public string Subject
        {
            get => _subject;
            set => _subject = (!string.IsNullOrWhiteSpace(value)) ? value : throw new ArgumentException("First name must not be blank");
        }
        private string _subject;

        public void ShowInfo()
        {
            Console.WriteLine($"Student id: {Id}\nStudent name: {FullName}\n" +
                $"Student age: {Age}\nStudent sugject: {Subject}\n");
        }
    }

    class StudentsGenertor
    {
        Student student1 = new Student(001, "Lee", "Jack", 23, "Math");
        Student student2 = new Student(001, "Poter", "Harry", 27, "Science");
        Student student3 = new Student(001, "Farouki", "Omnia", 25, "Programming");
        Student student4 = new Student(001, "Nassiri", "Ahmed", 22, "English");

        public List<Student> StudentsList()
        {
            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);

            return students;
        }

        public void DisplayStudentsList()
        {
            foreach (var student in StudentsList())
            {
                student.ShowInfo();
            }
        }
    }
}
