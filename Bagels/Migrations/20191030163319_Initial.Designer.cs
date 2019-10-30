﻿// <auto-generated />
using Bagels.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bagels.Migrations
{
    [DbContext(typeof(BagelsContext))]
    [Migration("20191030163319_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Bagels.Models.Bagel", b =>
                {
                    b.Property<int>("BagelId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Flavor");

                    b.Property<string>("SuggestedToppings");

                    b.HasKey("BagelId");

                    b.ToTable("Bagels");
                });
#pragma warning restore 612, 618
        }
    }
}
