using System;
using System.Diagnostics;

namespace aug1_assignment
{
    public class Student
    {
        public string name;
        public int age;
        public int standard;
        public Guid studentId;

        //CONSTRUCTOR
        public Student()
        {
        }

        public void setInfo()
        {
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter standard: ");
            standard = Convert.ToInt32(Console.ReadLine());
            studentId = Guid.NewGuid();
        }
        public void displayInfoRow()
        {
            Console.WriteLine(name + "\t" + age + "\t" + standard + "\t\t" + studentId);
        }
    }

    class aug1_assignment
    {
        public static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();
            //STOPWATCH BEGINS
            stopwatch.Start();

            int choice = 0, numOfStudents, i, num, sum = 0;
            decimal length, width;
            string timeTaken;

            while (choice != 4)
            {
                Console.WriteLine("\nPress 1: Rectangle, 2: Student, 3: Pow4, 4: Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("RECTANGLE PROGRAM");
                        Console.Write("Enter length: ");
                        length = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Enter width: ");
                        width = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Area of rectangle: " + length * width);
                        Console.WriteLine("Perimeter of rectangle: " + (2 * (length + width)));
                        break;
                    case 2:
                        Student[] obj = new Student[5];
                        Console.WriteLine("STUDENT PROGRAM");
                        Console.WriteLine("Enter number of students: (max 5)");
                        numOfStudents = Convert.ToInt32(Console.ReadLine());
                        if (numOfStudents > 5)
                        {
                            Console.WriteLine("Maximum allowed value is 5. Resetting to 5.");
                        }
                        for (i = 0; i < numOfStudents; ++i)
                        {
                            obj[i] = new Student();
                            Console.WriteLine("\nEnter info for student " + (i + 1));
                            obj[i].setInfo();
                        }
                        Console.Clear();
                        Console.WriteLine("NAME\tAGE\tSTANDARD\tSTUDENT-ID");
                        for (i = 0; i < numOfStudents; ++i)
                        {
                            obj[i].displayInfoRow();
                        }
                        break;
                    case 3:
                        Console.WriteLine("POWER OF 4 PROGRAM");
                        Console.WriteLine("Enter a number between 1 and 50");
                        num = Convert.ToInt32(Console.ReadLine());
                        if (num < 1 || num > 50)
                        {
                            Console.WriteLine("Only numbers between 1 and 50 are valid.");
                            break;
                        }
                        for (i = num; i <= num + 10; ++i)
                        {
                            sum = sum + Convert.ToInt32(Math.Pow(i, 4));
                        }
                        Console.WriteLine("Equation: ");
                        for (i = num; i <= num + 10; ++i)
                        {
                            if (i == num + 10)
                            {
                                Console.Write(i + "^4");
                            }
                            else
                            {
                                Console.Write(i + "^4 + ");
                            }
                        }
                        Console.WriteLine("\nSum: " + sum);

                        break;
                    case 4:
                        Console.WriteLine("Thank you for using.");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
            //STOPWATCH STOPS
            stopwatch.Stop();

            //PRINTING EXECUTION TIME
            Console.WriteLine("Time of execution (HRS\\MINS\\SECONDS): " + stopwatch.Elapsed);

            //GIT TEST
        }
    }
}