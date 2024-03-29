﻿using DataAccess.Entities.Context.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DataAccess.Database.IOBalanceV3;

namespace DataAccess.Entities.Context
{
    public class IOBalanceDBV3Entities : System.Data.Entity.DbContext, IIOBalanceDBV3Entities
    {
        static IOBalanceDBV3Entities()
        {
            System.Data.Entity.Database.SetInitializer<IOBalanceDBV3Entities>(null);
        }

        public IOBalanceDBV3Entities()
            : base("name=IOBalanceDBV3Entities")
        {
        }

        public IOBalanceDBV3Entities(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        public IOBalanceDBV3Entities(string nameOrConnectionString, DbCompiledModel model)
            : base(nameOrConnectionString, model)
        {
        }

        public IOBalanceDBV3Entities(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public IOBalanceDBV3Entities(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }

        #region DbSets
        public virtual DbSet<Units> Units { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<FilePasswords> FilePasswords { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        #endregion
    }
}
