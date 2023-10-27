using System.Diagnostics;

namespace ChallangeApp
{
    public class EmployeeInFile : EmployeeBase
    {

        public override event GradeAddedDelegate GradeAdded;

        private const string fileName = "grades.txt";
        public EmployeeInFile(string name, string surname, int age) 
            : base(name, surname, age)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                    if(GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
            
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char charResult))
            {
                this.AddGrade(charResult);
            }
            else
            {
                throw new Exception("String is not float");
            }
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Letter!");
            }
        }

        public override void AddGrade(int grade)
        {
            float value = (float)grade;
            this.AddGrade(value);
        }

        public override void AddGrade(double grade)
        {
            float value = (float)grade;
            this.AddGrade(value);
        }

        private List<float> GetGradesFromFile()
        {
            var grades = new List<float>();
            if(File.Exists($"{fileName}"))
            {
                using(var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while(line != null)
                    {
                        float grade = float.Parse(line);
                        grades.Add(grade);
                        line = reader.ReadLine();   
                    }
                }
            }
            return grades;
        }

        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }

        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.GetGradesFromFile();
            var statistics = this.CountStatistics(gradesFromFile);
            return statistics;
        }
    }
}
