﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskFlow.GerencimentoTarefas.Infrastructure.DbContexts;

namespace TaskFlow.GerencimentoTarefas.Infrastructure.Migrations
{
    [DbContext(typeof(GerenciamentoTarefasContext))]
    [Migration("20210707235642_alteracao")]
    partial class alteracao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("TaskFlow.GerenciamentoTarefas.Domain.Tarefas.Interacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Conteudo")
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("conteudo");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data_criacao");

                    b.Property<int>("TarefaId")
                        .HasColumnType("int")
                        .HasColumnName("tarefa_id");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int")
                        .HasColumnName("usuario_id");

                    b.HasKey("Id")
                        .HasName("pk_interacoes");

                    b.HasIndex("TarefaId")
                        .HasDatabaseName("ix_interacoes_tarefa_id");

                    b.ToTable("interacoes");
                });

            modelBuilder.Entity("TaskFlow.GerenciamentoTarefas.Domain.Tarefas.Responsavel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data_criacao");

                    b.Property<string>("Email")
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("email");

                    b.Property<string>("Nome")
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("nome");

                    b.HasKey("Id")
                        .HasName("pk_resposaveis");

                    b.ToTable("resposaveis");
                });

            modelBuilder.Entity("TaskFlow.GerenciamentoTarefas.Domain.Tarefas.Tarefa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data_criacao");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data_inicio");

                    b.Property<DateTime>("DataPrevisaoEntrega")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data_previsao_entrega");

                    b.Property<string>("Descricao")
                        .HasMaxLength(600)
                        .HasColumnType("VARCHAR(600)")
                        .HasColumnName("descricao");

                    b.Property<int>("Prioridade")
                        .HasColumnType("int")
                        .HasColumnName("prioridade");

                    b.Property<int?>("ResponsavelId")
                        .HasColumnType("int")
                        .HasColumnName("responsavel_id");

                    b.Property<string>("Titulo")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR(250)")
                        .HasColumnName("titulo");

                    b.HasKey("Id")
                        .HasName("pk_tarefa");

                    b.HasIndex("ResponsavelId")
                        .HasDatabaseName("ix_tarefa_responsavel_id");

                    b.ToTable("tarefa");
                });

            modelBuilder.Entity("TaskFlow.GerenciamentoTarefas.Domain.Tarefas.Interacao", b =>
                {
                    b.HasOne("TaskFlow.GerenciamentoTarefas.Domain.Tarefas.Tarefa", null)
                        .WithMany("Interacoes")
                        .HasForeignKey("TarefaId")
                        .HasConstraintName("fk_interacoes_tarefas_tarefa_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TaskFlow.GerenciamentoTarefas.Domain.Tarefas.Tarefa", b =>
                {
                    b.HasOne("TaskFlow.GerenciamentoTarefas.Domain.Tarefas.Responsavel", "Responsavel")
                        .WithMany()
                        .HasForeignKey("ResponsavelId")
                        .HasConstraintName("fk_tarefa_resposaveis_responsavel_id");

                    b.Navigation("Responsavel");
                });

            modelBuilder.Entity("TaskFlow.GerenciamentoTarefas.Domain.Tarefas.Tarefa", b =>
                {
                    b.Navigation("Interacoes");
                });
#pragma warning restore 612, 618
        }
    }
}
