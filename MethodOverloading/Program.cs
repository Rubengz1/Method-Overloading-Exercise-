namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int numOne, int numTwo)
        {
            return (numOne + numTwo);
        }

        public static decimal Add(decimal numOne, decimal numTwo)
        {
            return (numOne + numTwo);
        }

        public static string Add(int numOne, int numTwo, bool isMoney)
        {
            var sum = numOne + numTwo;
            if (isMoney == true && sum > 0)
            {
                return $"{sum} dollars";
            }
            else
            {
                return ("Zero Dollars");
                
            }
        }
        

        static void Main(string[] args)
        {
            //First Add Method
            Console.WriteLine(Add(5, 5));
            
            //Second Add Method
            Console.WriteLine(Add(5.5m, 5.5m));

            //Third Add Method
            Console.WriteLine(Add(0, -2, true));

        }
    }
}
