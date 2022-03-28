#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using razor_page_lab3.Models;

public class DBContext : DbContext
{
    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public DbSet<razor_page_lab3.Models.Product> Product { get; set; }

    public DbSet<razor_page_lab3.Models.User> User { get; set; }
}
