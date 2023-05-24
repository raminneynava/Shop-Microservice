using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Products.Infrastructure.Migrations
{
    public partial class db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "character varying(5000)", maxLength: 5000, nullable: false),
                    ParentCategoryId = table.Column<int>(type: "integer", nullable: true),
                    Permalink = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    Priority = table.Column<int>(type: "integer", nullable: false),
                    BannerUrl = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValue: "https://via.placeholder.com/500x100.png"),
                    IconUrl = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValue: "https://via.placeholder.com/85.png"),
                    ThumbnailUrl = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValue: "https://via.placeholder.com/150x150.png"),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2023, 5, 24, 20, 11, 43, 85, DateTimeKind.Utc).AddTicks(353)),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2023, 5, 24, 20, 11, 43, 85, DateTimeKind.Utc).AddTicks(644))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "character varying(5000)", maxLength: 5000, nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    Permalink = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CoverImageUrl = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValue: "https://via.placeholder.com/150x150.png"),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Code = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2023, 5, 24, 20, 11, 43, 85, DateTimeKind.Utc).AddTicks(7505)),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2023, 5, 24, 20, 11, 43, 85, DateTimeKind.Utc).AddTicks(7828))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Active", "Description", "ParentCategoryId", "Permalink", "Priority", "Title" },
                values: new object[] { 1, false, "Laborum ex elit dolore cupidatat consequat. Lorem reprehenderit et anim aute aliquip pariatur consectetur exercitation qui irure esse duis. Qui anim laborum esse Lorem amet excepteur sint ea est tempor consectetur consequat amet duis. Occaecat laborum magna ut incididunt consectetur esse qui voluptate do. Eiusmod irure aliquip ex excepteur do aliqua Lorem incididunt ad sint dolor consectetur. Ipsum aute est culpa laboris incididunt nisi consequat deserunt.\r\n", null, "Tracie-Mccray", 0, "Sawyer Brennan" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Active", "Description", "ParentCategoryId", "Permalink", "Priority", "Title" },
                values: new object[,]
                {
                    { 2, false, "Non enim veniam fugiat adipisicing nulla anim ipsum. Nisi dolore sit amet id magna. Nostrud ad fugiat non velit aliqua ex Lorem do. Laboris enim ipsum officia dolore cupidatat aute voluptate enim excepteur irure laborum aliqua eiusmod.\r\n", 1, "Jannie-Patton", 0, "Dianne Trujillo" },
                    { 3, false, "Est tempor ad eiusmod non non adipisicing nisi tempor nostrud aute. Veniam aute nisi velit fugiat eu ad aliqua incididunt est sunt. Mollit duis ullamco est sint tempor dolore laboris aliqua incididunt aute cillum excepteur. Occaecat laboris fugiat fugiat quis consequat excepteur. Sit id anim officia nulla mollit.\r\n", 1, "Danielle-Dudley", 0, "Kathryn Gates" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Active", "Description", "ParentCategoryId", "Permalink", "Priority", "Title" },
                values: new object[,]
                {
                    { 4, true, "Adipisicing nostrud consectetur tempor sit Lorem. Eiusmod amet ipsum consequat tempor ex laboris sit deserunt consectetur labore deserunt anim. Consequat ad occaecat cillum nisi irure dolore velit occaecat dolore pariatur labore. Dolor pariatur ea laborum et ipsum excepteur duis qui aliqua aute deserunt commodo enim nisi. Quis tempor incididunt sunt nostrud irure aute incididunt. Fugiat ipsum laboris magna exercitation ipsum. Ut amet exercitation deserunt elit sit enim occaecat irure ea in.\r\n", 2, "Lesa-Cameron", 0, "Morton Nicholson" },
                    { 5, false, "Aute aliqua ex velit sunt laborum qui deserunt culpa duis est occaecat. Mollit enim sunt nulla duis sint minim dolore. Non enim dolor pariatur esse officia id ex ipsum elit pariatur quis non pariatur.\r\n", 2, "Ursula-Allison", 0, "Pickett Howard" },
                    { 6, true, "Irure laborum quis sunt non voluptate anim nisi veniam cillum qui labore eiusmod cupidatat culpa. Eiusmod excepteur sint quis Lorem cupidatat tempor incididunt quis. Do amet sit sit qui laborum occaecat adipisicing.\r\n", 3, "Brock-Andrews", 0, "Miles Pacheco" },
                    { 7, true, "Sunt duis duis non dolor do eiusmod laboris esse ullamco enim est. Et minim fugiat consequat ea ipsum Lorem esse non incididunt labore minim dolore. Elit in non do proident aliquip tempor eu. Ad incididunt cupidatat nulla eu sunt. Consequat labore exercitation sint fugiat eu qui adipisicing sint reprehenderit Lorem nisi dolor velit nostrud. Nisi dolore sint sint anim velit eiusmod. Sit esse do do velit sit sit aute do nulla ad aliquip nisi nostrud ea.\r\n", 3, "Marina-Bean", 0, "Gill Langley" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentCategoryId",
                table: "Categories",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
