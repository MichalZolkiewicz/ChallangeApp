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
            employee.AddGrade(-1);
            employee.AddGrade(-8);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(0, result); 
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
    }
}