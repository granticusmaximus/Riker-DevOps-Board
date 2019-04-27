﻿using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using riker.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace riker
{
    public class RikerDbContext : IdentityDbContext<ApplicationUser>
    {
        public RikerDbContext(DbContextOptions<RikerDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

        }
    }
}

