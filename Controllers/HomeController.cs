using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Contact.Models;

namespace Contact.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/contact/list")]
    public ActionResult Contacts()
    {
      List<string> allContacts = ContactList.GetAll();
        return View(allContacts);
    }

    [HttpPost("/contact/create")]
    public ActionResult CreateContact()
    {
      ContactList newContact = new ContactList (Request.Form["contactName"], Request.Form["contactAddress"], Request.Form["contactPhone"]);
      newContact.Save();
      return View(newContact);
    }

    [HttpPost ("/contact/list/clear")]
    public ActionResult ContactListClear()
    {
      ContactList.ClearAll();
      return View();
    }
  }
}
