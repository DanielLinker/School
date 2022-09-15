using System;


using System;
using System.Collections.Generic;


namespace School
{
     public class Student
     {
          public string FirstName;
          public string LastName;
          public Student(string firstName, string lastName)
          {
               FirstName = firstName;
               LastName = lastName;
          }
     }
	
     public class School
     {
          public string Name;
          public List<Student> Students;

          public School(string name)
          {
               Name = name;
               Students = new List<Student>();
          }

          public void PrintStudents()
          {
               if (Students.Count == 0)
               {
                    Console.WriteLine($"In der Schule {Name} Gibts Noch keine Schüler!");
               }
               else
               {
                    Console.WriteLine("{0, -10} {1, -10}", "Vorname", "Nachname");
                    for (int i = 0; i < Students.Count; i++)
                    {
                         Console.WriteLine("{0, -10} {1, -10}", Students[i].FirstName, Students[i].LastName);
                    }
               }
          }

           public void AddNewStudent(Student student)
           {
                Students.Add(student);
                Console.WriteLine($"Student {student.FirstName} wurde hinzugefügt in die Schule {Name}.");
           }
     }
     
     class Program
     {
          public static void Main(string[] args)
          {
               Console.WriteLine("Gib von deine Schule denn Namen ein!!");
               string schoolName = Console.ReadLine();
               School school = new School(schoolName);
               Console.WriteLine($"Schule {school.Name} Wurde hinzugefügt");

               while (true)
               {
                    Console.WriteLine($"Willst du die Namen  von der Schule  {school.Name}? Ausgeben Gib ein Ja oder Nein ");
                    string userAnswer = Console.ReadLine();
                    
                    if (userAnswer == "Ja")
                    {
                         school.PrintStudents();
                    }
                    
                    
                    Console.WriteLine($"Willst du neue Schüller hinzufügen {school.Name}? Gib Ja oder Nein ein!! ");
                    userAnswer = Console.ReadLine();
                    
                    if (userAnswer == "Ja")
                    {
                         Console.WriteLine($"Füge Namen von Schüler ein!!");
                         string firstName = Console.ReadLine();
                         Console.WriteLine($"Füge jetzt denn Nachnamen ein");
                         string lastName = Console.ReadLine();

                         Student student = new Student(firstName, lastName);
                         school.AddNewStudent(student);
                    }
               }
          }
     }
}

    





  




