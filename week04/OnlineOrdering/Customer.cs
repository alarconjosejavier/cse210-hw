class Customer
{
    // creating attributes
    private string _name;
    private Address _address;

    // just for recommendation of ChatGPT I am adding get for these two attributes. Copied from
    // ChatGPT asking why I need it.
    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.GetCompleteAddress();
    }

    // creating constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsResidentUSA()
    {
        return _address.IsResidentUSA();
    }
}