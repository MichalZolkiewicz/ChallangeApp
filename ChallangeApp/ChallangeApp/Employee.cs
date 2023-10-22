﻿namespace ChallangeApp
{
    public class Employee
    {

        private List<float> grades = new List<float>();
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public int Age { get; private set; }

        public float Result
        {
            get
            {
                return this.grades.Sum();
            }
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }            
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }

        public void AddGrade(char grade)
        {
            if (float.TryParse(grade.ToString(), out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("Char is not float");
            }
        }

        public void AddGrade(int grade)
        {
            float value = (float)grade;
            this.AddGrade(value);
        }

        public void AddGrade(double grade)
        {
            float value = (float)grade;
            this.AddGrade(value); 
        }

        public void RemoveGrade(float grade)
        {
            this.grades.Remove(grade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades) 
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average = statistics.Average / this.grades.Count;
            return statistics;
        }
    }
}
