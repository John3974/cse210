using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Numerics;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
    }

    // Constructor
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = new List<Product>(products);
    }
    // Add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Remove a product from the order
    public void RemoveProduct(Product product)
    {
        _products.Remove(product);
    }


    // Getters and Setters
    public List<Product> GetProducts()
    {
        return _products;

    }


    public void setCustomer(Customer customer)
    {
        _customer = customer;


    }
    public void setProducts(List<Product> products)
    {
        _products = new List<Product>(products);
    }
    // calculate the total cost of the order
    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }
        return totalCost;
    }
    // Add shipping cost
    public double GetShippingCost()
    {
        double shippingCost = 0;
        if (_customer.LiveInUSA())
        {
            total += 5;

        }
        else
        {
            total += 35;
        }
        ;
        return total;

    }

    // create packaging labal
    public string GetPackingLabel()
    {
        string label = "PACKING LABEL\n";
        foreach (Product product in _products)
        {
            label += "$"Product: { product.GetName()}| ID:{ product.GetProductId()\n}
            ;
        }
        return label;
    }
    // Create shipping label
    public string GetShippingLabel()
    {
        string label = "SHIPPING LABEL\n";
        label += $"Customer: {_customer.GetName()}\n";
        label += _customer.GetAddress().GetAddress();

        return label;
    }


}
public class Customer
{
    private string _name;
    private Address _address;

    // constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;

    }
    // getters and setters
    public string GetName()
    {
        return _ name;
    }
    public void SetName(string name)
    {
        -name = name;
    }
    public Address GetAddress()
    {
        return _address
    }
    public void SetAddress(Address address)
    {
        _address = address;
    }
    // Check if customer lives in the USA
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }


}
public class Address
{
    private string _street;
    private string _city;
    private string _country;


    public Address(string street, string city, string state, string country)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Getters and setters
    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public void SetProductId(string productId)
    {
        _productId = productId;
    }

    public double GetPrice()
    {
        return _price;
    }

    public void SetPrice(double price)
    {
        _price = price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    // Calculate total cost
    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}
2.Address.cs
public class Address
{
    // Private member variables
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Constructor
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Getters and setters
    public string GetStreet()
    {
        return _street;
    }

    public void SetStreet(string street)
    {
        _street = street;
    }

    public string GetCity()
    {
        return _city;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public string GetState()
    {
        return _state;
    }

    public void SetState(string state)
    {
        _state = state;
    }

    public string GetCountry()
    {
        return _country;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }

    // Check if address is in the USA
    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }

    // Return the complete address
    public string GetAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }

}