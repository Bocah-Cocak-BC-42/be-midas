using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidasDataAccess.Models
{
    public class LocalOnConfigure
    {
        public void AddLocalConfigure(DbContextOptionsBuilder optionsBuilder) 
        {
            
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-LB6NF3K3;Initial Catalog=Midas;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
