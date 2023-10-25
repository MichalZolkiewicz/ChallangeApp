namespace ChallangeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenTwoDifferentInts_ShouldNotBeEqual()
        {
            // arrange
            int number1 = 1;
            int number2 = 2;

            // assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void WhenTwoSameFloats_ShouldBeEqual()
        {
            // arrange
            float number1 = 10;
            float number2 = 10;

            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void WhenTwoDifferentDoubles_ShouldNotBeEqual()
        {
            // arrange
            double number1 = 3.14;
            double number2 = 2.56;

            // assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void GetEmployeeShouldReturnDifferentObjects()
        {
            // arrange
            var employee1 = GetEmployee("Michal", "Zolkiewicz", 32);
            var employee2 = GetEmployee("Tomasz", "Nowak", 40);

            // assert
            Assert.AreNotEqual(employee1, employee2);   
        } 

        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}
