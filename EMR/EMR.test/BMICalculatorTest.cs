namespace EMR.test
{
    public class BMICalculatorTest
    {
        [Fact]
        public void BMICalculator_WhenHieghIsGreaterThanZeroAndWieghtIsGreaterThanZero_ShouldCalcilatBMI()
        {
            //arrange 
         var BMI = new BMICalculator();

            //Act
            var res = Math.Round( BMI. CalculatorBMI(1.73, 80),2);

            //Assert 

            Assert.Equal(26.73, res);

        }
        [Fact]
        public void BMICalculator_WhenHieghIsEqualZeroAndWieghtIsEqualZero_ShouldReturnZero()
        {
            //arrange 
            var BMI = new BMICalculator();

            //Act
            var res = Math.Round(BMI.CalculatorBMI(0, 0), 2);

            //Assert 

            Assert.Equal(0, res);

        }
    }
}