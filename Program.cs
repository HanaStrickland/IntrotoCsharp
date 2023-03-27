int enterOption;

List<Student> students = new List<Student>();

do
{   Console.WriteLine("-  -  -  -  -  -  -  -  -  -  -  -  - ");
    Console.WriteLine("Student Club Management");
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. Delete Student");
    Console.WriteLine("3. Edit Student");
    Console.WriteLine("4. List Students");
    Console.WriteLine("5. Exit");
    Console.Write("\nSelect an option:   ");
    enterOption = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("-  -  -  -  -  -  -  -  -  -  -  -  - ");

   

    if (enterOption == 1)                                           // new student
    {
        Console.Write("Enter first Name:   ");
        string enterFirstName = Console.ReadLine();
        Console.Write("Enter last Name:    ");
        string enterLastName = Console.ReadLine();
        Console.Write("Enter email:        ");
        string enterEmail = Console.ReadLine();

        Student newStudent = new Student(enterFirstName,enterLastName,enterEmail);

        students.Add(newStudent);


    }
    else if (enterOption == 4)                                      // list students
    {
        int count = 1;

        if (students.Count == 0)
        {
            Console.WriteLine("There are no students in the list");
        }
        else
        {
            foreach (Student s in students)
            {
                Console.WriteLine($"{count++} {s.ToString()}");
            }
        }

        
    }
    else if (enterOption == 2)                                      // delete students
    {
        int count = 1;

        foreach (Student s in students)
        {
            Console.WriteLine($"{count++} {s.ToString()}");
        }
        Console.Write("Select an option:   ");

        int deleteOption = Convert.ToInt32(Console.ReadLine());

        int deleteOptionIndex = deleteOption - 1;

        if (deleteOption > students.Count)
        {
            Console.WriteLine("The number you entered is greater than the number of students in the list");
        }
        else
        {
            students.RemoveAt(deleteOptionIndex);
        }
        

    }
    else if (enterOption == 3)                                      // edit student
    {
        int count = 1;

        foreach (Student s in students)
        {
            Console.WriteLine($"{count++} {s.ToString()}");
        }
        Console.Write("Select an option:   ");
        int editOption = Convert.ToInt32(Console.ReadLine());
        int editOptionIndex = editOption - 1;

        int matchingCount = 0;

        if (editOption > students.Count)
        {
            Console.WriteLine("The number you entered is greater than the number of students in the list");
        }
        foreach(Student s in students)
        {
            if (matchingCount == editOptionIndex)
            {
                Console.Write("Enter first Name:   ");
                string editFirstName = Console.ReadLine();
                Console.Write("Enter last Name:    ");
                string editLastName = Console.ReadLine();
                Console.Write("Enter email:        ");
                string editEmail = Console.ReadLine();

                s.FirstName = editFirstName;
                s.LastName = editLastName;
                s.Email = editEmail;

                break;
            }
            else
            {
                matchingCount++;
            }
        }
    }

} while (enterOption != 5);




