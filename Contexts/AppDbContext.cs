namespace AppWebBloom.Contexts; 
using microsoft.EntityFrameworkCore;


public class AppWebBloom:DbContext{

    public class AppWebBloom:DbContext{
        public DbSet<Competencia> Competencias => Set<Competencia>();

        protected override void OnConfiguring (DdContexOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer"Server=LAB-F08-04";Database=AppWebBloom;User Id=sa; Password=senai@123;TrustServerCertificate=True"

        }

    }



}