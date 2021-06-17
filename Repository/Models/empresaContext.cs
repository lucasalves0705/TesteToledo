using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Repository.Models
{
    public partial class empresaContext : DbContext
    {
        public empresaContext()
        {
        }

        public empresaContext(DbContextOptions<empresaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Cidade> Cidades { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Cliente1> Clientes1 { get; set; }
        public virtual DbSet<Estado> Estados { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-Q94MTB0\\SQLEXPRESS; Database=empresa; integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("categorias");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descricao");
            });

            modelBuilder.Entity<Cidade>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("cidades");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("uf")
                    .IsFixedLength(true);

                entity.HasOne(d => d.UfNavigation)
                    .WithMany(p => p.Cidades)
                    .HasForeignKey(d => d.Uf)
                    .HasConstraintName("FK_cidades_estados");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("cliente");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bairro");

                entity.Property(e => e.Celular)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("celular");

                entity.Property(e => e.CodigoCidade).HasColumnName("codigo_cidade");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cpf");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Numero)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("numero");

                entity.Property(e => e.Rua)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rua");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefone");

                entity.HasOne(d => d.CodigoCidadeNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.CodigoCidade)
                    .HasConstraintName("FK_cliente_cidades");
            });

            modelBuilder.Entity<Cliente1>(entity =>
            {
                entity.HasKey(e => e.CliCodigo);

                entity.ToTable("Clientes");

                entity.Property(e => e.CliCodigo).HasColumnName("cli_codigo");

                entity.Property(e => e.CliCpf)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cli_cpf");

                entity.Property(e => e.CliDatanascimento)
                    .HasColumnType("date")
                    .HasColumnName("cli_datanascimento");

                entity.Property(e => e.CliNome)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("cli_nome");

                entity.Property(e => e.CliRg)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cli_rg");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasKey(e => e.Uf);

                entity.ToTable("estados");

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("uf")
                    .IsFixedLength(true);

                entity.Property(e => e.Descricao)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("descricao");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("produtos");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.CodigoCategoria).HasColumnName("codigo_categoria");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.DescricaoLonga)
                    .HasColumnType("text")
                    .HasColumnName("descricaoLonga");

                entity.Property(e => e.Imagem)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("imagem");

                entity.Property(e => e.Qtde).HasColumnName("qtde");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("valor");

                entity.HasOne(d => d.CodigoCategoriaNavigation)
                    .WithMany(p => p.Produtos)
                    .HasForeignKey(d => d.CodigoCategoria)
                    .HasConstraintName("FK_produtos_categorias");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
