using System;
using System.Numerics;

class Program {
    static void Main() {
        int[] nValues = { 100, 400, 1000 };

        foreach (int n in nValues) {

            // Erster Term: O(n² log² n)
            double polyTerm = Math.Pow(n, 2) * Math.Pow(Math.Log(n), 2);

            // Exponentialterm: 2^(3/4n log n)
            double exponent = (3.0 / 4.0) * n * Math.Log(n);

            double logPolyTerm = Math.Log(polyTerm);
            double logExponentialTerm = exponent * Math.Log(2);

            double logResult = logPolyTerm + logExponentialTerm;

            Console.WriteLine($"Für n = {n}:");
            Console.WriteLine($"Polynom-Term (n² log² n): {polyTerm}");
            Console.WriteLine($"Exponent (3/4 * n * log n): {exponent}");
            Console.WriteLine($"Log-Ergebnis: {logResult}");
            Console.WriteLine($"Approximatives Ergebnis (log-basiert): ~10^{logResult * Math.Log10(Math.E)}");
        }
    }
}