namespace UnitTest
{
    public class UnitTest1
    {
        [Fact] // decorated with attribute
        public void Test1()
        {
            //Arrenge --> Declare and initialize the variables
            Calculation calculation = new Calculation();

            int a = 5;
            int b = 10;
            int expected = 15;

            //Act --> Call the method to be tested
            int actual = calculation.Add(a, b);

            //Assert --> Verify/Compare the result
            Assert.Equal(expected, actual);
        }
    }
}
