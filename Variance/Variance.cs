namespace Variance
{
    using System;

    public class General
    {
        public double simple_variance(double[] values)
        {
            double total = 0;
            double totaledSquared = 0;
            double counter = 0;


            foreach (double value in values)
            {
                counter++;
                total += value;
                totaledSquared += value * value;
            }

            return (totaledSquared - ((total * total) / counter)) / (counter - 1);
        }
    }
}
