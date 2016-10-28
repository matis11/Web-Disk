﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDisk.Database.DatabaseModel.Identity
{
    public class CustomRole : IdentityRole<Guid, IdentityUserRole>
    {
        public CustomRole() { }
        public CustomRole(string name)
        {
            Name = name;
        }

    }
}