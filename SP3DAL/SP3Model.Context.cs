﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SP3DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SP3DBEntities : DbContext
    {
        public SP3DBEntities()
            : base("name=SP3DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<SP3Model.Pessoa> Pessoa { get; set; }
        public virtual DbSet<SP3Model.Projeto> Projeto { get; set; }
        public virtual DbSet<SP3Model.ProjetoPessoa> ProjetoPessoa { get; set; }
    }
}
