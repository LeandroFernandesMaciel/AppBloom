
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAppBloom.Models;
namespace WebAppBloom.EntityConfigs

namespace AppWebBloom.EntityConfigs;
public class CompetenciaEntityConfig: IEntityTypeConfiguration<Competencia>{

public void Configure (EntityTypeBuilder<Competencia> builder ){

builder.ToTable("Competencia");
builder.Haskey(c=>c.Id);
builder.Property(c=>c.Id);
        .HasColumnName("Id");

builder.Property(c=> c.ColunaBloom)
        .HasColumnName("ColunaBloom");
        .HasColumnType("varchar(60)");
        .isRequired();

 builder.Property(c=> c.LinhaBloom)
        .HasColumnName("LinhaBloom");
        .HasColumnType("varchar(60)");
        .isRequired();
    }
}






