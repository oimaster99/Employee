class Program 
{
    static void Main(string[] args) 
    {
        string choice = "0";
        EmpSystem system = new EmpSystem();


        Console.WriteLine("Hello, World!");
        while (true) {
            if (choice == "4") {
                return;
            }
            choice = "0";
            Console.WriteLine("\nWelcome to Employee Management System!");
            Console.WriteLine("1). Add Employee");
            Console.WriteLine("2) Remove Employee");
            Console.WriteLine("3) Display Employees");
            Console.WriteLine("4) Exit.");

            Console.Write("Type your Choice in: ");
            choice = Console.ReadLine();

            switch (choice) {
                case "1":
                    system.AddEmployeeSystem();
                    break;
                case "2":
                    system.RemoveEmployeeSystem();
                    break;
                case "3":
                    system.DisplayEmployees();
                    break;
                case "4":
                    break;
                default:
                    break;
            }
        }
    }

}

// See https://aka.ms/new-console-template for more information
