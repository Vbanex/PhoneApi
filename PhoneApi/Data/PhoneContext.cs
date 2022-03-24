using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
using PhoneApi.Models;


namespace PhoneApi.Data
{
    public class PhoneContext: DbContext
    {
        public PhoneContext(DbContextOptions<PhoneContext> options) : base(options) { }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryDetails> CountryDetails { get; set; }
    }
}
