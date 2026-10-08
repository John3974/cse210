using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Numerics;

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


