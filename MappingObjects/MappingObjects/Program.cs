using System.Net.Sockets;

namespace Mapping;
public class Program
{
    public static void main(String[] args)
    {

    }
}

public class customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public AddressFamily Address { get; set; }
}

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
}

public class CustomerDto
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public int Age { get; set; }
    public string FullAddress { get; set; }
}

//Manual Mapping