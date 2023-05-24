using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Products.Infrastructure.Migrations
{
    public partial class dbprod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 24, 20, 27, 47, 203, DateTimeKind.Utc).AddTicks(4933),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 24, 20, 11, 43, 85, DateTimeKind.Utc).AddTicks(7828));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 24, 20, 27, 47, 203, DateTimeKind.Utc).AddTicks(4703),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 24, 20, 11, 43, 85, DateTimeKind.Utc).AddTicks(7505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 24, 20, 27, 47, 202, DateTimeKind.Utc).AddTicks(8351),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 24, 20, 11, 43, 85, DateTimeKind.Utc).AddTicks(644));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 24, 20, 27, 47, 202, DateTimeKind.Utc).AddTicks(8110),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 24, 20, 11, 43, 85, DateTimeKind.Utc).AddTicks(353));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Active", "CategoryId", "Code", "Description", "Permalink", "Price", "Title" },
                values: new object[,]
                {
                    { 1, false, 1, "Deloris", "Laborum ex elit dolore cupidatat consequat. Lorem reprehenderit et anim aute aliquip pariatur consectetur exercitation qui irure esse duis. Qui anim laborum esse Lorem amet excepteur sint ea est tempor consectetur consequat amet duis. Occaecat laborum magna ut incididunt consectetur esse qui voluptate do. Eiusmod irure aliquip ex excepteur do aliqua Lorem incididunt ad sint dolor consectetur. Ipsum aute est culpa laboris incididunt nisi consequat deserunt.\r\n", "Tracie-Mccray", 0m, "Sawyer Brennan" },
                    { 2, false, 2, "Brown", "Non enim veniam fugiat adipisicing nulla anim ipsum. Nisi dolore sit amet id magna. Nostrud ad fugiat non velit aliqua ex Lorem do. Laboris enim ipsum officia dolore cupidatat aute voluptate enim excepteur irure laborum aliqua eiusmod.\r\n", "Jannie-Patton", 0m, "Dianne Trujillo" },
                    { 3, false, 1, "Rhoda", "Est tempor ad eiusmod non non adipisicing nisi tempor nostrud aute. Veniam aute nisi velit fugiat eu ad aliqua incididunt est sunt. Mollit duis ullamco est sint tempor dolore laboris aliqua incididunt aute cillum excepteur. Occaecat laboris fugiat fugiat quis consequat excepteur. Sit id anim officia nulla mollit.\r\n", "Danielle-Dudley", 0m, "Kathryn Gates" },
                    { 4, true, 1, "Lowe", "Adipisicing nostrud consectetur tempor sit Lorem. Eiusmod amet ipsum consequat tempor ex laboris sit deserunt consectetur labore deserunt anim. Consequat ad occaecat cillum nisi irure dolore velit occaecat dolore pariatur labore. Dolor pariatur ea laborum et ipsum excepteur duis qui aliqua aute deserunt commodo enim nisi. Quis tempor incididunt sunt nostrud irure aute incididunt. Fugiat ipsum laboris magna exercitation ipsum. Ut amet exercitation deserunt elit sit enim occaecat irure ea in.\r\n", "Lesa-Cameron", 0m, "Morton Nicholson" },
                    { 5, false, 2, "Harvey", "Aute aliqua ex velit sunt laborum qui deserunt culpa duis est occaecat. Mollit enim sunt nulla duis sint minim dolore. Non enim dolor pariatur esse officia id ex ipsum elit pariatur quis non pariatur.\r\n", "Ursula-Allison", 0m, "Pickett Howard" },
                    { 6, true, 1, "Oliver", "Irure laborum quis sunt non voluptate anim nisi veniam cillum qui labore eiusmod cupidatat culpa. Eiusmod excepteur sint quis Lorem cupidatat tempor incididunt quis. Do amet sit sit qui laborum occaecat adipisicing.\r\n", "Brock-Andrews", 0m, "Miles Pacheco" },
                    { 7, true, 2, "Suzanne", "Sunt duis duis non dolor do eiusmod laboris esse ullamco enim est. Et minim fugiat consequat ea ipsum Lorem esse non incididunt labore minim dolore. Elit in non do proident aliquip tempor eu. Ad incididunt cupidatat nulla eu sunt. Consequat labore exercitation sint fugiat eu qui adipisicing sint reprehenderit Lorem nisi dolor velit nostrud. Nisi dolore sint sint anim velit eiusmod. Sit esse do do velit sit sit aute do nulla ad aliquip nisi nostrud ea.\r\n", "Marina-Bean", 0m, "Gill Langley" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 24, 20, 11, 43, 85, DateTimeKind.Utc).AddTicks(7828),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 24, 20, 27, 47, 203, DateTimeKind.Utc).AddTicks(4933));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 24, 20, 11, 43, 85, DateTimeKind.Utc).AddTicks(7505),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 24, 20, 27, 47, 203, DateTimeKind.Utc).AddTicks(4703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 24, 20, 11, 43, 85, DateTimeKind.Utc).AddTicks(644),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 24, 20, 27, 47, 202, DateTimeKind.Utc).AddTicks(8351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 24, 20, 11, 43, 85, DateTimeKind.Utc).AddTicks(353),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 5, 24, 20, 27, 47, 202, DateTimeKind.Utc).AddTicks(8110));
        }
    }
}
