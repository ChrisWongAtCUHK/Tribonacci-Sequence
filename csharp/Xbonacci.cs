using System;
public class Xbonacci
{
    public double[] Tribonacci(double[] signature, int n)
    {
        // if n==0, then return an empty array
        if (n == 0) return new double[] { 0 };

        // the list of result
        double[] result = new double[n];

        // special cases
        if (n < signature.Length)
        {
            for (int i = 0; i < n; i++)
            {
                result[i] = signature[i];
            }

            return result;
        }

        Array.Copy(signature, result, signature.Length);

        for (int i = signature.Length; i < n; i++)
        {
            result[i] = result[i - 1] + result[i - 2] + result[i - 3];
        }
        return result;
    }
}

