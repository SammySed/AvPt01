using AvaliacaoPt01.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AvaliacaoPt01.Context
{
    public class EFContext : DbContext
    {
        public EFContext() : base("Avaliacao") { }

        public DbSet<Cliente> cliente { get; set; }

    }
}