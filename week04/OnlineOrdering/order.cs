public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = products.Sum(p => p.GetTotalCost());
        total += customer.LivesInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        return string.Join("\n", products.Select(p => p.GetPackingLabel()));
    }

    public string GetShippingLabel()
    {
        return $"{customer.GetName()}\n{customer.GetAddressString()}";
    }
}
