//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcCv.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbCVEntities : DbContext
    {
        public DbCVEntities()
            : base("name=DbCVEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<iletisim> iletisims { get; set; }
        public virtual DbSet<TblDeneyimler> TblDeneyimlers { get; set; }
        public virtual DbSet<TblEgitim> TblEgitims { get; set; }
        public virtual DbSet<TblHakkimda> TblHakkimdas { get; set; }
        public virtual DbSet<TblLogin> TblLogins { get; set; }
        public virtual DbSet<TblYetenekler> TblYeteneklers { get; set; }
        public virtual DbSet<Tblilgialanim> Tblilgialanims { get; set; }
    }
}
