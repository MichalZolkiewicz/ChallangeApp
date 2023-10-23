namespace ChallangeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeColletScores_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Micha³", "Zolkiewicz", 32);
            employee.AddGrade(4);
            employee.AddGrade(5);
            employee.AddGrade(100);
            employee.AddGrade(50);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(159, result); 
        }

        [Test]
        public void WhenScoreIsRemoved_ShouldCorrectResult()
        {
            //arrange
            var employee = new Employee("Micha³", "Zolkiewicz", 32);

            //act
            employee.AddGrade(4);
            employee.AddGrade(5);
            employee.RemoveGrade(5);
            employee.RemoveGrade(4);

            //assert
            Assert.AreEqual(0, employee.Result);
        }

        [Test]
        public void WhenGetStatisticsUsed_ShouldReturnCorrectMinValue ()
        {
            var employee = new Employee("Micha³", "Zolkiewicz", 32);


            employee.AddGrade(4.16f);
            employee.AddGrade(3.14f);
            employee.AddGrade(2);
            employee.AddGrade(4);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(2, statistics.Min);
        }

        [Test]
        public void WhenGetStatisticsUsed_ShouldReturnCorrectMaxValue()
        {
            var employee = new Employee("Micha³", "Zolkiewicz", 32);


            employee.AddGrade(4.16f);
            employee.AddGrade(3.14f);
            employee.AddGrade(2);
            employee.AddGrade(4);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(4.16f, statistics.Max);
        }

        [Test]
        public void WhenGetStatisticsUsed_ShouldReturnCorrectAvgValue()
        {
            var employee = new Employee("Micha³", "Zolkiewicz", 32);


            employee.AddGrade(4.16f);
            employee.AddGrade(3.14f);
            employee.AddGrade(2);
            employee.AddGrade(4);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(3.325f, statistics.Average);
        }

        [Test]
        public void WhenLettersAreInput_ShouldReturnCorrectResult()
        {
            // arrange
            var employee = new Employee("Micha³", "Zolkiewicz", 32);
            employee.AddGrade('A');
            employee.AddGrade("a");
            employee.AddGrade('B');
            employee.AddGrade("C");
            employee.AddGrade('d');
            employee.AddGrade("E");


            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(66,66, Math.Round(result.Average, 2));
        }

        [Test]
        public void WhenGradesAreInput_ShouldReturnCorrectAvgLetter()
        {
            // arrange
            var employee = new Employee("Micha³", "Zolkiewicz", 32);
            employee.AddGrade(90);
            employee.AddGrade(60);
            employee.AddGrade(95);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual('A', result.AverageLetter);
        }

        [Test]
        public void WhenLettersAreInput_ShouldReturnCorrectAvgLetter()
        {
            // arrange
            var employee = new Employee("Micha³", "Zolkiewicz", 32);
            employee.AddGrade('A');
            employee.AddGrade("a");
            employee.AddGrade('B');

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual('A', result.AverageLetter);
        }
    }
}