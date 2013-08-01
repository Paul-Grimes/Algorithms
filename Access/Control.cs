namespace Access
{
    using System;
    using System.Collections.Generic;
    
    public class Control
    {
        public double Variance(double[] values)
        {
            var algorithm = new Variance.General();
            return algorithm.simple_variance(values);
        }

        public double StandardDeviation(double[] values)
        {
            var algorithm = new StandardDeviation.General();
            return algorithm.SimpleStandardDeviation(values);
        }

        public double FutureValueSimpleInterest(double presentValue, double rate, int time)
        {
            var algorithm = new FutureValue.General();
            return algorithm.SimpleInterest(presentValue, rate, time);
        }

        public double FutureValueCompoundInterest(double presentValue, double rate, int time)
        {
            var algorithm = new FutureValue.General();
            return algorithm.CompoundInterest(presentValue, rate, time);
        }
    }
}
