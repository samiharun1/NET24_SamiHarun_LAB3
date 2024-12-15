using NET24_SamiHarun_LAB3.Data;

namespace NET24_SamiHarun_LAB3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            {
                bool runApp = true;
                using (var context = new SkolaContext())
                {
                    while (runApp)
                    {
                        // Skriv ut menyn
                        Console.Clear();
                        Console.WriteLine("Välkommen till Skola Applikationen");
                        Console.WriteLine("1. Visa alla studenter");
                        Console.WriteLine("2. Visa alla kurser");
                        Console.WriteLine("3. Visa alla betyg");
                        Console.WriteLine("4. Visa alla personal");
                        Console.WriteLine("5. Exit");
                        Console.Write("Välj ett alternativ (1-5): ");

                        string choice = Console.ReadLine();

                        switch (choice)
                        {
                            case "1":
                                ShowAllStudents(context);
                                break;
                            case "2":
                                ShowAllCourses(context);
                                break;
                            case "3":
                                ShowAllGrades(context);
                                break;
                            case "4":
                                ShowAllStaff(context);
                                break;
                            case "5":
                                runApp = false;
                                break;
                            default:
                                Console.WriteLine("Ogiltigt val, försök igen.");
                                break;
                        }
                    }
                }
            }

            // Visa alla studenter
            static void ShowAllStudents(SkolaContext context)
            {
                var students = context.Studenters.ToList();
                Console.Clear();
                Console.WriteLine("Alla Studenter:");
                foreach (var student in students)
                {
                    Console.WriteLine($"ID: {student.Id}, Namn: {student.Namn}, Klass: {student.Klass}");
                }
                Console.WriteLine("\nTryck på en tangent för att återgå till menyn.");
                Console.ReadKey();
            }

            // Visa alla kurser
            static void ShowAllCourses(SkolaContext context)
            {
                var courses = context.Kursers.ToList();
                Console.Clear();
                Console.WriteLine("Alla Kurser:");
                foreach (var course in courses)
                {
                    Console.WriteLine($"ID: {course.Id}, Kursnamn: {course.Kursnamn}");
                }
                Console.WriteLine("\nTryck på en tangent för att återgå till menyn.");
                Console.ReadKey();
            }

            // Visa alla betyg
            static void ShowAllGrades(SkolaContext context)
            {
                var grades = context.Betygs.ToList();
                Console.Clear();
                Console.WriteLine("Alla Betyg:");
                foreach (var grade in grades)
                {
                    Console.WriteLine($"ID: {grade.Id}, Betyg: {grade.Betyg1}, Datum: {grade.Datum}, StudentID: {grade.StudentId}, KursID: {grade.KursId}");
                }
                Console.WriteLine("\nTryck på en tangent för att återgå till menyn.");
                Console.ReadKey();
            }

            // Visa all personal
            static void ShowAllStaff(SkolaContext context)
            {
                var staff = context.Personals.ToList();
                Console.Clear();
                Console.WriteLine("Alla Personal:");
                foreach (var person in staff)
                {
                    Console.WriteLine($"ID: {person.Id}, Namn: {person.Namn}, Befattning: {person.Befattning}");
                }
                Console.WriteLine("\nTryck på en tangent för att återgå till menyn.");
                Console.ReadKey();
            }
        }
    }




}
    

//Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Skola;Integrated Security=True;Trust Server Certificate=False;
