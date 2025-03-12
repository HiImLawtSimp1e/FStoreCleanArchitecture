using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FStore.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    VoucherName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDiscountPercent = table.Column<bool>(type: "bit", nullable: false),
                    DiscountValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MinOrderCondition = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaxDiscountValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductAttributes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttributes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    AddressLine = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    CartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => new { x.CartId, x.ProductId, x.ProductTypeId });
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvoiceCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<int>(type: "int", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DiscountValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsCounterOrder = table.Column<bool>(type: "bit", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CouponId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Coupons_CouponId",
                        column: x => x.CouponId,
                        principalTable: "Coupons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "ProductValues",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductAttributeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductValues", x => new { x.ProductId, x.ProductAttributeId });
                    table.ForeignKey(
                        name: "FK_ProductValues_ProductAttributes_ProductAttributeId",
                        column: x => x.ProductAttributeId,
                        principalTable: "ProductAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductValues_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariants",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariants", x => new { x.ProductId, x.ProductTypeId });
                    table.ForeignKey(
                        name: "FK_ProductVariants_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariants_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProductTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => new { x.OrderId, x.ProductId, x.ProductTypeId });
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Deleted", "IsActive", "ModifiedAt", "ModifiedBy", "PasswordHash", "PasswordSalt", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("0e5c838e-f387-4183-a1c1-4c1e802ab180"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6038), "", false, true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6038), "", new byte[] { 113, 162, 164, 142, 159, 186, 21, 181, 206, 8, 149, 141, 106, 225, 214, 12, 78, 239, 138, 210, 85, 144, 227, 174, 227, 218, 53, 69, 95, 53, 81, 10, 169, 26, 92, 125, 52, 237, 214, 87, 161, 5, 146, 28, 190, 3, 66, 15, 155, 183, 125, 106, 15, 234, 20, 103, 50, 157, 54, 7, 154, 24, 141, 57 }, new byte[] { 173, 229, 225, 163, 179, 98, 148, 8, 108, 156, 212, 21, 240, 24, 75, 84, 175, 191, 25, 68, 55, 22, 78, 87, 53, 62, 124, 143, 250, 203, 111, 58, 186, 70, 251, 101, 145, 14, 107, 196, 81, 107, 21, 250, 63, 156, 191, 253, 189, 30, 124, 133, 236, 248, 17, 169, 234, 219, 47, 55, 221, 247, 147, 170, 30, 240, 215, 118, 77, 159, 92, 109, 59, 96, 153, 30, 0, 198, 166, 13, 115, 142, 132, 191, 177, 208, 37, 43, 244, 150, 65, 152, 91, 40, 177, 0, 135, 131, 76, 68, 217, 6, 183, 233, 79, 33, 45, 79, 139, 205, 35, 148, 169, 11, 182, 181, 34, 92, 25, 158, 149, 153, 72, 191, 44, 88, 186, 2 }, 0, "tranlan@example.com" },
                    { new Guid("2b25a754-a50e-4468-942c-d65c0bc2c86f"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6024), "", false, true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6025), "", new byte[] { 113, 162, 164, 142, 159, 186, 21, 181, 206, 8, 149, 141, 106, 225, 214, 12, 78, 239, 138, 210, 85, 144, 227, 174, 227, 218, 53, 69, 95, 53, 81, 10, 169, 26, 92, 125, 52, 237, 214, 87, 161, 5, 146, 28, 190, 3, 66, 15, 155, 183, 125, 106, 15, 234, 20, 103, 50, 157, 54, 7, 154, 24, 141, 57 }, new byte[] { 173, 229, 225, 163, 179, 98, 148, 8, 108, 156, 212, 21, 240, 24, 75, 84, 175, 191, 25, 68, 55, 22, 78, 87, 53, 62, 124, 143, 250, 203, 111, 58, 186, 70, 251, 101, 145, 14, 107, 196, 81, 107, 21, 250, 63, 156, 191, 253, 189, 30, 124, 133, 236, 248, 17, 169, 234, 219, 47, 55, 221, 247, 147, 170, 30, 240, 215, 118, 77, 159, 92, 109, 59, 96, 153, 30, 0, 198, 166, 13, 115, 142, 132, 191, 177, 208, 37, 43, 244, 150, 65, 152, 91, 40, 177, 0, 135, 131, 76, 68, 217, 6, 183, 233, 79, 33, 45, 79, 139, 205, 35, 148, 169, 11, 182, 181, 34, 92, 25, 158, 149, 153, 72, 191, 44, 88, 186, 2 }, 0, "customer@example.com" },
                    { new Guid("3141069d-f4f3-475c-8efc-99e1b4c3e627"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6030), "", false, true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6030), "", new byte[] { 113, 162, 164, 142, 159, 186, 21, 181, 206, 8, 149, 141, 106, 225, 214, 12, 78, 239, 138, 210, 85, 144, 227, 174, 227, 218, 53, 69, 95, 53, 81, 10, 169, 26, 92, 125, 52, 237, 214, 87, 161, 5, 146, 28, 190, 3, 66, 15, 155, 183, 125, 106, 15, 234, 20, 103, 50, 157, 54, 7, 154, 24, 141, 57 }, new byte[] { 173, 229, 225, 163, 179, 98, 148, 8, 108, 156, 212, 21, 240, 24, 75, 84, 175, 191, 25, 68, 55, 22, 78, 87, 53, 62, 124, 143, 250, 203, 111, 58, 186, 70, 251, 101, 145, 14, 107, 196, 81, 107, 21, 250, 63, 156, 191, 253, 189, 30, 124, 133, 236, 248, 17, 169, 234, 219, 47, 55, 221, 247, 147, 170, 30, 240, 215, 118, 77, 159, 92, 109, 59, 96, 153, 30, 0, 198, 166, 13, 115, 142, 132, 191, 177, 208, 37, 43, 244, 150, 65, 152, 91, 40, 177, 0, 135, 131, 76, 68, 217, 6, 183, 233, 79, 33, 45, 79, 139, 205, 35, 148, 169, 11, 182, 181, 34, 92, 25, 158, 149, 153, 72, 191, 44, 88, 186, 2 }, 2, "employee@example.com" },
                    { new Guid("3a9477da-b75c-4ef6-9bf6-a93aa5ffaf6f"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6051), "", false, true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6051), "", new byte[] { 113, 162, 164, 142, 159, 186, 21, 181, 206, 8, 149, 141, 106, 225, 214, 12, 78, 239, 138, 210, 85, 144, 227, 174, 227, 218, 53, 69, 95, 53, 81, 10, 169, 26, 92, 125, 52, 237, 214, 87, 161, 5, 146, 28, 190, 3, 66, 15, 155, 183, 125, 106, 15, 234, 20, 103, 50, 157, 54, 7, 154, 24, 141, 57 }, new byte[] { 173, 229, 225, 163, 179, 98, 148, 8, 108, 156, 212, 21, 240, 24, 75, 84, 175, 191, 25, 68, 55, 22, 78, 87, 53, 62, 124, 143, 250, 203, 111, 58, 186, 70, 251, 101, 145, 14, 107, 196, 81, 107, 21, 250, 63, 156, 191, 253, 189, 30, 124, 133, 236, 248, 17, 169, 234, 219, 47, 55, 221, 247, 147, 170, 30, 240, 215, 118, 77, 159, 92, 109, 59, 96, 153, 30, 0, 198, 166, 13, 115, 142, 132, 191, 177, 208, 37, 43, 244, 150, 65, 152, 91, 40, 177, 0, 135, 131, 76, 68, 217, 6, 183, 233, 79, 33, 45, 79, 139, 205, 35, 148, 169, 11, 182, 181, 34, 92, 25, 158, 149, 153, 72, 191, 44, 88, 186, 2 }, 0, "hoangmai@example.com" },
                    { new Guid("3aec8f0b-3a6a-4b5d-8a3a-348ae529001a"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(5994), "", false, true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6009), "", new byte[] { 113, 162, 164, 142, 159, 186, 21, 181, 206, 8, 149, 141, 106, 225, 214, 12, 78, 239, 138, 210, 85, 144, 227, 174, 227, 218, 53, 69, 95, 53, 81, 10, 169, 26, 92, 125, 52, 237, 214, 87, 161, 5, 146, 28, 190, 3, 66, 15, 155, 183, 125, 106, 15, 234, 20, 103, 50, 157, 54, 7, 154, 24, 141, 57 }, new byte[] { 173, 229, 225, 163, 179, 98, 148, 8, 108, 156, 212, 21, 240, 24, 75, 84, 175, 191, 25, 68, 55, 22, 78, 87, 53, 62, 124, 143, 250, 203, 111, 58, 186, 70, 251, 101, 145, 14, 107, 196, 81, 107, 21, 250, 63, 156, 191, 253, 189, 30, 124, 133, 236, 248, 17, 169, 234, 219, 47, 55, 221, 247, 147, 170, 30, 240, 215, 118, 77, 159, 92, 109, 59, 96, 153, 30, 0, 198, 166, 13, 115, 142, 132, 191, 177, 208, 37, 43, 244, 150, 65, 152, 91, 40, 177, 0, 135, 131, 76, 68, 217, 6, 183, 233, 79, 33, 45, 79, 139, 205, 35, 148, 169, 11, 182, 181, 34, 92, 25, 158, 149, 153, 72, 191, 44, 88, 186, 2 }, 1, "admin@example.com" },
                    { new Guid("463d52ee-4c4e-40b0-a8f3-e59086878964"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6042), "", false, true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6043), "", new byte[] { 113, 162, 164, 142, 159, 186, 21, 181, 206, 8, 149, 141, 106, 225, 214, 12, 78, 239, 138, 210, 85, 144, 227, 174, 227, 218, 53, 69, 95, 53, 81, 10, 169, 26, 92, 125, 52, 237, 214, 87, 161, 5, 146, 28, 190, 3, 66, 15, 155, 183, 125, 106, 15, 234, 20, 103, 50, 157, 54, 7, 154, 24, 141, 57 }, new byte[] { 173, 229, 225, 163, 179, 98, 148, 8, 108, 156, 212, 21, 240, 24, 75, 84, 175, 191, 25, 68, 55, 22, 78, 87, 53, 62, 124, 143, 250, 203, 111, 58, 186, 70, 251, 101, 145, 14, 107, 196, 81, 107, 21, 250, 63, 156, 191, 253, 189, 30, 124, 133, 236, 248, 17, 169, 234, 219, 47, 55, 221, 247, 147, 170, 30, 240, 215, 118, 77, 159, 92, 109, 59, 96, 153, 30, 0, 198, 166, 13, 115, 142, 132, 191, 177, 208, 37, 43, 244, 150, 65, 152, 91, 40, 177, 0, 135, 131, 76, 68, 217, 6, 183, 233, 79, 33, 45, 79, 139, 205, 35, 148, 169, 11, 182, 181, 34, 92, 25, 158, 149, 153, 72, 191, 44, 88, 186, 2 }, 0, "phantuyet@example.com" },
                    { new Guid("4b45812f-2f47-41b9-b913-39bed1b02c1d"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6049), "", false, true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6049), "", new byte[] { 113, 162, 164, 142, 159, 186, 21, 181, 206, 8, 149, 141, 106, 225, 214, 12, 78, 239, 138, 210, 85, 144, 227, 174, 227, 218, 53, 69, 95, 53, 81, 10, 169, 26, 92, 125, 52, 237, 214, 87, 161, 5, 146, 28, 190, 3, 66, 15, 155, 183, 125, 106, 15, 234, 20, 103, 50, 157, 54, 7, 154, 24, 141, 57 }, new byte[] { 173, 229, 225, 163, 179, 98, 148, 8, 108, 156, 212, 21, 240, 24, 75, 84, 175, 191, 25, 68, 55, 22, 78, 87, 53, 62, 124, 143, 250, 203, 111, 58, 186, 70, 251, 101, 145, 14, 107, 196, 81, 107, 21, 250, 63, 156, 191, 253, 189, 30, 124, 133, 236, 248, 17, 169, 234, 219, 47, 55, 221, 247, 147, 170, 30, 240, 215, 118, 77, 159, 92, 109, 59, 96, 153, 30, 0, 198, 166, 13, 115, 142, 132, 191, 177, 208, 37, 43, 244, 150, 65, 152, 91, 40, 177, 0, 135, 131, 76, 68, 217, 6, 183, 233, 79, 33, 45, 79, 139, 205, 35, 148, 169, 11, 182, 181, 34, 92, 25, 158, 149, 153, 72, 191, 44, 88, 186, 2 }, 0, "tranle@example.com" },
                    { new Guid("6060ab5a-ca8b-409c-87b2-363a69f06e66"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6035), "", false, true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6036), "", new byte[] { 113, 162, 164, 142, 159, 186, 21, 181, 206, 8, 149, 141, 106, 225, 214, 12, 78, 239, 138, 210, 85, 144, 227, 174, 227, 218, 53, 69, 95, 53, 81, 10, 169, 26, 92, 125, 52, 237, 214, 87, 161, 5, 146, 28, 190, 3, 66, 15, 155, 183, 125, 106, 15, 234, 20, 103, 50, 157, 54, 7, 154, 24, 141, 57 }, new byte[] { 173, 229, 225, 163, 179, 98, 148, 8, 108, 156, 212, 21, 240, 24, 75, 84, 175, 191, 25, 68, 55, 22, 78, 87, 53, 62, 124, 143, 250, 203, 111, 58, 186, 70, 251, 101, 145, 14, 107, 196, 81, 107, 21, 250, 63, 156, 191, 253, 189, 30, 124, 133, 236, 248, 17, 169, 234, 219, 47, 55, 221, 247, 147, 170, 30, 240, 215, 118, 77, 159, 92, 109, 59, 96, 153, 30, 0, 198, 166, 13, 115, 142, 132, 191, 177, 208, 37, 43, 244, 150, 65, 152, 91, 40, 177, 0, 135, 131, 76, 68, 217, 6, 183, 233, 79, 33, 45, 79, 139, 205, 35, 148, 169, 11, 182, 181, 34, 92, 25, 158, 149, 153, 72, 191, 44, 88, 186, 2 }, 0, "lethimai@example.com" },
                    { new Guid("80cd99a5-f3e4-43f6-a725-f4e07fa7cd7d"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6044), "", false, true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6045), "", new byte[] { 113, 162, 164, 142, 159, 186, 21, 181, 206, 8, 149, 141, 106, 225, 214, 12, 78, 239, 138, 210, 85, 144, 227, 174, 227, 218, 53, 69, 95, 53, 81, 10, 169, 26, 92, 125, 52, 237, 214, 87, 161, 5, 146, 28, 190, 3, 66, 15, 155, 183, 125, 106, 15, 234, 20, 103, 50, 157, 54, 7, 154, 24, 141, 57 }, new byte[] { 173, 229, 225, 163, 179, 98, 148, 8, 108, 156, 212, 21, 240, 24, 75, 84, 175, 191, 25, 68, 55, 22, 78, 87, 53, 62, 124, 143, 250, 203, 111, 58, 186, 70, 251, 101, 145, 14, 107, 196, 81, 107, 21, 250, 63, 156, 191, 253, 189, 30, 124, 133, 236, 248, 17, 169, 234, 219, 47, 55, 221, 247, 147, 170, 30, 240, 215, 118, 77, 159, 92, 109, 59, 96, 153, 30, 0, 198, 166, 13, 115, 142, 132, 191, 177, 208, 37, 43, 244, 150, 65, 152, 91, 40, 177, 0, 135, 131, 76, 68, 217, 6, 183, 233, 79, 33, 45, 79, 139, 205, 35, 148, 169, 11, 182, 181, 34, 92, 25, 158, 149, 153, 72, 191, 44, 88, 186, 2 }, 0, "vuvankhai@example.com" },
                    { new Guid("a3339dd7-94b9-4f12-9d18-2ee341b4f35c"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6033), "", false, true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6034), "", new byte[] { 113, 162, 164, 142, 159, 186, 21, 181, 206, 8, 149, 141, 106, 225, 214, 12, 78, 239, 138, 210, 85, 144, 227, 174, 227, 218, 53, 69, 95, 53, 81, 10, 169, 26, 92, 125, 52, 237, 214, 87, 161, 5, 146, 28, 190, 3, 66, 15, 155, 183, 125, 106, 15, 234, 20, 103, 50, 157, 54, 7, 154, 24, 141, 57 }, new byte[] { 173, 229, 225, 163, 179, 98, 148, 8, 108, 156, 212, 21, 240, 24, 75, 84, 175, 191, 25, 68, 55, 22, 78, 87, 53, 62, 124, 143, 250, 203, 111, 58, 186, 70, 251, 101, 145, 14, 107, 196, 81, 107, 21, 250, 63, 156, 191, 253, 189, 30, 124, 133, 236, 248, 17, 169, 234, 219, 47, 55, 221, 247, 147, 170, 30, 240, 215, 118, 77, 159, 92, 109, 59, 96, 153, 30, 0, 198, 166, 13, 115, 142, 132, 191, 177, 208, 37, 43, 244, 150, 65, 152, 91, 40, 177, 0, 135, 131, 76, 68, 217, 6, 183, 233, 79, 33, 45, 79, 139, 205, 35, 148, 169, 11, 182, 181, 34, 92, 25, 158, 149, 153, 72, 191, 44, 88, 186, 2 }, 0, "nguyenvanminh@example.com" },
                    { new Guid("ae4c4f03-aa8a-4f37-a7cb-c5bc06e08d74"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6040), "", false, true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6040), "", new byte[] { 113, 162, 164, 142, 159, 186, 21, 181, 206, 8, 149, 141, 106, 225, 214, 12, 78, 239, 138, 210, 85, 144, 227, 174, 227, 218, 53, 69, 95, 53, 81, 10, 169, 26, 92, 125, 52, 237, 214, 87, 161, 5, 146, 28, 190, 3, 66, 15, 155, 183, 125, 106, 15, 234, 20, 103, 50, 157, 54, 7, 154, 24, 141, 57 }, new byte[] { 173, 229, 225, 163, 179, 98, 148, 8, 108, 156, 212, 21, 240, 24, 75, 84, 175, 191, 25, 68, 55, 22, 78, 87, 53, 62, 124, 143, 250, 203, 111, 58, 186, 70, 251, 101, 145, 14, 107, 196, 81, 107, 21, 250, 63, 156, 191, 253, 189, 30, 124, 133, 236, 248, 17, 169, 234, 219, 47, 55, 221, 247, 147, 170, 30, 240, 215, 118, 77, 159, 92, 109, 59, 96, 153, 30, 0, 198, 166, 13, 115, 142, 132, 191, 177, 208, 37, 43, 244, 150, 65, 152, 91, 40, 177, 0, 135, 131, 76, 68, 217, 6, 183, 233, 79, 33, 45, 79, 139, 205, 35, 148, 169, 11, 182, 181, 34, 92, 25, 158, 149, 153, 72, 191, 44, 88, 186, 2 }, 0, "nguyenan@example.com" },
                    { new Guid("c36aab76-f6cc-46f6-a6c3-730d54b61a48"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6047), "", false, true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6047), "", new byte[] { 113, 162, 164, 142, 159, 186, 21, 181, 206, 8, 149, 141, 106, 225, 214, 12, 78, 239, 138, 210, 85, 144, 227, 174, 227, 218, 53, 69, 95, 53, 81, 10, 169, 26, 92, 125, 52, 237, 214, 87, 161, 5, 146, 28, 190, 3, 66, 15, 155, 183, 125, 106, 15, 234, 20, 103, 50, 157, 54, 7, 154, 24, 141, 57 }, new byte[] { 173, 229, 225, 163, 179, 98, 148, 8, 108, 156, 212, 21, 240, 24, 75, 84, 175, 191, 25, 68, 55, 22, 78, 87, 53, 62, 124, 143, 250, 203, 111, 58, 186, 70, 251, 101, 145, 14, 107, 196, 81, 107, 21, 250, 63, 156, 191, 253, 189, 30, 124, 133, 236, 248, 17, 169, 234, 219, 47, 55, 221, 247, 147, 170, 30, 240, 215, 118, 77, 159, 92, 109, 59, 96, 153, 30, 0, 198, 166, 13, 115, 142, 132, 191, 177, 208, 37, 43, 244, 150, 65, 152, 91, 40, 177, 0, 135, 131, 76, 68, 217, 6, 183, 233, 79, 33, 45, 79, 139, 205, 35, 148, 169, 11, 182, 181, 34, 92, 25, 158, 149, 153, 72, 191, 44, 88, 186, 2 }, 0, "lehoanganh@example.com" },
                    { new Guid("d15fcb08-fcb1-4a55-b012-b2be211ed2c1"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6053), "", false, true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6054), "", new byte[] { 113, 162, 164, 142, 159, 186, 21, 181, 206, 8, 149, 141, 106, 225, 214, 12, 78, 239, 138, 210, 85, 144, 227, 174, 227, 218, 53, 69, 95, 53, 81, 10, 169, 26, 92, 125, 52, 237, 214, 87, 161, 5, 146, 28, 190, 3, 66, 15, 155, 183, 125, 106, 15, 234, 20, 103, 50, 157, 54, 7, 154, 24, 141, 57 }, new byte[] { 173, 229, 225, 163, 179, 98, 148, 8, 108, 156, 212, 21, 240, 24, 75, 84, 175, 191, 25, 68, 55, 22, 78, 87, 53, 62, 124, 143, 250, 203, 111, 58, 186, 70, 251, 101, 145, 14, 107, 196, 81, 107, 21, 250, 63, 156, 191, 253, 189, 30, 124, 133, 236, 248, 17, 169, 234, 219, 47, 55, 221, 247, 147, 170, 30, 240, 215, 118, 77, 159, 92, 109, 59, 96, 153, 30, 0, 198, 166, 13, 115, 142, 132, 191, 177, 208, 37, 43, 244, 150, 65, 152, 91, 40, 177, 0, 135, 131, 76, 68, 217, 6, 183, 233, 79, 33, 45, 79, 139, 205, 35, 148, 169, 11, 182, 181, 34, 92, 25, 158, 149, 153, 72, 191, 44, 88, 186, 2 }, 0, "lehoa@example.com" },
                    { new Guid("db757696-89d6-4f61-84bb-61bc9b87ea05"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6026), "", false, true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6027), "", new byte[] { 113, 162, 164, 142, 159, 186, 21, 181, 206, 8, 149, 141, 106, 225, 214, 12, 78, 239, 138, 210, 85, 144, 227, 174, 227, 218, 53, 69, 95, 53, 81, 10, 169, 26, 92, 125, 52, 237, 214, 87, 161, 5, 146, 28, 190, 3, 66, 15, 155, 183, 125, 106, 15, 234, 20, 103, 50, 157, 54, 7, 154, 24, 141, 57 }, new byte[] { 173, 229, 225, 163, 179, 98, 148, 8, 108, 156, 212, 21, 240, 24, 75, 84, 175, 191, 25, 68, 55, 22, 78, 87, 53, 62, 124, 143, 250, 203, 111, 58, 186, 70, 251, 101, 145, 14, 107, 196, 81, 107, 21, 250, 63, 156, 191, 253, 189, 30, 124, 133, 236, 248, 17, 169, 234, 219, 47, 55, 221, 247, 147, 170, 30, 240, 215, 118, 77, 159, 92, 109, 59, 96, 153, 30, 0, 198, 166, 13, 115, 142, 132, 191, 177, 208, 37, 43, 244, 150, 65, 152, 91, 40, 177, 0, 135, 131, 76, 68, 217, 6, 183, 233, 79, 33, 45, 79, 139, 205, 35, 148, 169, 11, 182, 181, 34, 92, 25, 158, 149, 153, 72, 191, 44, 88, 186, 2 }, 0, "customer2@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Deleted", "IsActive", "ModifiedAt", "ModifiedBy", "Slug", "Title" },
                values: new object[,]
                {
                    { new Guid("2c8eb836-090b-4a18-a869-620d7f527180"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6672), "", false, true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6672), "", "movies", "Movies" },
                    { new Guid("a186203e-0d11-4c22-a45e-58ecfeed368f"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6669), "", false, true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6670), "", "books", "Books" },
                    { new Guid("c236f9f6-2c4c-4ba3-99ed-9cf81ee9bf46"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6674), "", false, true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6674), "", "video-games", "Video Games" }
                });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "Id", "Code", "CreatedAt", "CreatedBy", "DiscountValue", "EndDate", "IsActive", "IsDiscountPercent", "MaxDiscountValue", "MinOrderCondition", "ModifiedAt", "ModifiedBy", "Quantity", "StartDate", "VoucherName" },
                values: new object[,]
                {
                    { new Guid("16b8caa5-5f02-4e81-8c3f-a8dcbbaff6be"), "SUMMER24", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(7040), "", 24.00m, new DateTime(2025, 4, 11, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(7054), true, true, 80000m, 200000m, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(7041), "", 1000, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(7051), "Summer 24% Discount" },
                    { new Guid("b6b99651-a7ca-494b-a717-bfa3c4c46411"), "SUMMER20000", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(7056), "", 19.00m, new DateTime(2025, 4, 11, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(7064), true, false, 0m, 199m, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(7057), "", 1000, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(7063), "Summer 20000VND Discount" }
                });

            migrationBuilder.InsertData(
                table: "ProductAttributes",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("09ec0726-d537-4c92-aaaf-760f19c6999f"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6617), "", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6617), "", "Publisher" },
                    { new Guid("4150124b-2a58-4d98-8abe-f380e99a6fa9"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6631), "", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6632), "", "Developer" },
                    { new Guid("50b7176f-4b13-484b-aec4-edf9383b9232"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6621), "", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6621), "", "Pages" },
                    { new Guid("99bf3d94-a248-46f8-bbcb-0f9ae07ce1af"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6626), "", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6626), "", "Writers" },
                    { new Guid("a5913406-23e7-4451-a19c-242c974e312e"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6628), "", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6628), "", "Stars" },
                    { new Guid("b96ab5d0-3155-4688-8fb4-c6427e0661d5"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6622), "", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6623), "", "Directors" },
                    { new Guid("bd2d16dc-10a9-40b1-b76a-e39f3c015086"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6614), "", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6615), "", "Author" },
                    { new Guid("c84ec2fc-651b-42e1-b073-022596ac90c0"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6629), "", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6630), "", "Gerne" },
                    { new Guid("d369dc76-92cf-417a-aea5-17616c87d4ce"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6619), "", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6619), "", "ISBN" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("43a56b31-2f02-4e9d-88b0-2b3ced2276ba"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6433), "", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6434), "", "Audiobook" },
                    { new Guid("7c604dd7-d603-4f6a-b5bf-f254bd812787"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6439), "", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6439), "", "VHS" },
                    { new Guid("934902b5-c2a2-4fbc-97c2-8887ed45d08e"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6445), "", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6445), "", "Xbox" },
                    { new Guid("b28481c3-51fb-4a94-8558-0ac0ebfb1607"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6431), "", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6432), "", "E-Book" },
                    { new Guid("dfd52a60-8ccf-4ac2-980c-14ddf41e9a18"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6435), "", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6436), "", "Stream" },
                    { new Guid("e21526c4-f78b-4eb5-8ae0-919633179582"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6426), "", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6427), "", "Default" },
                    { new Guid("e2d9219f-c57b-4c59-bea0-6a3af2e655a5"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6441), "", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6441), "", "PC" },
                    { new Guid("f728c3bf-b4d8-41f6-93ab-7a91cba390be"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6443), "", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6443), "", "PlayStation" },
                    { new Guid("fbaeaba4-a5bc-487e-b0e5-0967ff543d5d"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6437), "", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6437), "", "Blu-ray" },
                    { new Guid("ff58b31e-53d5-4216-84a4-0566cb2e9b52"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6428), "", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6429), "", "Paperback" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AccountId", "AddressLine", "CreatedAt", "CreatedBy", "Email", "IsMain", "ModifiedAt", "ModifiedBy", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("10d1439e-7a64-418b-b526-e5c41f7e2268"), new Guid("6060ab5a-ca8b-409c-87b2-363a69f06e66"), "789 Đường Lê Văn Sỹ, Phường 13, Quận 3, TP. Hồ Chí Minh", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6343), "", "lethimai@example.com", true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6344), "", "Lê Thị Mai", "0912345679" },
                    { new Guid("1423b022-1331-40d7-9b9e-25858e5c1bdc"), new Guid("3141069d-f4f3-475c-8efc-99e1b4c3e627"), "121 Đường Cầu Giấy ,Cầu Giấy, Hà Nội", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6337), "", "johnemployee@example.com", true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6337), "", "John Employee", "1234567892" },
                    { new Guid("23e56a4c-485e-4ccb-a0b3-c98d23d9ac78"), new Guid("ae4c4f03-aa8a-4f37-a7cb-c5bc06e08d74"), "456 Đường Nguyễn Thái Học, Phường 10, TP. Cần Thơ", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6350), "", "nguyenan@example.com", true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6350), "", "Nguyễn Thị An", "0976543210" },
                    { new Guid("664f6353-9331-4f44-a060-b21b118e4dac"), new Guid("d15fcb08-fcb1-4a55-b012-b2be211ed2c1"), "789 Đường Lý Thường Kiệt, Phường Bắc Lý, TP. Quảng Bình", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6372), "", "lehoa@example.com", true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6373), "", "Lê Thị Hòa", "0934567890" },
                    { new Guid("752fcad2-c2b7-49b6-a3b6-a4da0119f8d7"), new Guid("2b25a754-a50e-4468-942c-d65c0bc2c86f"), "25 Phình Hồ, Văn Chấn, Yên Bái", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6311), "", "dangnhung72@gmail.com", false, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6312), "", "Đăng Thị Hồng Nhung", "0366702305" },
                    { new Guid("7fdf3c0d-7d62-4d51-b5d4-247bb517d267"), new Guid("3aec8f0b-3a6a-4b5d-8a3a-348ae529001a"), "125 Đường Cầu Giấy ,Cầu Giấy, Hà Nội", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6277), "", "johnadmin@example.com", true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6278), "", "John Admin", "1234567891" },
                    { new Guid("80b4cf8e-890e-4ae1-b31d-255b7e32986e"), new Guid("463d52ee-4c4e-40b0-a8f3-e59086878964"), "789 Đường Võ Văn Tần, Phường 5, Quận 3, TP. Hồ Chí Minh", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6353), "", "phantuyet@example.com", true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6353), "", "Phan Thị Tuyết", "0901234567" },
                    { new Guid("8711a1b3-b9fa-4f4b-bfa8-fbd4ae0903c1"), new Guid("0e5c838e-f387-4183-a1c1-4c1e802ab180"), "123 Đường Lê Lai, Phường Phú Hòa, TP. Thủ Dầu Một, Bình Dương", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6347), "", "tranlan@example.com", true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6347), "", "Trần Thị Lan", "0908765432" },
                    { new Guid("8e9569a7-ade1-405a-a505-61f7fcd33f17"), new Guid("c36aab76-f6cc-46f6-a6c3-730d54b61a48"), "234 Đường Hà Huy Tập, Phường Đông Vệ, TP. Thanh Hóa", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6363), "", "lehoanganh@example.com", true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6363), "", "Lê Hoàng Anh", "0923456789" },
                    { new Guid("9f6fcb0a-ec6e-41d2-9f4b-859df07960ae"), new Guid("80cd99a5-f3e4-43f6-a725-f4e07fa7cd7d"), "123 Đường Trường Chinh, Phường 14, Quận Tân Bình, TP. Hồ Chí Minh", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6359), "", "vuvankhai@example.com", true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6360), "", "Vũ Văn Khải", "0912345678" },
                    { new Guid("a6acadd8-9ca3-4bc2-a63e-5cb9017607b7"), new Guid("a3339dd7-94b9-4f12-9d18-2ee341b4f35c"), "456 Đường Nguyễn Trãi, Phường Bến Thành, Quận 1, TP. Hồ Chí Minh", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6340), "", "minhnguyen@example.com", true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6340), "", "Nguyễn Văn Minh", "0987654321" },
                    { new Guid("ae164e96-6f2b-456f-b82c-604b6cba14fa"), new Guid("db757696-89d6-4f61-84bb-61bc9b87ea05"), "20 Nguyễn Trãi, Thanh Xuân, Hà Nội", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6330), "", "lethib@example.com", false, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6330), "", "Lê Thị Bích", "0923456789" },
                    { new Guid("caaa56bd-49e8-41ce-8388-00e6b275cd51"), new Guid("3a9477da-b75c-4ef6-9bf6-a93aa5ffaf6f"), "456 Đường Phan Chu Trinh, Phường 5, TP. Đà Nẵng", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6369), "", "hoangmai@example.com", true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6370), "", "Hoàng Thị Mai", "0976543210" },
                    { new Guid("d60074ef-a194-4e48-b0c2-6c31780f0628"), new Guid("db757696-89d6-4f61-84bb-61bc9b87ea05"), "88 Đường Giải Phóng, Hoàng Mai, Hà Nội", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6333), "", "phamvanc@example.com", false, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6334), "", "Phạm Văn Công", "0934567890" },
                    { new Guid("e6c59fe6-25f5-436d-8a69-c54399f6b21f"), new Guid("2b25a754-a50e-4468-942c-d65c0bc2c86f"), "22 Ngã Ba Kim, Mù Cang Chải, Yên Bái", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6314), "", "q170302@email.com", true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6315), "", "Nguyễn Quang Hưng", "0344917302" },
                    { new Guid("f09f4f6f-8e2b-4f85-bf4a-f41c44f5d7ff"), new Guid("4b45812f-2f47-41b9-b913-39bed1b02c1d"), "123 Đường Nguyễn Văn Linh, Phường Tân Hưng, Quận 7, TP. Hồ Chí Minh", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6366), "", "tranle@example.com", true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6366), "", "Trần Thị Lệ", "0987654321" },
                    { new Guid("fbd33aa5-402b-4cd0-8ce3-348c121779e8"), new Guid("db757696-89d6-4f61-84bb-61bc9b87ea05"), "15 Lê Văn Lương, Thanh Xuân, Hà Nội", new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6317), "", "nguyenvana@example.com", true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6318), "", "Nguyễn Văn An", "0912345678" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "CreatedBy", "Deleted", "Description", "ImageUrl", "IsActive", "ModifiedAt", "ModifiedBy", "Slug", "Title" },
                values: new object[,]
                {
                    { new Guid("00cab8fd-ad0e-433b-8bb0-2c9596809b7b"), new Guid("c236f9f6-2c4c-4ba3-99ed-9cf81ee9bf46"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6733), "", false, "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.", "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6734), "", "day-of-the-tentacle", "Day of the Tentacle" },
                    { new Guid("07acf5bd-e13d-4667-ba8e-70be6785f655"), new Guid("c236f9f6-2c4c-4ba3-99ed-9cf81ee9bf46"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6729), "", false, "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.", "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6730), "", "diablo-ii", "Diablo II" },
                    { new Guid("106e97ab-bbce-44b8-95c4-a287752d8561"), new Guid("c236f9f6-2c4c-4ba3-99ed-9cf81ee9bf46"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6725), "", false, "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.", "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6725), "", "half-life-2", "Half-Life 2" },
                    { new Guid("318f6a20-3c0b-40ca-9cf0-9533e83d3734"), new Guid("a186203e-0d11-4c22-a45e-58ecfeed368f"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6701), "", false, "The Hitchhiker's Guide to the Galaxy is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text adventure game, and 2005 feature film.", "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6701), "", "the-hitchhikers-guide-to-the-galaxy", "The Hitchhiker's Guide to the Galaxy" },
                    { new Guid("321ec52d-5fb6-4b1b-bb35-6f73cf92396d"), new Guid("2c8eb836-090b-4a18-a869-620d7f527180"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6721), "", false, "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.", "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg", true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6722), "", "toy-story", "Toy Story" },
                    { new Guid("4f5c260c-0870-4940-a394-b20c56b3fcca"), new Guid("2c8eb836-090b-4a18-a869-620d7f527180"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6713), "", false, "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.", "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg", true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6714), "", "the-matrix", "The Matrix" },
                    { new Guid("aed54a62-e6e7-4670-ab24-1c84b911deb0"), new Guid("c236f9f6-2c4c-4ba3-99ed-9cf81ee9bf46"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6742), "", false, "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.", "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6742), "", "super-nintendo-entertainment-system", "Super Nintendo Entertainment System" },
                    { new Guid("c7537965-c2cb-4e77-bfc5-6c466c9a3bea"), new Guid("a186203e-0d11-4c22-a45e-58ecfeed368f"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6709), "", false, "Nineteen Eighty-Four (also published as 1984) is a dystopian novel and cautionary tale by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society. Orwell, a democratic socialist, modelled the authoritarian state in the novel on the Soviet Union in the era of Stalinism, and Nazi Germany. More broadly, the novel examines the role of truth and facts within societies and the ways in which they can be manipulated.", "https://upload.wikimedia.org/wikipedia/en/5/51/1984_first_edition_cover.jpg", true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6709), "", "nineteen-eighty-four", "Nineteen Eighty-Four" },
                    { new Guid("ce50c69d-5897-4e3d-8d2d-081114ed1fb0"), new Guid("a186203e-0d11-4c22-a45e-58ecfeed368f"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6705), "", false, "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House). The book was published on August 16, 2011. An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters. In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association and won the 2011 Prometheus Award. A film adaptation, screenwritten by Cline and Zak Penn and directed by Steven Spielberg, was released on March 29, 2018. A sequel novel, Ready Player Two, was released on November 24, 2020, to a widely negative critical reception.", "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg", true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6706), "", "ready-player-one", "Ready Player One" },
                    { new Guid("f2b7ac53-e3e5-4f7c-8094-99530bbde9eb"), new Guid("2c8eb836-090b-4a18-a869-620d7f527180"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6717), "", false, "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.", "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg", true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6718), "", "back-to-the-future", "Back to the Future" },
                    { new Guid("fc67ff65-d124-4350-94fa-8dd1cc0559e1"), new Guid("c236f9f6-2c4c-4ba3-99ed-9cf81ee9bf46"), new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6738), "", false, "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.", "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg", true, new DateTime(2025, 3, 12, 16, 15, 1, 620, DateTimeKind.Local).AddTicks(6738), "", "xbox", "Xbox" }
                });

            migrationBuilder.InsertData(
                table: "ProductValues",
                columns: new[] { "ProductAttributeId", "ProductId", "Value" },
                values: new object[,]
                {
                    { new Guid("09ec0726-d537-4c92-aaaf-760f19c6999f"), new Guid("00cab8fd-ad0e-433b-8bb0-2c9596809b7b"), "LucasArts" },
                    { new Guid("4150124b-2a58-4d98-8abe-f380e99a6fa9"), new Guid("00cab8fd-ad0e-433b-8bb0-2c9596809b7b"), "LucasArts" },
                    { new Guid("c84ec2fc-651b-42e1-b073-022596ac90c0"), new Guid("00cab8fd-ad0e-433b-8bb0-2c9596809b7b"), "Graphic Adventure" },
                    { new Guid("09ec0726-d537-4c92-aaaf-760f19c6999f"), new Guid("07acf5bd-e13d-4667-ba8e-70be6785f655"), "Blizzard Entertainment" },
                    { new Guid("4150124b-2a58-4d98-8abe-f380e99a6fa9"), new Guid("07acf5bd-e13d-4667-ba8e-70be6785f655"), "Blizzard North" },
                    { new Guid("c84ec2fc-651b-42e1-b073-022596ac90c0"), new Guid("07acf5bd-e13d-4667-ba8e-70be6785f655"), "Action, Role-playing" },
                    { new Guid("09ec0726-d537-4c92-aaaf-760f19c6999f"), new Guid("106e97ab-bbce-44b8-95c4-a287752d8561"), "Valve" },
                    { new Guid("4150124b-2a58-4d98-8abe-f380e99a6fa9"), new Guid("106e97ab-bbce-44b8-95c4-a287752d8561"), "Valve" },
                    { new Guid("c84ec2fc-651b-42e1-b073-022596ac90c0"), new Guid("106e97ab-bbce-44b8-95c4-a287752d8561"), "Action" },
                    { new Guid("09ec0726-d537-4c92-aaaf-760f19c6999f"), new Guid("318f6a20-3c0b-40ca-9cf0-9533e83d3734"), "Random House Worlds; Reissue edition (June 23, 1997)" },
                    { new Guid("50b7176f-4b13-484b-aec4-edf9383b9232"), new Guid("318f6a20-3c0b-40ca-9cf0-9533e83d3734"), "208 pages" },
                    { new Guid("bd2d16dc-10a9-40b1-b76a-e39f3c015086"), new Guid("318f6a20-3c0b-40ca-9cf0-9533e83d3734"), "Douglas Adams" },
                    { new Guid("d369dc76-92cf-417a-aea5-17616c87d4ce"), new Guid("318f6a20-3c0b-40ca-9cf0-9533e83d3734"), "978-0345418913" },
                    { new Guid("99bf3d94-a248-46f8-bbcb-0f9ae07ce1af"), new Guid("321ec52d-5fb6-4b1b-bb35-6f73cf92396d"), "John Lasseter, Pete Docter, Andrew Stanton" },
                    { new Guid("a5913406-23e7-4451-a19c-242c974e312e"), new Guid("321ec52d-5fb6-4b1b-bb35-6f73cf92396d"), "Tom Hanks, Tim Allen, Don Rickles" },
                    { new Guid("b96ab5d0-3155-4688-8fb4-c6427e0661d5"), new Guid("321ec52d-5fb6-4b1b-bb35-6f73cf92396d"), "John Lasseter" },
                    { new Guid("99bf3d94-a248-46f8-bbcb-0f9ae07ce1af"), new Guid("4f5c260c-0870-4940-a394-b20c56b3fcca"), "Lana Wachowski, Lilly Wachowski" },
                    { new Guid("a5913406-23e7-4451-a19c-242c974e312e"), new Guid("4f5c260c-0870-4940-a394-b20c56b3fcca"), "Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss" },
                    { new Guid("b96ab5d0-3155-4688-8fb4-c6427e0661d5"), new Guid("4f5c260c-0870-4940-a394-b20c56b3fcca"), "Lana Wachowski, Lilly Wachowski" },
                    { new Guid("09ec0726-d537-4c92-aaaf-760f19c6999f"), new Guid("c7537965-c2cb-4e77-bfc5-6c466c9a3bea"), "Hawk Press (May 12, 1994)" },
                    { new Guid("50b7176f-4b13-484b-aec4-edf9383b9232"), new Guid("c7537965-c2cb-4e77-bfc5-6c466c9a3bea"), "242 pages" },
                    { new Guid("bd2d16dc-10a9-40b1-b76a-e39f3c015086"), new Guid("c7537965-c2cb-4e77-bfc5-6c466c9a3bea"), "George Orwell" },
                    { new Guid("d369dc76-92cf-417a-aea5-17616c87d4ce"), new Guid("c7537965-c2cb-4e77-bfc5-6c466c9a3bea"), "978-9388318563" },
                    { new Guid("09ec0726-d537-4c92-aaaf-760f19c6999f"), new Guid("ce50c69d-5897-4e3d-8d2d-081114ed1fb0"), "Random House Publishing Group; 32089th edition (June 5, 2012)" },
                    { new Guid("50b7176f-4b13-484b-aec4-edf9383b9232"), new Guid("ce50c69d-5897-4e3d-8d2d-081114ed1fb0"), "384 pages" },
                    { new Guid("bd2d16dc-10a9-40b1-b76a-e39f3c015086"), new Guid("ce50c69d-5897-4e3d-8d2d-081114ed1fb0"), "Ernest Cline" },
                    { new Guid("d369dc76-92cf-417a-aea5-17616c87d4ce"), new Guid("ce50c69d-5897-4e3d-8d2d-081114ed1fb0"), "978-0307887443" },
                    { new Guid("99bf3d94-a248-46f8-bbcb-0f9ae07ce1af"), new Guid("f2b7ac53-e3e5-4f7c-8094-99530bbde9eb"), "Robert Zemeckis, Bob Gale" },
                    { new Guid("a5913406-23e7-4451-a19c-242c974e312e"), new Guid("f2b7ac53-e3e5-4f7c-8094-99530bbde9eb"), "Michael J. Fox, Christopher Lloyd, Lea Thompson" },
                    { new Guid("b96ab5d0-3155-4688-8fb4-c6427e0661d5"), new Guid("f2b7ac53-e3e5-4f7c-8094-99530bbde9eb"), "Robert Zemeckis" }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("00cab8fd-ad0e-433b-8bb0-2c9596809b7b"), new Guid("e2d9219f-c57b-4c59-bea0-6a3af2e655a5"), 0m, 14.99m, 1000 },
                    { new Guid("07acf5bd-e13d-4667-ba8e-70be6785f655"), new Guid("e2d9219f-c57b-4c59-bea0-6a3af2e655a5"), 24.99m, 9.99m, 1000 },
                    { new Guid("106e97ab-bbce-44b8-95c4-a287752d8561"), new Guid("934902b5-c2a2-4fbc-97c2-8887ed45d08e"), 5.99m, 4.99m, 1000 },
                    { new Guid("106e97ab-bbce-44b8-95c4-a287752d8561"), new Guid("e2d9219f-c57b-4c59-bea0-6a3af2e655a5"), 29.99m, 19.99m, 1000 },
                    { new Guid("106e97ab-bbce-44b8-95c4-a287752d8561"), new Guid("f728c3bf-b4d8-41f6-93ab-7a91cba390be"), 0m, 6.99m, 1000 },
                    { new Guid("318f6a20-3c0b-40ca-9cf0-9533e83d3734"), new Guid("43a56b31-2f02-4e9d-88b0-2b3ced2276ba"), 29.9m, 19.99m, 1000 },
                    { new Guid("318f6a20-3c0b-40ca-9cf0-9533e83d3734"), new Guid("b28481c3-51fb-4a94-8558-0ac0ebfb1607"), 0m, 7.99m, 1000 },
                    { new Guid("318f6a20-3c0b-40ca-9cf0-9533e83d3734"), new Guid("ff58b31e-53d5-4216-84a4-0566cb2e9b52"), 19.99m, 9.99m, 1000 },
                    { new Guid("321ec52d-5fb6-4b1b-bb35-6f73cf92396d"), new Guid("dfd52a60-8ccf-4ac2-980c-14ddf41e9a18"), 0m, 2.99m, 1000 },
                    { new Guid("4f5c260c-0870-4940-a394-b20c56b3fcca"), new Guid("7c604dd7-d603-4f6a-b5bf-f254bd812787"), 0m, 19.99m, 1000 },
                    { new Guid("4f5c260c-0870-4940-a394-b20c56b3fcca"), new Guid("dfd52a60-8ccf-4ac2-980c-14ddf41e9a18"), 0m, 3.99m, 1000 },
                    { new Guid("4f5c260c-0870-4940-a394-b20c56b3fcca"), new Guid("fbaeaba4-a5bc-487e-b0e5-0967ff543d5d"), 0m, 9.99m, 1000 },
                    { new Guid("aed54a62-e6e7-4670-ab24-1c84b911deb0"), new Guid("e21526c4-f78b-4eb5-8ae0-919633179582"), 139.99m, 79.99m, 1000 },
                    { new Guid("c7537965-c2cb-4e77-bfc5-6c466c9a3bea"), new Guid("ff58b31e-53d5-4216-84a4-0566cb2e9b52"), 0m, 6.99m, 1000 },
                    { new Guid("ce50c69d-5897-4e3d-8d2d-081114ed1fb0"), new Guid("ff58b31e-53d5-4216-84a4-0566cb2e9b52"), 14.99m, 7.99m, 1000 },
                    { new Guid("f2b7ac53-e3e5-4f7c-8094-99530bbde9eb"), new Guid("dfd52a60-8ccf-4ac2-980c-14ddf41e9a18"), 0m, 3.99m, 1000 },
                    { new Guid("fc67ff65-d124-4350-94fa-8dd1cc0559e1"), new Guid("e21526c4-f78b-4eb5-8ae0-919633179582"), 299.99m, 159.99m, 1000 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_AccountId",
                table: "Addresses",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductTypeId",
                table: "OrderItems",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CouponId",
                table: "Orders",
                column: "CouponId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductValues_ProductAttributeId",
                table: "ProductValues",
                column: "ProductAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_ProductTypeId",
                table: "ProductVariants",
                column: "ProductTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "ProductValues");

            migrationBuilder.DropTable(
                name: "ProductVariants");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductAttributes");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
