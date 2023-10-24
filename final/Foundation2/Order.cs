using System;

using System.Collections.Generic;

public class Order
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

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.CalculatePrice();
        }

        if (_customer.IsInUSA())
        {
            totalCost += 5.0m; // USA shipping cost
        }
        else
        {
            totalCost += 35.0m; // International shipping cost
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"- {product.Name} (Product ID: {product.ProductID})\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"Customer: {_customer.Name}\n";
        shippingLabel += _customer.GetAddressString();
        return shippingLabel;
    }
}