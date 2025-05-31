using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        this._customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.TotalProductCost();
        }

        total += _customer.IsInUsa() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine("Packing Label");
        foreach (Product product in _products)
        {
            label.AppendLine(product.GetLabel());
        }
        return label.ToString();
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddressString()}";
    }
}