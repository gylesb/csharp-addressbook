using System.Collecctions.Generic;
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
    public ActionResult ContactList()
    {
      List<string> allContacts = Contacts.GetAll();
        return View(allContacts);
    }

    [HttpPost("/contact/create")]
    public ActionResult CreateContact()
    {
      Contact newContact = new Contact (Request.Form["contactName"], Request.Form["contactAddress"], Request.Form["contactPhone"]);
      newContact.Save();
      return View(newContact);
    }

    [HttpPost ("/contact/list/clear")]
    public ActionResult ContactListClear()
    {
      Contact.ClearAll();
      return View();
    }
  }
}
