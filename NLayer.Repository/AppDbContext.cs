using Microsoft.EntityFrameworkCore;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Odemeler = Set<Odeme>();
        }

        public DbSet<Odeme> Odemeler { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        //OnModelCreating metodu, model oluşturulurken gerekli yapılandırmaları yapmak için kullanılır. Bu yapılandırmalar, veritabanı tabloları ve ilişkilerinin nasıl oluşturulacağı ve örnek verilerin nasıl ekleneceği gibi işlemleri belirler. Bu sayede Entity Framework Core, uygulama varlık sınıflarının veritabanına nasıl yansıtılacağını bilir ve uygulama, doğru yapılandırmalarla veritabanı işlemlerini gerçekleştirebilir.
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

           


            base.OnModelCreating(modelBuilder);
        }
    }
}

