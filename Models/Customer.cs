using System;
using System.Collections.Generic;

namespace RepositoryDesignPattern.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? Customername { get; set; }

    public string? City { get; set; }
}
