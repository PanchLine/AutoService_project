﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoService_project
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Valsh_ProjectEntities1 : DbContext
    {
        public Valsh_ProjectEntities1()
            : base("name=Valsh_ProjectEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ClientsSet> ClientsSet { get; set; }
        public virtual DbSet<EmployesSet> EmployesSet { get; set; }
        public virtual DbSet<OrdersSet> OrdersSet { get; set; }
        public virtual DbSet<ProfessionsSet> ProfessionsSet { get; set; }
        public virtual DbSet<ServicesSet> ServicesSet { get; set; }
    }
}
