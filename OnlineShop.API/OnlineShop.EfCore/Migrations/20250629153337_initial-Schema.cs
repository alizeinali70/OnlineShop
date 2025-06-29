using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineShop.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class initialSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_ProductCategory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Is_Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ProductCategory", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "T_ProductModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Is_Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ProductModel", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "T_Role",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Role", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "T_Product",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Max_Sell = table.Column<int>(type: "int", nullable: false),
                    Price1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount_Price1 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Price2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount_Price2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Cover_Price1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Cover_Price2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Single = table.Column<bool>(type: "bit", nullable: false),
                    Double = table.Column<bool>(type: "bit", nullable: false),
                    Save_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Send_Fast = table.Column<bool>(type: "bit", nullable: false),
                    Sell_State = table.Column<bool>(type: "bit", nullable: false),
                    Is_Active = table.Column<bool>(type: "bit", nullable: false),
                    Special_Offer = table.Column<bool>(type: "bit", nullable: false),
                    Image1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Garanty_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Garanty_Start_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Seo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    ModelId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_T_Product_T_ProductCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "T_ProductCategory",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_Product_T_ProductModel_ModelId",
                        column: x => x.ModelId,
                        principalTable: "T_ProductModel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_SpecialMember",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Branch_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Store_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manager_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mellicode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Provience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Postal_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile_Whatsup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Property_Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Store_Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Store_Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Store_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Start_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Working_Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sell_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Accounting_Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seller_Count = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other_Brands = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermissionId = table.Column<int>(type: "int", nullable: false),
                    Is_Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_SpecialMember", x => x.ID);
                    table.ForeignKey(
                        name: "FK_T_SpecialMember_T_Role_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "T_Role",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_ProductImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ProductImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_ProductImage_T_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "T_Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_Product_CategoryId",
                table: "T_Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Product_ModelId",
                table: "T_Product",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_T_ProductImage_ProductId",
                table: "T_ProductImage",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_T_SpecialMember_PermissionId",
                table: "T_SpecialMember",
                column: "PermissionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_ProductImage");

            migrationBuilder.DropTable(
                name: "T_SpecialMember");

            migrationBuilder.DropTable(
                name: "T_Product");

            migrationBuilder.DropTable(
                name: "T_Role");

            migrationBuilder.DropTable(
                name: "T_ProductCategory");

            migrationBuilder.DropTable(
                name: "T_ProductModel");
        }
    }
}
