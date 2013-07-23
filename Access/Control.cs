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
    }
}
