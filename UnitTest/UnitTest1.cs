namespace UnitTest
{
    public class UnitTest1
    {
        [Fact] // decorated with attribute
        public void Test1()
        {
            //Arrenge
            Calculation calculation = new Calculation();

            int a = 5;
            int b = 10;
            int expected = 15;

            //Act
            int actual = calculation.Add(a, b);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
