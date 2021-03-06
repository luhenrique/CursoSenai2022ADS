// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace cadeMeuMedico.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220623231450_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("Cidades", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("estado")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("cidades");
                });

            modelBuilder.Entity("CidadesEspecialidades", b =>
                {
                    b.Property<int>("cidadesid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("especialidadesid")
                        .HasColumnType("INTEGER");

                    b.HasKey("cidadesid", "especialidadesid");

                    b.HasIndex("especialidadesid");

                    b.ToTable("CidadesEspecialidades");
                });

            modelBuilder.Entity("Especialidades", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("especialidades");
                });

            modelBuilder.Entity("Medicos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("cidadeid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("crm")
                        .HasColumnType("TEXT");

                    b.Property<string>("endereco")
                        .HasColumnType("TEXT");

                    b.Property<int>("especialidadeid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("cidadeid");

                    b.HasIndex("especialidadeid");

                    b.ToTable("medicos");
                });

            modelBuilder.Entity("Usuarios", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("apelido")
                        .HasColumnType("TEXT");

                    b.Property<int>("cidadeid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("senha")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("cidadeid");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("CidadesEspecialidades", b =>
                {
                    b.HasOne("Cidades", null)
                        .WithMany()
                        .HasForeignKey("cidadesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Especialidades", null)
                        .WithMany()
                        .HasForeignKey("especialidadesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Medicos", b =>
                {
                    b.HasOne("Cidades", "cidade")
                        .WithMany("medicos")
                        .HasForeignKey("cidadeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Especialidades", "especialidade")
                        .WithMany("medicos")
                        .HasForeignKey("especialidadeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cidade");

                    b.Navigation("especialidade");
                });

            modelBuilder.Entity("Usuarios", b =>
                {
                    b.HasOne("Cidades", "cidade")
                        .WithMany()
                        .HasForeignKey("cidadeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cidade");
                });

            modelBuilder.Entity("Cidades", b =>
                {
                    b.Navigation("medicos");
                });

            modelBuilder.Entity("Especialidades", b =>
                {
                    b.Navigation("medicos");
                });
#pragma warning restore 612, 618
        }
    }
}
