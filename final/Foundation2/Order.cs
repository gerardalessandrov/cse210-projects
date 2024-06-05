using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;
    private const decimal USA_Shipping_Cost = 5;
    private const decimal International_Shipping_Cost = 35;

    public Order(Customer customer)
    {
        products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.CalculateTotalCost();
        }

        return totalCost + GetShippingCost();
    }

    public string GetPackingLabel()
    {
        string label = $"Packing Label:\nCustomer: {customer.Name}\n";
        foreach (var product in products)
        {
            label += $"Product: {product.Name}, ID: {product.Id}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\nCustomer: {customer.Name}\nAddress:\n{customer.Address.GetAddressString()}";
    }

    private decimal GetShippingCost()
    {
        return customer.Address.IsInUSA() ? USA_Shipping_Cost : International_Shipping_Cost;
    }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public decimal CalculateTotalCost()
    {
        return Price * Quantity;
    }
}

public class Customer
{
    public string Name { get; set; }
    public Address Address { get; set; }

    public bool IsInUSA()
    {
        return Address.IsInUSA();
    }
}

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }

    public bool IsInUSA()
    {
        return Country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public string GetAddressString()
    {
        return $"{Street}, {City}, {State}, {Country}";
    }
}