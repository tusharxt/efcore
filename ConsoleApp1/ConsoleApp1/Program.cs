namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("enter 1st no");
            int a= int.Parse(Console.ReadLine());
            Console.WriteLine("1st no is : "+a);
            //int a =
            Console.WriteLine("enter 2nd no");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("2nd no is : " + b);

            Console.WriteLine("Enter 1 to perform addition and 2 to perform substraction");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
                Console.WriteLine(a + b);
            else if (choice == 2)
            {
                int ans = a > b ? (a - b) : (b - a);
                Console.WriteLine(ans);
            }
            else { Console.WriteLine("Invalid input"); }
        }
    }
}
