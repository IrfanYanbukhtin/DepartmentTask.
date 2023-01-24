using PracticeOne._1.Models;
using PracticeOne._1.Services;
using PracticeOne._1.Services.Contracts;


namespace PracticeOne._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager();
            TeacherManager teacherManager = new TeacherManager();
            string command = "";

            Console.WriteLine("Choice your menu!");
            string choice = Console.ReadLine();

            if (choice.ToLower().Equals("student menu"))
            {
                do
                {
                    Console.WriteLine("----------------------------------------------------------");
                    Console.Write("Enter the command:");
                    command = Console.ReadLine();

                    if (command.ToLower().Equals("add student"))
                    {
                        var student1 = new Student
                        {
                            Id = 1,
                            Firstname = "Elvin",
                            Lastname = "Cebrayilov",
                            Age = 25,
                            Course = 2,
                            EntryDate = DateTime.Now,
                            Group = new Group
                            {
                                Id = 1,
                                Name = "P329",
                            },
                        };
                        var student2 = new Student
                        {
                            Id = 2,
                            Firstname = "Sahlar",
                            Lastname = "Haciyev",
                            Age = 24,
                            Course = 1,
                            EntryDate = DateTime.Now,
                            Group = new Group
                            {
                                Id = 1,
                                Name = "P329",
                            },
                        };

                        studentManager.Add(student1);
                        studentManager.Add(student2);

                    }
                    else if (command.ToLower().Equals("print students"))
                    {
                        studentManager.Print();
                    }
                    else if (command.ToLower().Equals("delete student"))
                    {
                        Console.Write("Enter the id:");
                        var id = int.Parse(Console.ReadLine());

                        studentManager.Delete(id);
                    }
                    else if (command.ToLower().Equals("update student"))
                    {
                        Console.Write("Enter the id:");
                        var id = int.Parse(Console.ReadLine());

                        var existStudent = studentManager.Get(id);

                        if (existStudent == null)
                            continue;

                        Console.WriteLine(existStudent);

                        var student2 = new Student
                        {
                            Id = 2,
                            Firstname = "Sahlar",
                            Lastname = "Haciyev",
                            Age = 25,
                            Course = 1,
                            EntryDate = DateTime.Now,
                            Group = new Group
                            {
                                Id = 1,
                                Name = "P329",
                            },
                        };

                        studentManager.Update(id, student2);
                    }

                } while (command.ToLower() != "quit");
            }
            else if (choice.ToLower().Equals("teacher menu"))
            {

                do
                {
                    Console.WriteLine("----------------------------------------------------------");
                    Console.Write("Enter the command:");
                    command = Console.ReadLine();

                    if (command.ToLower().Equals("add teacher"))
                    {
                        var teacher1 = new Teacher
                        {
                            Id = 1,
                            Firstname = "Sevil",
                            Lastname = "Muradova",
                            Age = 27,
                            EntryDate = DateTime.Now,
                            StudySubjects = "Math",

                            Groups = new Group[]
                           {
                           new Group { Id = 1, Name="P329"},
                           new Group { Id = 2, Name="P311"},
                           new Group { Id = 3, Name="P222"},
                           new Group { Id = 4, Name="P333"}
                           },
                        };

                        var teacher2 = new Teacher
                        {
                            Id = 2,
                            Firstname = "Elmira",
                            Lastname = "Eyvazova",
                            Age = 30,
                            EntryDate = DateTime.Now,
                            StudySubjects = "Informatics",

                            Groups = new Group[]
                           {
                           new Group { Id = 5, Name="P229"},
                           new Group { Id = 6, Name="P211"},
                           new Group { Id = 7, Name="P233"},
                           new Group { Id = 8, Name="P244"}
                           },
                        };
                        teacherManager.Add(teacher1);
                        teacherManager.Add(teacher2);
                    }
                    else if (command.ToLower().Equals("print teachers"))
                    {
                        teacherManager.Print();
                    }
                    else if (command.ToLower().Equals("delete teacher"))
                    {
                        Console.Write("enter id");
                        var id = int.Parse(Console.ReadLine());
                        teacherManager.Delete(id);
                    }
                    else if (command.ToLower().Equals("update teacher"))
                    {
                        Console.Write("enter id:");
                        var id = int.Parse(Console.ReadLine());
                        var existTeacher = teacherManager.Get(id);

                        if (existTeacher == null)
                        {
                            Console.WriteLine("Bu Id'de bir muellim yoxdur!");
                        }
                        else
                        {

                            Console.WriteLine(existTeacher);

                            var teacher1 = new Teacher
                            {
                                Id = 1,
                                Firstname = "Emil",
                                Lastname = "Cafarov",
                                Age = 31,
                                EntryDate = DateTime.Now,
                                StudySubjects = "Math",

                                Groups = new Group[]
                           {
                           new Group { Id = 1, Name="P329"},
                           new Group { Id = 2, Name="P422"},
                           new Group { Id = 3, Name="P3433"},
                           new Group { Id = 4, Name="P444"}
                           },
                            };
                            teacherManager.Update(id, teacher1);
                        }



                    }

                } while (command.ToLower() != "quit");



            }

        }
    }
}