using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases_Exam
{
    public class UserInterface
    {
        private readonly BusinessLogic _businessLogic;
        public UserInterface()
        {
            _businessLogic = new BusinessLogic();
        }

        public void Control()
        {
            Console.WriteLine("Welcome to students info system");
            Console.ReadLine();

            bool repeat = true;
            string userInput;

            while (repeat)
            {
                Console.Clear();
                Console.WriteLine("MENIU\n[1]-Add\n[2]-Show All\n[3]-Show By\n[4]-Assign\n[5]-Exit");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        CreateEntity();
                        break;
                    case "2":
                        Console.Clear();
                        ShowEntities();
                        break;
                    case "3":
                        Console.Clear();
                        
                        break;
                    case "4":
                        Console.Clear();
                        
                        break;
                    case "5":
                        Console.Clear();
                        repeat = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong input, try again");
                        Console.ReadLine();
                        break;
                }
            }
        }
        public void CreateEntity()
        {
            bool repeat = true;
            string userInput;

            while (repeat)
            {
                Console.Clear();
                Console.WriteLine("Select what do you want to add:\n[1]-Department\n[2]-Lecture\n[3]-Student\n[4]-Return");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Enter department's name:");
                        string DepartmentName = Console.ReadLine();
                        _businessLogic.CreateDepartment(DepartmentName);
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Enter lectures's name:");
                        string lectureName = Console.ReadLine();
                        Console.WriteLine("Enter lecture's amount of credits:");
                        int credits = Int32.Parse(Console.ReadLine());
                        _businessLogic.CreateLecture(lectureName, credits);
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Enter student's name:");
                        string studentName = Console.ReadLine();
                        Console.WriteLine("Enter student's age:");
                        int age = Int32.Parse(Console.ReadLine());
                        _businessLogic.CreateStudent(studentName, age);
                        break;
                    case "4":
                        Console.Clear();
                        Console.Clear();
                        repeat = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong input, try again");
                        Console.ReadLine();
                        break;
                }
            }
        }
        public void ShowEntities()
        {
            bool repeat = true;
            string userInput;

            while (repeat)
            {
                Console.Clear();
                Console.WriteLine("Select what do you want to see:\n[1]-All departments\n[2]-All lectures\n[3]-All students\n[4]-Return");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        _businessLogic.ShowDepartments();
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.Clear();
                        _businessLogic.ShowLectures();
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Clear();
                        _businessLogic.ShowStudents();
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.Clear();
                        Console.Clear();
                        repeat = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong input, try again");
                        Console.ReadLine();
                        break;
                }
            }
        }
        public void Assign()
        {

        }
    }
}
