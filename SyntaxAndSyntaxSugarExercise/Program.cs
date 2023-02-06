namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args) //infered typing, string interpolation, and the ternary operator.
        {
            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than nine";

            Console.WriteLine(response);
        }
    }
}
