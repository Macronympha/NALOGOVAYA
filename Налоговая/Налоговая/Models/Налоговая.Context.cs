//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Налоговая.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class НалоговаяEntities : DbContext
    {
        public НалоговаяEntities()
            : base("name=НалоговаяEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ACT> ACT { get; set; }
        public virtual DbSet<conclusion> conclusion { get; set; }
        public virtual DbSet<equipments> equipments { get; set; }
        public virtual DbSet<role> role { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<taxAuthority> taxAuthority { get; set; }
        public virtual DbSet<termsOfUse> termsOfUse { get; set; }
        public virtual DbSet<type> type { get; set; }
        public virtual DbSet<users> users { get; set; }
        public virtual DbSet<users_role> users_role { get; set; }
    }
}
