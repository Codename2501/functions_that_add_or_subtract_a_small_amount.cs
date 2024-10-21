
class functions_that_add_or_subtract_a_small_amount
{
    public functions_that_add_or_subtract_a_small_amount()
    {
        double da = 1.0e-10;
        double da2 = 1.0e-300;
        double m = 100;
        double x = 1.23456789;//A threshold exists depending on the function.
        double x2 = 0.0;
        double sum = 0.0;//Function sum
        int h = 0;
        for (h = 0; h <= m; h++)
        {
            sum += Function(x + da+h*da);
        }
        x2 = x + ((m+1+m*(m+1)/2.0) * da) / (m + 1 + ((m+1+m*(m+1)/2.0) * da));
        //Consistent with the addition of functions in the microinterval
        //Functions that match the sum of functions
        Console.WriteLine("{0} {1}", sum, (m + 1) * Function(x2));
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
