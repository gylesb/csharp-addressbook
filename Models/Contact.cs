using System.Collections.Generic;

namespace Contact.Models
{
  public class ContactList
  {
    private string _name;
    private string _address;
    private string _phone;

    private static List<string> _instances = new List<string> {};

    // Constructor
    public ContactList (string name, string address, string phone)
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
      _instances.Add((_name + " " + _address + " " + _phone));
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
