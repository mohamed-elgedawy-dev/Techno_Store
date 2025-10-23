namespace Techno_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            View view = new View();
            Display display = new Display();
            var name = view.TakingName();

            Services services = new Services();
            var _bill = services.start();
            var grandtatal = view.calculateTotal(_bill);
            #region Save Bill to JSON
            BillSave billSave = new BillSave(_bill, name, grandtatal);

            display.ShowBill(_bill, grandtatal);
            #endregion
        }
    }
}
