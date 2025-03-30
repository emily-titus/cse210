class Product
{
    private string _name;
    private int _productId;
    private double _pricePerUnit;
    private int _quantity;

    public Product()
    {
        _name = "";
        _productId = -1;
        _pricePerUnit = 0;
        _quantity = 0;
    }
    public Product(string name, int productId, double pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public double TotalCost()
    {
        double totalCost = _pricePerUnit * _quantity;
        return totalCost;
    }
    public string GetName()
    {
        return _name;
    }
    public int GetId()
    {
        return _productId;
    }
}