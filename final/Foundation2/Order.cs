class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order()
    {
        _products = new List<Product>();
        _customer = new Customer();
    }
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }


    public double CalcTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.TotalCost();
        }
        if (_customer.IsInUsa())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost;
    }
    public string PackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()} - {product.GetId()}\n";
        }
        return packingLabel;
    }
    public string ShippingLabel()
    {
        return $"{_customer.GetName()}\n {_customer.GetAddress().FormatAddress()}";
    }

}