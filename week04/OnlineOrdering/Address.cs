using System.Security.Authentication;

class Address
{
    // creating attributes
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // creating constructor
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsResidentUSA()
    {
        /// Original that I made but afet I received a feedback from ChatGPT
        /// and I learned the importance to check if the user enter different
        /// ways the country.
        // if (_country == "USA" || _country == "United States")
        // {
        //     return true;
        // }
        // else
        // {
        //     return false;
        // }

        // suggestion of ChatGPT I learned the importance to check the input of the user
        // I know this is not an activity where the user is going to enter any input,
        // but I remember the importance to do it and how to do it.
        string correctionInput = _country.ToLower().Trim();
        return correctionInput == "usa" || correctionInput == "united states";
    }

    public string GetCompleteAddress()
    {
        // received feedback of ChatGPT to add /n to create a space between lines
        // better to show something similar to a label
        return $"{_street} \n{_city} {_state} \n{_country}";
    }
}