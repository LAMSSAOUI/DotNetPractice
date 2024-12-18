namespace HelloWorld;

 public class Program
 {
     static void Main(string[] args)
     {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Enter coefficients a, b, and c:");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        Solution sol = Solve(a, b, c);

        Console.WriteLine($"Number of solutions: {sol.count}");
        if (sol.count == 1)
        {
            Console.WriteLine($"Solution: {sol.sol1}");
        }
        else if (sol.count == 2)
        {
            Console.WriteLine($"Solution 1: {sol.sol1}");
            Console.WriteLine($"Solution 2: {sol.sol2}");
        }
        else
        {
            Console.WriteLine("No real solutions.");
        }
     }

     static public Solution Solve(double a, double b, double c){
        
            Solution result = new Solution();

            if (a == 0)
            {
                // Handle the case where it's not a quadratic equation
                if (b != 0)
                {
                    result.count = 1;
                    result.sol1 = (-c / b).ToString();
                }
                else
                {
                    result.count = 0; // No solutions
                }
                return result;
            }

            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                result.count = 2;
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                result.sol1 = root1.ToString();
                result.sol2 = root2;
            }
            else if (discriminant == 0)
            {
                result.count = 1;
                double root = -b / (2 * a);
                result.sol1 = root.ToString();
            }
            else
            {
                result.count = 0; // No real solutions
            }

            return result;
        // return null;
     }
 }