using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using product_manage;

namespace product_manage.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("product_manage.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("HomePageUrl")
                        .IsRequired();

                    b.Property<string>("description");

                    b.Property<string>("name")
                        .IsRequired();

                    b.HasKey("id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("product_manage.UpdateProduct", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("description");

                    b.Property<string>("name")
                        .IsRequired();

                    b.Property<int>("productid");

                    b.HasKey("id");

                    b.HasIndex("productid");

                    b.ToTable("UpdateProduct");
                });

            modelBuilder.Entity("product_manage.UpdateProduct", b =>
                {
                    b.HasOne("product_manage.Product")
                        .WithMany("updateproduct")
                        .HasForeignKey("productid")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
