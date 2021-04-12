﻿using Microsoft.EntityFrameworkCore;
using Produkt.Pages.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produkt.Data
{
    public class ProductContext:DbContext
    {public ProductContext (DbContextOptions options) : base(options) { }
        public DbSet<Product> Product { get; set; }
    }
}
