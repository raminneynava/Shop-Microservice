﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Products.Infrastructure.Context;

#nullable disable

namespace Products.Infrastructure.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    partial class ProductDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Products.Domain.Categories.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<string>("BannerUrl")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasDefaultValue("https://via.placeholder.com/500x100.png");

                    b.Property<DateTime>("CreationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2023, 5, 24, 20, 27, 47, 202, DateTimeKind.Utc).AddTicks(8110));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("character varying(5000)");

                    b.Property<string>("IconUrl")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasDefaultValue("https://via.placeholder.com/85.png");

                    b.Property<DateTime>("ModificationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2023, 5, 24, 20, 27, 47, 202, DateTimeKind.Utc).AddTicks(8351));

                    b.Property<int?>("ParentCategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Permalink")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<int>("Priority")
                        .HasColumnType("integer");

                    b.Property<string>("ThumbnailUrl")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasDefaultValue("https://via.placeholder.com/150x150.png");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = false,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Laborum ex elit dolore cupidatat consequat. Lorem reprehenderit et anim aute aliquip pariatur consectetur exercitation qui irure esse duis. Qui anim laborum esse Lorem amet excepteur sint ea est tempor consectetur consequat amet duis. Occaecat laborum magna ut incididunt consectetur esse qui voluptate do. Eiusmod irure aliquip ex excepteur do aliqua Lorem incididunt ad sint dolor consectetur. Ipsum aute est culpa laboris incididunt nisi consequat deserunt.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Tracie-Mccray",
                            Priority = 0,
                            Title = "Sawyer Brennan"
                        },
                        new
                        {
                            Id = 2,
                            Active = false,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Non enim veniam fugiat adipisicing nulla anim ipsum. Nisi dolore sit amet id magna. Nostrud ad fugiat non velit aliqua ex Lorem do. Laboris enim ipsum officia dolore cupidatat aute voluptate enim excepteur irure laborum aliqua eiusmod.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentCategoryId = 1,
                            Permalink = "Jannie-Patton",
                            Priority = 0,
                            Title = "Dianne Trujillo"
                        },
                        new
                        {
                            Id = 3,
                            Active = false,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Est tempor ad eiusmod non non adipisicing nisi tempor nostrud aute. Veniam aute nisi velit fugiat eu ad aliqua incididunt est sunt. Mollit duis ullamco est sint tempor dolore laboris aliqua incididunt aute cillum excepteur. Occaecat laboris fugiat fugiat quis consequat excepteur. Sit id anim officia nulla mollit.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentCategoryId = 1,
                            Permalink = "Danielle-Dudley",
                            Priority = 0,
                            Title = "Kathryn Gates"
                        },
                        new
                        {
                            Id = 4,
                            Active = true,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Adipisicing nostrud consectetur tempor sit Lorem. Eiusmod amet ipsum consequat tempor ex laboris sit deserunt consectetur labore deserunt anim. Consequat ad occaecat cillum nisi irure dolore velit occaecat dolore pariatur labore. Dolor pariatur ea laborum et ipsum excepteur duis qui aliqua aute deserunt commodo enim nisi. Quis tempor incididunt sunt nostrud irure aute incididunt. Fugiat ipsum laboris magna exercitation ipsum. Ut amet exercitation deserunt elit sit enim occaecat irure ea in.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentCategoryId = 2,
                            Permalink = "Lesa-Cameron",
                            Priority = 0,
                            Title = "Morton Nicholson"
                        },
                        new
                        {
                            Id = 5,
                            Active = false,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Aute aliqua ex velit sunt laborum qui deserunt culpa duis est occaecat. Mollit enim sunt nulla duis sint minim dolore. Non enim dolor pariatur esse officia id ex ipsum elit pariatur quis non pariatur.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentCategoryId = 2,
                            Permalink = "Ursula-Allison",
                            Priority = 0,
                            Title = "Pickett Howard"
                        },
                        new
                        {
                            Id = 6,
                            Active = true,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Irure laborum quis sunt non voluptate anim nisi veniam cillum qui labore eiusmod cupidatat culpa. Eiusmod excepteur sint quis Lorem cupidatat tempor incididunt quis. Do amet sit sit qui laborum occaecat adipisicing.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentCategoryId = 3,
                            Permalink = "Brock-Andrews",
                            Priority = 0,
                            Title = "Miles Pacheco"
                        },
                        new
                        {
                            Id = 7,
                            Active = true,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Sunt duis duis non dolor do eiusmod laboris esse ullamco enim est. Et minim fugiat consequat ea ipsum Lorem esse non incididunt labore minim dolore. Elit in non do proident aliquip tempor eu. Ad incididunt cupidatat nulla eu sunt. Consequat labore exercitation sint fugiat eu qui adipisicing sint reprehenderit Lorem nisi dolor velit nostrud. Nisi dolore sint sint anim velit eiusmod. Sit esse do do velit sit sit aute do nulla ad aliquip nisi nostrud ea.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentCategoryId = 3,
                            Permalink = "Marina-Bean",
                            Priority = 0,
                            Title = "Gill Langley"
                        });
                });

            modelBuilder.Entity("Products.Domain.Products.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("CoverImageUrl")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasDefaultValue("https://via.placeholder.com/150x150.png");

                    b.Property<DateTime>("CreationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2023, 5, 24, 20, 27, 47, 203, DateTimeKind.Utc).AddTicks(4703));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("character varying(5000)");

                    b.Property<DateTime>("ModificationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2023, 5, 24, 20, 27, 47, 203, DateTimeKind.Utc).AddTicks(4933));

                    b.Property<string>("Permalink")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = false,
                            CategoryId = 1,
                            Code = "Deloris",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Laborum ex elit dolore cupidatat consequat. Lorem reprehenderit et anim aute aliquip pariatur consectetur exercitation qui irure esse duis. Qui anim laborum esse Lorem amet excepteur sint ea est tempor consectetur consequat amet duis. Occaecat laborum magna ut incididunt consectetur esse qui voluptate do. Eiusmod irure aliquip ex excepteur do aliqua Lorem incididunt ad sint dolor consectetur. Ipsum aute est culpa laboris incididunt nisi consequat deserunt.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Tracie-Mccray",
                            Price = 0m,
                            Title = "Sawyer Brennan"
                        },
                        new
                        {
                            Id = 2,
                            Active = false,
                            CategoryId = 2,
                            Code = "Brown",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Non enim veniam fugiat adipisicing nulla anim ipsum. Nisi dolore sit amet id magna. Nostrud ad fugiat non velit aliqua ex Lorem do. Laboris enim ipsum officia dolore cupidatat aute voluptate enim excepteur irure laborum aliqua eiusmod.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Jannie-Patton",
                            Price = 0m,
                            Title = "Dianne Trujillo"
                        },
                        new
                        {
                            Id = 3,
                            Active = false,
                            CategoryId = 1,
                            Code = "Rhoda",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Est tempor ad eiusmod non non adipisicing nisi tempor nostrud aute. Veniam aute nisi velit fugiat eu ad aliqua incididunt est sunt. Mollit duis ullamco est sint tempor dolore laboris aliqua incididunt aute cillum excepteur. Occaecat laboris fugiat fugiat quis consequat excepteur. Sit id anim officia nulla mollit.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Danielle-Dudley",
                            Price = 0m,
                            Title = "Kathryn Gates"
                        },
                        new
                        {
                            Id = 4,
                            Active = true,
                            CategoryId = 1,
                            Code = "Lowe",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Adipisicing nostrud consectetur tempor sit Lorem. Eiusmod amet ipsum consequat tempor ex laboris sit deserunt consectetur labore deserunt anim. Consequat ad occaecat cillum nisi irure dolore velit occaecat dolore pariatur labore. Dolor pariatur ea laborum et ipsum excepteur duis qui aliqua aute deserunt commodo enim nisi. Quis tempor incididunt sunt nostrud irure aute incididunt. Fugiat ipsum laboris magna exercitation ipsum. Ut amet exercitation deserunt elit sit enim occaecat irure ea in.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Lesa-Cameron",
                            Price = 0m,
                            Title = "Morton Nicholson"
                        },
                        new
                        {
                            Id = 5,
                            Active = false,
                            CategoryId = 2,
                            Code = "Harvey",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Aute aliqua ex velit sunt laborum qui deserunt culpa duis est occaecat. Mollit enim sunt nulla duis sint minim dolore. Non enim dolor pariatur esse officia id ex ipsum elit pariatur quis non pariatur.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Ursula-Allison",
                            Price = 0m,
                            Title = "Pickett Howard"
                        },
                        new
                        {
                            Id = 6,
                            Active = true,
                            CategoryId = 1,
                            Code = "Oliver",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Irure laborum quis sunt non voluptate anim nisi veniam cillum qui labore eiusmod cupidatat culpa. Eiusmod excepteur sint quis Lorem cupidatat tempor incididunt quis. Do amet sit sit qui laborum occaecat adipisicing.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Brock-Andrews",
                            Price = 0m,
                            Title = "Miles Pacheco"
                        },
                        new
                        {
                            Id = 7,
                            Active = true,
                            CategoryId = 2,
                            Code = "Suzanne",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Sunt duis duis non dolor do eiusmod laboris esse ullamco enim est. Et minim fugiat consequat ea ipsum Lorem esse non incididunt labore minim dolore. Elit in non do proident aliquip tempor eu. Ad incididunt cupidatat nulla eu sunt. Consequat labore exercitation sint fugiat eu qui adipisicing sint reprehenderit Lorem nisi dolor velit nostrud. Nisi dolore sint sint anim velit eiusmod. Sit esse do do velit sit sit aute do nulla ad aliquip nisi nostrud ea.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Marina-Bean",
                            Price = 0m,
                            Title = "Gill Langley"
                        });
                });

            modelBuilder.Entity("Products.Domain.Categories.Category", b =>
                {
                    b.HasOne("Products.Domain.Categories.Category", "ParentCategory")
                        .WithMany()
                        .HasForeignKey("ParentCategoryId");

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("Products.Domain.Products.Product", b =>
                {
                    b.HasOne("Products.Domain.Categories.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Products.Domain.Categories.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
