using System.Collections.Generic;

namespace ContactList.Models
{
  public class Contact
  {
    private string _name;
    private string _address;
    private string _phone;

    private static List<string> _instances = new List<string> {};

    // Constructor
    public Contact (string name, string description, string phone)
    {
      _name = name;
      _address = address;
      _phone = phone;
    }

    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public string GetAddress()
    {
      return _address;
    }
    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }
    public string GetPhone()
    {
      return _phone;
    }
    public void SetPhone(string newPhone)
    {
      _name = newPhone;
    }

    public static List<string> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add((_name + "<br>" + _address + "<br>" + _phone));
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
