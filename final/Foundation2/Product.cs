using System;

class Product
{
    private string _name;
    private string _productId;
    private int _price;
    private int _quantity;


    public Product(string name, string productId, int price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public int TotalCost()
    {
        return _price * _quantity;
    }

    public string GetPackingLabel()
    {
        return $"{_name} ({_productId})";
    }
}