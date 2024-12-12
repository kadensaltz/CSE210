using System;
using System.Collections.Generic;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public int OrderCost()
    {
        int productCost = 0;
        foreach (var product in _products)
        {
            productCost += product.TotalCost();
        }
        int shippingCost = _customer.IsUSA() ? 5 : 35;
        return productCost + shippingCost;
    }

    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += product.GetPackingLabel();
            Console.WriteLine();
        }
        return label;
    }

    public string ShippingLabel()
    {
        return "Shipping To:\n" + _customer.GetShippingLabel();
    }
}
