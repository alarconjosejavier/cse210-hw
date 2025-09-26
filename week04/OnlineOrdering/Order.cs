using System.Runtime.InteropServices;

class Order
{
    // creating attributes
    private List<Product> _products = new();
    // receveing feedback from ChatGPT becuase I just to have _customers in plural.
    private Customer _customer;

    // creating constructor
    public Order(Customer customer)
    {
        // reciver feedback from ChatGPT because I didn't know where to pass the customer
        _customer = customer;
    }

    // // My original method
    // public void AddProduct(Product product)
    // {
    //     foreach (Product p in _products)
    //     {
    //         _products.Add(p);
    //     }
    // }

    // Version fixed by ChatGPT understanding the errors and why.
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal GetSubtotal()
    {
        decimal subtotal = 0;

        foreach (Product i in _products)
        {
            // I forget to add the + to add every subtotal, received feedback from ChatGPT
            subtotal += i.GetTotalCost();
        }
        return subtotal;
    }

    public decimal GetShippingCost()
    {
        if (_customer.IsResidentUSA())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    //receving help from ChatGPT because I was confused with the another method with the same
    // name in Product class. So, I created this one copied from ChatGPT but modifing
    // the last 2 lines.
    public decimal GetTotalCost()
    {
        decimal subtotal = GetSubtotal();
        decimal shippingCost = GetShippingCost();
        decimal total = subtotal + shippingCost;
        return total;
    }

    // creating method to get the address from customer class
    public string GetPackingLabel()
    {
        string nameProductID = "";
        foreach (Product p in _products)
        {
            nameProductID += $"{p.GetName()} {p.GetProductID()} \n";
        }
        return nameProductID;
    }

    // creating method to get the shipping label
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()} {_customer.GetAddress()}";
    }

}