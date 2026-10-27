using EF1Core_Assign.Models;

namespace EF1Core_Assign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new BookstoreContext();

            Console.WriteLine(context.Database.CanConnect()
                ? "Database created and connected successfully."
                : "Cannot connect to the database.");
        }
    }
}
