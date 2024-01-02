﻿// <auto-generated />
using DockerTest.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DockerTest.Migrations
{
    [DbContext(typeof(TestContext))]
    [Migration("20231221213227_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DockerTest.Models.WelcomeMessage", b =>
                {
                    b.Property<int>("WelcomeMessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("WelcomeMessageId"));

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("WelcomeMessageId");

                    b.ToTable("WelcomeMessages");
                });
#pragma warning restore 612, 618
        }
    }
}
