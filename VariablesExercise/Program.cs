namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string bananas = "That sheet is bananas.";
            int x = 12;
            char c = 'C';
            bool b = true;
            double y = 100.06;
            decimal d = .69m;
            Console.WriteLine($"I've said it {x} times, but {bananas}  These are other variables: " +
                $"\n {c} \n {b} \n {y} \n {d}");
        }
    }
}
