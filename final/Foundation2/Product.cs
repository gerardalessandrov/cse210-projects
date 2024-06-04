public class Product
{
    private string _name = "";
    private int _productid;
    private double _price;
    private int _quantity;
    List<Product> products;

    public Product()
    {

        products = new List<Product>();

    }
    public void TotalCost()
    {
        foreach (var _product1 in products)
        {
            Console.WriteLine($"The total cost of your products is{_product1._price * _product1._quantity}");
        }


    }
    public void WriteyourProductInformation()
    {
        Product product1 = new Product();
        Console.WriteLine("Please enter the name of your product:");
        string product = Console.ReadLine();
        product1._name = product;
        Console.WriteLine("Please enter the product id :");
        int productid = int.Parse(Console.ReadLine());
        product1._productid = productid;
        Console.WriteLine("Please enter the price of your  :");
        double productprice = double.Parse(Console.ReadLine());
        product1._price = productprice;
        Console.WriteLine("Please enter the quantity of products:");
        int productquantity = int.Parse(Console.ReadLine());
        product1._quantity = productquantity;
        products.Add(product1);
    }



}