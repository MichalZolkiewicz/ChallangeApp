namespace ChallangeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeColletScores_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Micha³", "Zolkiewicz", 32);
            employee.AddScore(4);
            employee.AddScore(5);
            employee.AddScore(-1);
            employee.AddScore(-8);

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
            employee.AddScore(4);
            employee.AddScore(5);
            employee.RemoveScore(5);
            employee.RemoveScore(4);

            //assert
            Assert.AreEqual(0, employee.Result);
        }
    }
}