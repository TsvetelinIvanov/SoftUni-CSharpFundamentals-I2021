using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.RegularExpressions;
using Phonebook.Data;
using Phonebook.Data.Models;

namespace Phonebook.Controllers
{
    public class ContactController : Controller
    {
        private const string InvalidNameExceptionmessage = "The name must start with a capital letter and contains only letters, digits, white spaces and _!";
        private const string InvalidNumberExceptionmessage = "The number must have only digits and may start with +!";

        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            Regex nameRegex = new Regex(@"^[A-Z][\w ]+$");
            Regex numberRegex = new Regex(@"^\+?\d+$");

            if (!nameRegex.IsMatch(contact.Name))
            {
                throw new ArgumentException(InvalidNameExceptionmessage);
            }

            if (!numberRegex.IsMatch(contact.Number))
            {
                throw new ArgumentException(InvalidNumberExceptionmessage);
            }

            DataAccess.Contacts.Add(contact);

            return RedirectToAction("Index", "Home");
        }
    }
}
