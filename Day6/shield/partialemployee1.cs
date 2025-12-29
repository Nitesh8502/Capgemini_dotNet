using System;
using System.ComponentModel;
namespace PartialDemo
{
  public partial class PartialEmployee
  {
    private string _firstName;
    private string _lastName;
    private double _salary;
    private string _gender;

    public string FirstName { get => _firstName; set => _firstName = value; }
    public string LastName { get => _lastName; set => _lastName = value; }
    public double Salary { get => _salary; set => _salary = value; }
    public string Gender { get => _gender; set => _gender = value; }

    partial void PartialMethod();
  }
}