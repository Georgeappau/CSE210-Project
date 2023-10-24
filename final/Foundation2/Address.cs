// using System;

// public class Address
// {
//     private string _streetAddress;
//     private string _city;
//     private string _stateOrProvince;
//     private string _country;
// }

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        this._streetAddress = streetAddress;
        this._city = city;
        this._state = state;
        this._country = country;
    }

    public bool IsInUSA()
    {
        return string.Equals(_country, "USA", StringComparison.OrdinalIgnoreCase);
    }

    public string GetAddressString()
    {
        return $"Address: {_streetAddress}, {_city}, {_state}, {_country}\n";
    }
}