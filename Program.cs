namespace Techno_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            View view = new View();
            view.Display();
            Bill bill = new Bill();
            Customer customer = new Customer();
            Info info = new Info();

            info.TakingCustomerInfo(customer);
        }
    }
}
