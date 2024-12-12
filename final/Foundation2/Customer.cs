using System;

class Customer
{
    private string _customerName;
    private Address _address;

    public bool IsUSA()
    {
        return _address.GetCountry() == "USA";
    }

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }
    
    public string GetShippingLabel()
    {
        return $"{_customerName}\n{_address.DisplayAddress()}";
    }
}