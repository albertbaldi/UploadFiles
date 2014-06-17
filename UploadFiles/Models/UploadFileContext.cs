using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UploadFiles.Models
{
    public class UploadFileContext : DbContext
    {
        public UploadFileContext()
            : base("name=UploadFileDB")
        {
            Database.Connection.ConnectionString = @"data source=.\MSSQLSERVERR2; initial catalog=UploadFileDB; Integrated Security=SSPI";
        }

        public DbSet<Upload> Upload { get; set; }
        public DbSet<Pedido> Pedido { get; set; }

    }
}