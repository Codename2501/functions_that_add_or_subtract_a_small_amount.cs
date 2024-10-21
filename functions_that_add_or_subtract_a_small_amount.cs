
class functions_that_add_or_subtract_a_small_amount
{
    public functions_that_add_or_subtract_a_small_amount()
    {
        double da = 1.0e-10;
        double da2 = 1.0e-300;
        double m = 100;
        double n = Math.Sqrt(1.0 / da);
        double x = 10.0;//A threshold exists depending on the function.
        double sum = 0.0;//Function sum
        int h = 0;
        for (h = 0; h <= m; h++)
        {
            if (double.IsNaN(Function(x + h * da)))
            {
                sum += Function(da2);
                continue;
            }
            if (double.IsInfinity(Function(x + h * da)))
            {
                sum += Function(da2);
                break;
            }
            sum += Function(x + h * da);
        }
        x = x + (m * (m + 1) / 2.0 * da) / (m + 1 + (m * (m + 1) / 2.0 * da));
        //Consistent with the addition of functions in the microinterval
        //Functions that match the sum of functions
        Console.WriteLine("{0} {1}", sum, (m + 1) * Function(x));
    }
    private double Function(double x)
    {
        //Any elementary function is generally acceptable in any form.
        return Math.Sin(Math.Exp(Math.Cos(x)/x));
        //return x * x * x;
    }
    [STAThread]
    public static void Main()
    {
        new functions_that_add_or_subtract_a_small_amount();
    }
}
