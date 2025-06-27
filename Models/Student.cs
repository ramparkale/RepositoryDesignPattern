using System;
using System.Collections.Generic;

namespace RepositoryDesignPattern.Models;

public partial class Student
{
    public int Sid { get; set; }

    public string? Sname { get; set; }

    public string? Qualification { get; set; }

    public double? Percentage { get; set; }
}
