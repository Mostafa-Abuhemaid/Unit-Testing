namespace EMR
{
    public class BMICalculator
    {
        public double CalculatorBMI(double heigh, double wieght)
        {
            if(heigh == 0 || wieght==0) 
                return 0;

            else
            return wieght / (heigh*heigh);

        }
    }
}
