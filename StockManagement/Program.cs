namespace StockManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StockManager obj = new StockManager();
            string filePath = "C:/Users/sir/Desktop/dotNet/StockManagement/StockManagement/data.json";
            StockReport data = obj.Read(filePath);
            // Console.WriteLine(data);
            for (int i = 0; i < data.stock.Count; i++)
            {
                Console.WriteLine(data.stock[i].stockName);
                Console.WriteLine(data.stock[i].stockPrice);
                Console.WriteLine(data.stock[i].totalShare);

                int total = data.stock[i].stockPrice * data.stock[i].totalShare;
                Console.WriteLine("total price of rice is : " + total);
                Console.WriteLine("------------------------");
            }

        }
    }
}