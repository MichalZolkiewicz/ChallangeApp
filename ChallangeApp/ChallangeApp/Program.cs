using ChallangeApp;

Employee employee1 = new Employee("Michal", "Zolkiewicz", 32);

int gradeInt = 1;
double gradeDouble = 2.5;

employee1.AddGrade("Michał");
employee1.AddGrade("101");
employee1.AddGrade('5');
employee1.AddGrade('k');
employee1.AddGrade(gradeInt);
employee1.AddGrade(gradeDouble);
employee1.AddGrade(5);
employee1.AddGrade(5);

var statistics = employee1.GetStatistics();

Console.WriteLine();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");