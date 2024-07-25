class Employee {

    protected string name;
    protected string email;
    protected string phone;
    protected string city;

    public Employee(string n, string e, string p, string c) {
        name = n;
        email = e;
        phone = p;
        city = c;
    }

    public string GetName() {
        return name;
    }

    public string GetEmail() {
        return email;
    }

    public string GetPhone() {
        return phone;
    }

    public string GetCity() {
        return city;
    }

    public void SetName(string n) {
        name = n;
    }
    public void SetEmail(string e) {
        name = e;
    }
    public void SetPhone(string p) {
        name = p;
    }
    public void SetCity(string c) {
        name = c;
    }

    public void DisplayEmp() {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Phone: {phone}");
        Console.WriteLine($"City: {city}\n");
    }

}