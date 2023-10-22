using ChallangeApp;

Employee employee1 = new Employee("Michal", "Zolkiewicz", 32);
Employee employee2 = new Employee("Jan", "Kowalski", 40);
Employee employee3 = new Employee("Tomasz", "Nowak", 25);

employee1.AddGrade(1);
employee1.AddGrade(5);
employee1.AddGrade(5);

employee2.AddGrade(8);
employee2.AddGrade(5);
employee2.AddGrade(5);

employee3.AddGrade(10);
employee3.AddGrade(5);
employee3.AddGrade(3);

List<Employee> employees = new List<Employee>
{
    employee1, employee2, employee3
};

List<Employee> employeesWithSameScore = new List<Employee>();

float maxResult = -1;
Employee employeeWithMaxResult = null;

foreach(var employee in employees)
{
    if(employee.Result > maxResult)
    {
       
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
    else if (employee.Result == maxResult)
    {
        employeesWithSameScore.Add(employee);
    }
}

Console.WriteLine(employeeWithMaxResult.Name);
Console.WriteLine(employeeWithMaxResult.Surname);
Console.WriteLine(employeeWithMaxResult.Age);

foreach(var employee in employeesWithSameScore)
{
    Console.WriteLine();
    Console.WriteLine("Employees with the same score:");
    Console.WriteLine();
    Console.WriteLine(employee.Name);
    Console.WriteLine(employee.Surname);
    Console.WriteLine(employee.Age);
}

var statistics = employee1.GetStatistics();

Console.WriteLine();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");