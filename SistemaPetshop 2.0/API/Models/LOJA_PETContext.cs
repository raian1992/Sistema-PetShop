using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace API.Models
{
    public partial class LOJA_PETContext : DbContext
    {
        public LOJA_PETContext()
        {
        }

        public LOJA_PETContext(DbContextOptions<LOJA_PETContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AtendimentoVet> AtendimentoVets { get; set; }
        public virtual DbSet<BPessoasEmpresa> BPessoasEmpresas { get; set; }
        public virtual DbSet<BPessoasEmpresaPet> BPessoasEmpresaPets { get; set; }
        public virtual DbSet<Cep> Ceps { get; set; }
        public virtual DbSet<Cfop> Cfops { get; set; }
        public virtual DbSet<Cirurgium> Cirurgia { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Compromisso> Compromissos { get; set; }
        public virtual DbSet<Config> Configs { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<EmpresaEmail> EmpresaEmails { get; set; }
        public virtual DbSet<EmpresaUsuario> EmpresaUsuarios { get; set; }
        public virtual DbSet<EmpresaVeterinario> EmpresaVeterinarios { get; set; }
        public virtual DbSet<Grp> Grps { get; set; }
        public virtual DbSet<Internacao> Internacaos { get; set; }
        public virtual DbSet<Pagamento> Pagamentos { get; set; }
        public virtual DbSet<PagamentosAtendimento> PagamentosAtendimentos { get; set; }
        public virtual DbSet<PagamentosInternacao> PagamentosInternacaos { get; set; }
        public virtual DbSet<Perfil> Perfils { get; set; }
        public virtual DbSet<Pet> Pets { get; set; }
        public virtual DbSet<Proprietario> Proprietarios { get; set; }
        public virtual DbSet<Receitum> Receita { get; set; }
        public virtual DbSet<Servico> Servicos { get; set; }
        public virtual DbSet<ServicoVeterinario> ServicoVeterinarios { get; set; }
        public virtual DbSet<Sysdiagram> Sysdiagrams { get; set; }
        public virtual DbSet<Taxa> Taxas { get; set; }
        public virtual DbSet<TotalAtendimento> TotalAtendimentos { get; set; }
        public virtual DbSet<TotalInternacaoCirurgium> TotalInternacaoCirurgia { get; set; }
        public virtual DbSet<Tributacao> Tributacaos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        
        public virtual DbSet<VetCirurgium> VetCirurgia { get; set; }
        public virtual DbSet<Veterinario> Veterinarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string projectPath = AppDomain.CurrentDomain.BaseDirectory.Split(new String[] { @"bin\" }, StringSplitOptions.None)[0];
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(projectPath)
                .AddJsonFile("appsettings.json")
                .Build();
            //if (!optionsBuilder.IsConfigured)
            //{
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            //optionsBuilder.UseSqlServer("Password=raautomacao_01;Persist Security Info=True;User ID=admin;Initial Catalog=LOJA_PET;Data Source=SERVER\\SQLEXPRESS;");

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("connectionstring"));
            //}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<AtendimentoVet>(entity =>
            {
                entity.HasOne(d => d.IdCirurgiaNavigation)
                    .WithMany(p => p.AtendimentoVets)
                    .HasForeignKey(d => d.IdCirurgia)
                    .HasConstraintName("FK_CIRURGIAATENDIMENTO_VET");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.AtendimentoVets)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClienteATENDIMENTO_VET");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.AtendimentoVets)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMPRESAATENDIMENTO_VET");

                entity.HasOne(d => d.IdPetNavigation)
                    .WithMany(p => p.AtendimentoVets)
                    .HasForeignKey(d => d.IdPet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PETATENDIMENTO_VET");

                entity.HasOne(d => d.IdVetNavigation)
                    .WithMany(p => p.AtendimentoVets)
                    .HasForeignKey(d => d.IdVet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VeterinariosATENDIMENTO_VET");
            });

            modelBuilder.Entity<BPessoasEmpresa>(entity =>
            {
                entity.ToView("b_pessoas_empresa");
            });

            modelBuilder.Entity<BPessoasEmpresaPet>(entity =>
            {
                entity.ToView("b_pessoas_empresa_pet");
            });

            modelBuilder.Entity<Cep>(entity =>
            {
                entity.Property(e => e.Bairro).IsUnicode(false);

                entity.Property(e => e.Cidade).IsUnicode(false);

                entity.Property(e => e.Estado).IsUnicode(false);

                entity.Property(e => e.NumCep).IsUnicode(false);
            });

            modelBuilder.Entity<Cfop>(entity =>
            {
                entity.Property(e => e.Ativo)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.AtualizaCusto)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Cfop1).IsUnicode(false);

                entity.Property(e => e.Descricao).IsUnicode(false);

                entity.Property(e => e.MovEstq)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TipoMov)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Cirurgium>(entity =>
            {
                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Cirurgia)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClienteCIRURGIA");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.Cirurgia)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMPRESACIRURGIA");

                entity.HasOne(d => d.IdPetNavigation)
                    .WithMany(p => p.Cirurgia)
                    .HasForeignKey(d => d.IdPet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PETCIRURGIA");

                entity.HasOne(d => d.IdVetPrincipalNavigation)
                    .WithMany(p => p.Cirurgia)
                    .HasForeignKey(d => d.IdVetPrincipal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VeterinariosCIRURGIA");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.Property(e => e.Ativo)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Bairro).IsUnicode(false);

                entity.Property(e => e.Celular).IsUnicode(false);

                entity.Property(e => e.Cep).IsUnicode(false);

                entity.Property(e => e.Cidade).IsUnicode(false);

                entity.Property(e => e.Cpf).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Estado).IsUnicode(false);

                entity.Property(e => e.Nome).IsUnicode(false);

                entity.Property(e => e.Numero).IsUnicode(false);

                entity.Property(e => e.Rua).IsUnicode(false);

                entity.Property(e => e.Telefone).IsUnicode(false);
            });

            modelBuilder.Entity<Compromisso>(entity =>
            {
                entity.Property(e => e.Descricao).IsUnicode(false);
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasOne(d => d.IdConfigNavigation)
                    .WithMany(p => p.Empresas)
                    .HasForeignKey(d => d.IdConfig)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMPRESACONFIG");
            });

            modelBuilder.Entity<EmpresaEmail>(entity =>
            {
                entity.HasOne(d => d.IdEmailNavigation)
                    .WithMany(p => p.EmpresaEmails)
                    .HasForeignKey(d => d.IdEmail)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMAILEMPRESA_EMAIL");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.EmpresaEmails)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMPRESA_EMAIL1");
            });

            modelBuilder.Entity<EmpresaUsuario>(entity =>
            {
                entity.Property(e => e.IdAssociacao).ValueGeneratedNever();

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.EmpresaUsuarios)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMPRESAEMPRESA_USUARIO");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.EmpresaUsuarios)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USUARIOSEMPRESA_USUARIO");
            });

            modelBuilder.Entity<EmpresaVeterinario>(entity =>
            {
                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.EmpresaVeterinarios)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMPRESAEMPRESA_VETERINARIO");

                entity.HasOne(d => d.IdVetNavigation)
                    .WithMany(p => p.EmpresaVeterinarios)
                    .HasForeignKey(d => d.IdVet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VeterinariosEMPRESA_VETERINARIO");
            });

            modelBuilder.Entity<Grp>(entity =>
            {
                entity.Property(e => e.NomeGrupo).IsUnicode(false);

                entity.Property(e => e.ProdVend)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Internacao>(entity =>
            {
                entity.HasOne(d => d.IdAtendimentoNavigation)
                    .WithMany(p => p.Internacaos)
                    .HasForeignKey(d => d.IdAtendimento)
                    .HasConstraintName("FK_ATENDIMENTO_VETINTERNACAO");

                entity.HasOne(d => d.IdCirurgiaNavigation)
                    .WithMany(p => p.Internacaos)
                    .HasForeignKey(d => d.IdCirurgia)
                    .HasConstraintName("FK_CIRURGIAINTERNACAO");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Internacaos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClienteINTERNACAO");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.Internacaos)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMPRESAINTERNACAO");

                entity.HasOne(d => d.IdPetNavigation)
                    .WithMany(p => p.Internacaos)
                    .HasForeignKey(d => d.IdPet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PETINTERNACAO");

                entity.HasOne(d => d.IdVetNavigation)
                    .WithMany(p => p.Internacaos)
                    .HasForeignKey(d => d.IdVet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VeterinariosINTERNACAO");
            });

            modelBuilder.Entity<Pagamento>(entity =>
            {
                entity.HasOne(d => d.IdTaxasNavigation)
                    .WithMany(p => p.Pagamentos)
                    .HasForeignKey(d => d.IdTaxas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TAXASPAGAMENTOS");
            });

            modelBuilder.Entity<PagamentosAtendimento>(entity =>
            {
                entity.HasOne(d => d.IdPagamentoNavigation)
                    .WithMany(p => p.PagamentosAtendimentos)
                    .HasForeignKey(d => d.IdPagamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAGAMENTOSPAGAMENTOS_ATENDIMENTO");

                entity.HasOne(d => d.IdTipoAtendimentoNavigation)
                    .WithMany(p => p.PagamentosAtendimentos)
                    .HasForeignKey(d => d.IdTipoAtendimento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TOTAL_ATENDIMENTOPAGAMENTOS_ATENDIMENTO");
            });

            modelBuilder.Entity<PagamentosInternacao>(entity =>
            {
                entity.HasOne(d => d.IdPagamentoNavigation)
                    .WithMany(p => p.PagamentosInternacaos)
                    .HasForeignKey(d => d.IdPagamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAGAMENTOSPAGAMENTOS_INTERNACAO");

                entity.HasOne(d => d.IdTipoAtendimentoNavigation)
                    .WithMany(p => p.PagamentosInternacaos)
                    .HasForeignKey(d => d.IdTipoAtendimento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TOTAL_ATENDIMENTOPAGAMENTOS_ATENDIMENTO1");
            });

            modelBuilder.Entity<Pet>(entity =>
            {
                entity.HasOne(d => d.CodClienteNavigation)
                    .WithMany(p => p.Pets)
                    .HasForeignKey(d => d.CodCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PETCliente");
            });

            modelBuilder.Entity<Receitum>(entity =>
            {
                entity.HasOne(d => d.IdAtendimentoNavigation)
                    .WithMany(p => p.Receita)
                    .HasForeignKey(d => d.IdAtendimento)
                    .HasConstraintName("FK_ATENDIMENTO_VETRECEITA");

                entity.HasOne(d => d.IdCirurgiaNavigation)
                    .WithMany(p => p.Receita)
                    .HasForeignKey(d => d.IdCirurgia)
                    .HasConstraintName("FK_RECEITACIRURGIA");

                entity.HasOne(d => d.IdInternacaoNavigation)
                    .WithMany(p => p.Receita)
                    .HasForeignKey(d => d.IdInternacao)
                    .HasConstraintName("FK_INTERNACAORECEITA");
            });

            modelBuilder.Entity<ServicoVeterinario>(entity =>
            {
                entity.HasOne(d => d.IdAtendimentoNavigation)
                    .WithMany(p => p.ServicoVeterinarios)
                    .HasForeignKey(d => d.IdAtendimento)
                    .HasConstraintName("FK_ATENDIMENTO_VETSERVICO_VETERINARIO");

                entity.HasOne(d => d.IdInternacaoNavigation)
                    .WithMany(p => p.ServicoVeterinarios)
                    .HasForeignKey(d => d.IdInternacao)
                    .HasConstraintName("FK_INTERNACAOSERVICO_VETERINARIO");

                entity.HasOne(d => d.IdServicoNavigation)
                    .WithMany(p => p.ServicoVeterinarios)
                    .HasForeignKey(d => d.IdServico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SERVICOSERVICO_VETERINARIO");

                entity.HasOne(d => d.IdVetNavigation)
                    .WithMany(p => p.ServicoVeterinarios)
                    .HasForeignKey(d => d.IdVet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VeterinariosSERVICO_VETERINARIO");
            });

            modelBuilder.Entity<TotalAtendimento>(entity =>
            {
                entity.HasOne(d => d.IdAtendimentoNavigation)
                    .WithMany(p => p.TotalAtendimentos)
                    .HasForeignKey(d => d.IdAtendimento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ATENDIMENTO_VETTOTAL_ATENDIMENTO");
            });

            modelBuilder.Entity<TotalInternacaoCirurgium>(entity =>
            {
                entity.HasOne(d => d.IdCirurgiaNavigation)
                    .WithOne(p => p.TotalInternacaoCirurgium)
                    .HasForeignKey<TotalInternacaoCirurgium>(d => d.IdCirurgia)
                    .HasConstraintName("FK_CIRURGIATOTAL_INTERNACAO_CIRURGIA");

                entity.HasOne(d => d.IdInternacaoNavigation)
                    .WithMany(p => p.TotalInternacaoCirurgia)
                    .HasForeignKey(d => d.IdInternacao)
                    .HasConstraintName("FK_INTERNACAOTOTAL_INTERNACAO");
            });

            modelBuilder.Entity<Tributacao>(entity =>
            {
                entity.Property(e => e.Ativo)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CfopEntradaDe).IsUnicode(false);

                entity.Property(e => e.CfopEntradaDevDe).IsUnicode(false);

                entity.Property(e => e.CfopEntradaDevFe).IsUnicode(false);

                entity.Property(e => e.CfopEntradaFe).IsUnicode(false);

                entity.Property(e => e.CfopSaidaDe).IsUnicode(false);

                entity.Property(e => e.CfopSaidaDevDe).IsUnicode(false);

                entity.Property(e => e.CfopSaidaDevFe).IsUnicode(false);

                entity.Property(e => e.CfopSaidaFe).IsUnicode(false);

                entity.Property(e => e.CsosnEntrada).IsUnicode(false);

                entity.Property(e => e.CsosnSaida).IsUnicode(false);

                entity.Property(e => e.CstEntrada).IsUnicode(false);

                entity.Property(e => e.CstSaida).IsUnicode(false);

                entity.Property(e => e.Nome).IsUnicode(false);

                entity.Property(e => e.Trbid).IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PERFILUSUARIOS");
            });

            modelBuilder.Entity<VetCirurgium>(entity =>
            {
                entity.HasOne(d => d.IdCirurgiaNavigation)
                    .WithMany(p => p.VetCirurgia)
                    .HasForeignKey(d => d.IdCirurgia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CIRURGIAVET_CIRURGIA");

                entity.HasOne(d => d.IdVetNavigation)
                    .WithMany(p => p.VetCirurgia)
                    .HasForeignKey(d => d.IdVet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VeterinariosVET_CIRURGIA");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
