namespace Week2Lab3
{
    internal class Program
    {
        static void Main()
        {
            string userId = "Admin";
            string password = "Password";
            int attempts = 0;

            while (attempts < 3)
            {
                Console.WriteLine("Enter User ID: ");
                string inputUserId = Console.ReadLine();

                Console.WriteLine("Enter Password: ");
                string inputPassword = Console.ReadLine();

                if (inputUserId == userId && inputPassword == password)
                {
                    Console.WriteLine("Login successful!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid credentials. Please try again.");
                    attempts++;
                }
            }

            if (attempts == 3)
            {
                Console.WriteLine("You have exceeded the maximum number of attempts. Access denied.");
            }
        }
    }
}
    

