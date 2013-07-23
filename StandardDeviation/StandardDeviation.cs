namespace StandardDeviation
{
    using System;
    using Variance;

    public class General
    {
        public double SimpleStandardDeviation(double[] values)
        {
            var algorithm = new Variance.General();

            return Math.Sqrt(algorithm.simple_variance(values));
        }
    }
}
