
public class Order

{
    private Customer _customer = "";
    private List<Product> _products = new List<Product>();

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
    }
    public class Order(Customer customer, List<Product> products)
    {
        _customer = customer;
    
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
            shippingCost += 5;

        }
        else
        {
            shippingCost += 35;
        }
        return shippingCost;

    }

    // create packaging labal
    public string GetPackingLabel()
    {
        string label = "PACKING LABEL\n";
        foreach (Product product in _products)
        {
            label += $"Product: {product.GetName()} | ID: {product.GetProductId()}\n";
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

internal class _customer
{
}

internal class customer
{
}

public class Customer
{
    internal bool LiveInUSA()
    {
        throw new NotImplementedException();
    }

    public static implicit operator Customer(string v)
    {
        throw new NotImplementedException();
    }
}

public class Product
{
    internal string GetName()
    {
        throw new NotImplementedException();
    }

    internal string GetProductId()
    {
        throw new NotImplementedException();
    }

    internal double GetTotalCost()
    {
        throw new NotImplementedException();
    }
}