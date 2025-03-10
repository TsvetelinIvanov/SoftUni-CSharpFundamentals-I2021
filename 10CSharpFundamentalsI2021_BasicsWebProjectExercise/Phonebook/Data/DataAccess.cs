﻿using System;
using System.Collections.Generic;
using Phonebook.Data.Models;

namespace Phonebook.Data
{
    public class DataAccess
    {
        static DataAccess()
        {
            this.Contacts = new List<Contact>();
        }

        public static List<Contact> Contacts { get; set; }
    }
}
