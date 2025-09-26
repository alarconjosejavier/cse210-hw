class Product
{
    // creating attributes
    private string _name;
    private string _productID;
    private decimal _price;
    private int _quantity;

    //constructor
    public Product(string name, string productID, decimal price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    // creating getters, I added capital to the second letter as a suggestion of ChatGPT
    public string GetName()
    {
        return _name;
    }

    public string GetProductID()
    {
        return _productID;
    }

    public decimal GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    // creating methods
    public decimal GetTotalCost()
    {
        return _quantity * _price;
    }
}