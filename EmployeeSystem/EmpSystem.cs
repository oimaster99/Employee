using System.Net;

class EmpSystem {

    public List<Employee> Employees;

    public EmpSystem() {
        Employees = new List<Employee>();
    }

    public void AddEmployee(Employee emp) {
        Employees.Add(emp);
        Console.WriteLine($"{emp.GetName()} was Added to the system.");
    }

    public int RemoveEmployee(string name) {
        for(int i = 0; i <= Employees.Count - 1; i++) {
            if(Employees[i].GetName() == name) {
                string MarkedEmployee = Employees[i].GetName();
                Employees.RemoveAt(i);
                Console.WriteLine($"{MarkedEmployee} was removed from the system.");
                return 1;
            }
        }
        Console.WriteLine("Could not find Employee.");
        return 0;
    }

    public void DisplayEmployees() {
        foreach(Employee emp in Employees) {
            emp.DisplayEmp();
        }
    }

    public void AddEmployeeSystem() {
        Console.Write("Enter the name of the Employee: ");
        string name = Console.ReadLine();
        Console.Write("\nEnter the email of the Employee: ");
        string email = Console.ReadLine();
        Console.Write("\nEnter the phone of the Employee: ");
        string phone = Console.ReadLine();
        Console.Write("\nEnter the city of the Employee: ");
        string city = Console.ReadLine();

        Employee employee = new Employee(name, email, phone, city);
        Employees.Add(employee);
    }

    public void RemoveEmployeeSystem() {
        while (true) {
            Console.Write("Enter the name of the employee you want to remove: ");
            string employeeName = Console.ReadLine();
            if (RemoveEmployee(employeeName) == 1) {
                return;
            }
            else {
                Console.Write("\nTry again?(y/n): ");
                string response = Console.ReadLine();
                if (response.Equals("n")) {
                    return;
                }
            }
        }
    }

}