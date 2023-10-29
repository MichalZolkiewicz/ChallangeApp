using static ChallangeApp.EmployeeBase;

namespace ChallangeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        int Age { get; } 
        void AddGrade(float grade);
        void AddGrade(string grade);
        void AddGrade(char grade);
        void AddGrade(int grade);   
        void AddGrade(double grade);

        event GradeAddedDelegate GradeAdded;
        Statistics GetStatistics();
    }
}
