class starting_point
{
    public starting_point()
    {
        double da = 1.0e-12;
        double da2 = 1.0e-300;
        double m = 100;
        double x = 10.0;//A threshold exists depending on the function.
        double sum = 0.0;//Function sum
        int h = 0;
        for (h = 0; h <= m; h++)
        {
            if (double.IsNaN(Function(x + da)))
            {
                sum += Function(da2);
                continue;
            }
            if (double.IsInfinity(Function(x + da)))
            {
                break;
            }
            sum += Function(x + da);
        }
        x = x + ((m+1) * da) / (m + 1 + ((m+1) * da));
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
        new starting_point();
    }
}
