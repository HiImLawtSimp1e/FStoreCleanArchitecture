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
                    DeliveryAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
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
                    { new Guid("0e5c838e-f387-4183-a1c1-4c1e802ab180"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1200), "", false, true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1201), "", new byte[] { 11, 137, 135, 187, 238, 32, 130, 23, 76, 29, 254, 230, 27, 77, 138, 74, 180, 231, 23, 2, 118, 217, 84, 126, 206, 155, 163, 255, 8, 217, 3, 117, 243, 17, 11, 13, 26, 196, 24, 83, 2, 30, 189, 145, 225, 186, 60, 84, 179, 254, 250, 112, 82, 179, 9, 0, 41, 89, 197, 126, 81, 182, 121, 235 }, new byte[] { 27, 96, 241, 29, 68, 206, 225, 147, 200, 67, 182, 119, 145, 101, 44, 92, 18, 186, 121, 73, 190, 234, 136, 41, 61, 215, 229, 159, 253, 31, 72, 4, 138, 140, 55, 158, 70, 109, 103, 63, 35, 14, 188, 114, 110, 121, 246, 32, 64, 58, 202, 157, 144, 33, 151, 136, 149, 164, 235, 188, 197, 45, 154, 68, 212, 138, 224, 161, 31, 182, 118, 115, 55, 172, 113, 57, 94, 134, 218, 250, 174, 225, 198, 149, 199, 114, 219, 104, 21, 159, 219, 10, 15, 245, 148, 173, 6, 214, 245, 184, 192, 58, 129, 73, 142, 132, 12, 38, 204, 230, 109, 53, 7, 176, 129, 190, 253, 136, 108, 217, 30, 247, 131, 77, 242, 70, 2, 91 }, 0, "tranlan@example.com" },
                    { new Guid("2b25a754-a50e-4468-942c-d65c0bc2c86f"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1189), "", false, true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1189), "", new byte[] { 11, 137, 135, 187, 238, 32, 130, 23, 76, 29, 254, 230, 27, 77, 138, 74, 180, 231, 23, 2, 118, 217, 84, 126, 206, 155, 163, 255, 8, 217, 3, 117, 243, 17, 11, 13, 26, 196, 24, 83, 2, 30, 189, 145, 225, 186, 60, 84, 179, 254, 250, 112, 82, 179, 9, 0, 41, 89, 197, 126, 81, 182, 121, 235 }, new byte[] { 27, 96, 241, 29, 68, 206, 225, 147, 200, 67, 182, 119, 145, 101, 44, 92, 18, 186, 121, 73, 190, 234, 136, 41, 61, 215, 229, 159, 253, 31, 72, 4, 138, 140, 55, 158, 70, 109, 103, 63, 35, 14, 188, 114, 110, 121, 246, 32, 64, 58, 202, 157, 144, 33, 151, 136, 149, 164, 235, 188, 197, 45, 154, 68, 212, 138, 224, 161, 31, 182, 118, 115, 55, 172, 113, 57, 94, 134, 218, 250, 174, 225, 198, 149, 199, 114, 219, 104, 21, 159, 219, 10, 15, 245, 148, 173, 6, 214, 245, 184, 192, 58, 129, 73, 142, 132, 12, 38, 204, 230, 109, 53, 7, 176, 129, 190, 253, 136, 108, 217, 30, 247, 131, 77, 242, 70, 2, 91 }, 0, "customer@example.com" },
                    { new Guid("3141069d-f4f3-475c-8efc-99e1b4c3e627"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1194), "", false, true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1194), "", new byte[] { 11, 137, 135, 187, 238, 32, 130, 23, 76, 29, 254, 230, 27, 77, 138, 74, 180, 231, 23, 2, 118, 217, 84, 126, 206, 155, 163, 255, 8, 217, 3, 117, 243, 17, 11, 13, 26, 196, 24, 83, 2, 30, 189, 145, 225, 186, 60, 84, 179, 254, 250, 112, 82, 179, 9, 0, 41, 89, 197, 126, 81, 182, 121, 235 }, new byte[] { 27, 96, 241, 29, 68, 206, 225, 147, 200, 67, 182, 119, 145, 101, 44, 92, 18, 186, 121, 73, 190, 234, 136, 41, 61, 215, 229, 159, 253, 31, 72, 4, 138, 140, 55, 158, 70, 109, 103, 63, 35, 14, 188, 114, 110, 121, 246, 32, 64, 58, 202, 157, 144, 33, 151, 136, 149, 164, 235, 188, 197, 45, 154, 68, 212, 138, 224, 161, 31, 182, 118, 115, 55, 172, 113, 57, 94, 134, 218, 250, 174, 225, 198, 149, 199, 114, 219, 104, 21, 159, 219, 10, 15, 245, 148, 173, 6, 214, 245, 184, 192, 58, 129, 73, 142, 132, 12, 38, 204, 230, 109, 53, 7, 176, 129, 190, 253, 136, 108, 217, 30, 247, 131, 77, 242, 70, 2, 91 }, 2, "employee@example.com" },
                    { new Guid("3a9477da-b75c-4ef6-9bf6-a93aa5ffaf6f"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1214), "", false, true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1215), "", new byte[] { 11, 137, 135, 187, 238, 32, 130, 23, 76, 29, 254, 230, 27, 77, 138, 74, 180, 231, 23, 2, 118, 217, 84, 126, 206, 155, 163, 255, 8, 217, 3, 117, 243, 17, 11, 13, 26, 196, 24, 83, 2, 30, 189, 145, 225, 186, 60, 84, 179, 254, 250, 112, 82, 179, 9, 0, 41, 89, 197, 126, 81, 182, 121, 235 }, new byte[] { 27, 96, 241, 29, 68, 206, 225, 147, 200, 67, 182, 119, 145, 101, 44, 92, 18, 186, 121, 73, 190, 234, 136, 41, 61, 215, 229, 159, 253, 31, 72, 4, 138, 140, 55, 158, 70, 109, 103, 63, 35, 14, 188, 114, 110, 121, 246, 32, 64, 58, 202, 157, 144, 33, 151, 136, 149, 164, 235, 188, 197, 45, 154, 68, 212, 138, 224, 161, 31, 182, 118, 115, 55, 172, 113, 57, 94, 134, 218, 250, 174, 225, 198, 149, 199, 114, 219, 104, 21, 159, 219, 10, 15, 245, 148, 173, 6, 214, 245, 184, 192, 58, 129, 73, 142, 132, 12, 38, 204, 230, 109, 53, 7, 176, 129, 190, 253, 136, 108, 217, 30, 247, 131, 77, 242, 70, 2, 91 }, 0, "hoangmai@example.com" },
                    { new Guid("3aec8f0b-3a6a-4b5d-8a3a-348ae529001a"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1158), "", false, true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1171), "", new byte[] { 11, 137, 135, 187, 238, 32, 130, 23, 76, 29, 254, 230, 27, 77, 138, 74, 180, 231, 23, 2, 118, 217, 84, 126, 206, 155, 163, 255, 8, 217, 3, 117, 243, 17, 11, 13, 26, 196, 24, 83, 2, 30, 189, 145, 225, 186, 60, 84, 179, 254, 250, 112, 82, 179, 9, 0, 41, 89, 197, 126, 81, 182, 121, 235 }, new byte[] { 27, 96, 241, 29, 68, 206, 225, 147, 200, 67, 182, 119, 145, 101, 44, 92, 18, 186, 121, 73, 190, 234, 136, 41, 61, 215, 229, 159, 253, 31, 72, 4, 138, 140, 55, 158, 70, 109, 103, 63, 35, 14, 188, 114, 110, 121, 246, 32, 64, 58, 202, 157, 144, 33, 151, 136, 149, 164, 235, 188, 197, 45, 154, 68, 212, 138, 224, 161, 31, 182, 118, 115, 55, 172, 113, 57, 94, 134, 218, 250, 174, 225, 198, 149, 199, 114, 219, 104, 21, 159, 219, 10, 15, 245, 148, 173, 6, 214, 245, 184, 192, 58, 129, 73, 142, 132, 12, 38, 204, 230, 109, 53, 7, 176, 129, 190, 253, 136, 108, 217, 30, 247, 131, 77, 242, 70, 2, 91 }, 1, "admin@example.com" },
                    { new Guid("463d52ee-4c4e-40b0-a8f3-e59086878964"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1206), "", false, true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1206), "", new byte[] { 11, 137, 135, 187, 238, 32, 130, 23, 76, 29, 254, 230, 27, 77, 138, 74, 180, 231, 23, 2, 118, 217, 84, 126, 206, 155, 163, 255, 8, 217, 3, 117, 243, 17, 11, 13, 26, 196, 24, 83, 2, 30, 189, 145, 225, 186, 60, 84, 179, 254, 250, 112, 82, 179, 9, 0, 41, 89, 197, 126, 81, 182, 121, 235 }, new byte[] { 27, 96, 241, 29, 68, 206, 225, 147, 200, 67, 182, 119, 145, 101, 44, 92, 18, 186, 121, 73, 190, 234, 136, 41, 61, 215, 229, 159, 253, 31, 72, 4, 138, 140, 55, 158, 70, 109, 103, 63, 35, 14, 188, 114, 110, 121, 246, 32, 64, 58, 202, 157, 144, 33, 151, 136, 149, 164, 235, 188, 197, 45, 154, 68, 212, 138, 224, 161, 31, 182, 118, 115, 55, 172, 113, 57, 94, 134, 218, 250, 174, 225, 198, 149, 199, 114, 219, 104, 21, 159, 219, 10, 15, 245, 148, 173, 6, 214, 245, 184, 192, 58, 129, 73, 142, 132, 12, 38, 204, 230, 109, 53, 7, 176, 129, 190, 253, 136, 108, 217, 30, 247, 131, 77, 242, 70, 2, 91 }, 0, "phantuyet@example.com" },
                    { new Guid("4b45812f-2f47-41b9-b913-39bed1b02c1d"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1212), "", false, true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1213), "", new byte[] { 11, 137, 135, 187, 238, 32, 130, 23, 76, 29, 254, 230, 27, 77, 138, 74, 180, 231, 23, 2, 118, 217, 84, 126, 206, 155, 163, 255, 8, 217, 3, 117, 243, 17, 11, 13, 26, 196, 24, 83, 2, 30, 189, 145, 225, 186, 60, 84, 179, 254, 250, 112, 82, 179, 9, 0, 41, 89, 197, 126, 81, 182, 121, 235 }, new byte[] { 27, 96, 241, 29, 68, 206, 225, 147, 200, 67, 182, 119, 145, 101, 44, 92, 18, 186, 121, 73, 190, 234, 136, 41, 61, 215, 229, 159, 253, 31, 72, 4, 138, 140, 55, 158, 70, 109, 103, 63, 35, 14, 188, 114, 110, 121, 246, 32, 64, 58, 202, 157, 144, 33, 151, 136, 149, 164, 235, 188, 197, 45, 154, 68, 212, 138, 224, 161, 31, 182, 118, 115, 55, 172, 113, 57, 94, 134, 218, 250, 174, 225, 198, 149, 199, 114, 219, 104, 21, 159, 219, 10, 15, 245, 148, 173, 6, 214, 245, 184, 192, 58, 129, 73, 142, 132, 12, 38, 204, 230, 109, 53, 7, 176, 129, 190, 253, 136, 108, 217, 30, 247, 131, 77, 242, 70, 2, 91 }, 0, "tranle@example.com" },
                    { new Guid("6060ab5a-ca8b-409c-87b2-363a69f06e66"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1198), "", false, true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1199), "", new byte[] { 11, 137, 135, 187, 238, 32, 130, 23, 76, 29, 254, 230, 27, 77, 138, 74, 180, 231, 23, 2, 118, 217, 84, 126, 206, 155, 163, 255, 8, 217, 3, 117, 243, 17, 11, 13, 26, 196, 24, 83, 2, 30, 189, 145, 225, 186, 60, 84, 179, 254, 250, 112, 82, 179, 9, 0, 41, 89, 197, 126, 81, 182, 121, 235 }, new byte[] { 27, 96, 241, 29, 68, 206, 225, 147, 200, 67, 182, 119, 145, 101, 44, 92, 18, 186, 121, 73, 190, 234, 136, 41, 61, 215, 229, 159, 253, 31, 72, 4, 138, 140, 55, 158, 70, 109, 103, 63, 35, 14, 188, 114, 110, 121, 246, 32, 64, 58, 202, 157, 144, 33, 151, 136, 149, 164, 235, 188, 197, 45, 154, 68, 212, 138, 224, 161, 31, 182, 118, 115, 55, 172, 113, 57, 94, 134, 218, 250, 174, 225, 198, 149, 199, 114, 219, 104, 21, 159, 219, 10, 15, 245, 148, 173, 6, 214, 245, 184, 192, 58, 129, 73, 142, 132, 12, 38, 204, 230, 109, 53, 7, 176, 129, 190, 253, 136, 108, 217, 30, 247, 131, 77, 242, 70, 2, 91 }, 0, "lethimai@example.com" },
                    { new Guid("80cd99a5-f3e4-43f6-a725-f4e07fa7cd7d"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1208), "", false, true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1208), "", new byte[] { 11, 137, 135, 187, 238, 32, 130, 23, 76, 29, 254, 230, 27, 77, 138, 74, 180, 231, 23, 2, 118, 217, 84, 126, 206, 155, 163, 255, 8, 217, 3, 117, 243, 17, 11, 13, 26, 196, 24, 83, 2, 30, 189, 145, 225, 186, 60, 84, 179, 254, 250, 112, 82, 179, 9, 0, 41, 89, 197, 126, 81, 182, 121, 235 }, new byte[] { 27, 96, 241, 29, 68, 206, 225, 147, 200, 67, 182, 119, 145, 101, 44, 92, 18, 186, 121, 73, 190, 234, 136, 41, 61, 215, 229, 159, 253, 31, 72, 4, 138, 140, 55, 158, 70, 109, 103, 63, 35, 14, 188, 114, 110, 121, 246, 32, 64, 58, 202, 157, 144, 33, 151, 136, 149, 164, 235, 188, 197, 45, 154, 68, 212, 138, 224, 161, 31, 182, 118, 115, 55, 172, 113, 57, 94, 134, 218, 250, 174, 225, 198, 149, 199, 114, 219, 104, 21, 159, 219, 10, 15, 245, 148, 173, 6, 214, 245, 184, 192, 58, 129, 73, 142, 132, 12, 38, 204, 230, 109, 53, 7, 176, 129, 190, 253, 136, 108, 217, 30, 247, 131, 77, 242, 70, 2, 91 }, 0, "vuvankhai@example.com" },
                    { new Guid("a3339dd7-94b9-4f12-9d18-2ee341b4f35c"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1196), "", false, true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1196), "", new byte[] { 11, 137, 135, 187, 238, 32, 130, 23, 76, 29, 254, 230, 27, 77, 138, 74, 180, 231, 23, 2, 118, 217, 84, 126, 206, 155, 163, 255, 8, 217, 3, 117, 243, 17, 11, 13, 26, 196, 24, 83, 2, 30, 189, 145, 225, 186, 60, 84, 179, 254, 250, 112, 82, 179, 9, 0, 41, 89, 197, 126, 81, 182, 121, 235 }, new byte[] { 27, 96, 241, 29, 68, 206, 225, 147, 200, 67, 182, 119, 145, 101, 44, 92, 18, 186, 121, 73, 190, 234, 136, 41, 61, 215, 229, 159, 253, 31, 72, 4, 138, 140, 55, 158, 70, 109, 103, 63, 35, 14, 188, 114, 110, 121, 246, 32, 64, 58, 202, 157, 144, 33, 151, 136, 149, 164, 235, 188, 197, 45, 154, 68, 212, 138, 224, 161, 31, 182, 118, 115, 55, 172, 113, 57, 94, 134, 218, 250, 174, 225, 198, 149, 199, 114, 219, 104, 21, 159, 219, 10, 15, 245, 148, 173, 6, 214, 245, 184, 192, 58, 129, 73, 142, 132, 12, 38, 204, 230, 109, 53, 7, 176, 129, 190, 253, 136, 108, 217, 30, 247, 131, 77, 242, 70, 2, 91 }, 0, "nguyenvanminh@example.com" },
                    { new Guid("ae4c4f03-aa8a-4f37-a7cb-c5bc06e08d74"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1203), "", false, true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1204), "", new byte[] { 11, 137, 135, 187, 238, 32, 130, 23, 76, 29, 254, 230, 27, 77, 138, 74, 180, 231, 23, 2, 118, 217, 84, 126, 206, 155, 163, 255, 8, 217, 3, 117, 243, 17, 11, 13, 26, 196, 24, 83, 2, 30, 189, 145, 225, 186, 60, 84, 179, 254, 250, 112, 82, 179, 9, 0, 41, 89, 197, 126, 81, 182, 121, 235 }, new byte[] { 27, 96, 241, 29, 68, 206, 225, 147, 200, 67, 182, 119, 145, 101, 44, 92, 18, 186, 121, 73, 190, 234, 136, 41, 61, 215, 229, 159, 253, 31, 72, 4, 138, 140, 55, 158, 70, 109, 103, 63, 35, 14, 188, 114, 110, 121, 246, 32, 64, 58, 202, 157, 144, 33, 151, 136, 149, 164, 235, 188, 197, 45, 154, 68, 212, 138, 224, 161, 31, 182, 118, 115, 55, 172, 113, 57, 94, 134, 218, 250, 174, 225, 198, 149, 199, 114, 219, 104, 21, 159, 219, 10, 15, 245, 148, 173, 6, 214, 245, 184, 192, 58, 129, 73, 142, 132, 12, 38, 204, 230, 109, 53, 7, 176, 129, 190, 253, 136, 108, 217, 30, 247, 131, 77, 242, 70, 2, 91 }, 0, "nguyenan@example.com" },
                    { new Guid("c36aab76-f6cc-46f6-a6c3-730d54b61a48"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1210), "", false, true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1210), "", new byte[] { 11, 137, 135, 187, 238, 32, 130, 23, 76, 29, 254, 230, 27, 77, 138, 74, 180, 231, 23, 2, 118, 217, 84, 126, 206, 155, 163, 255, 8, 217, 3, 117, 243, 17, 11, 13, 26, 196, 24, 83, 2, 30, 189, 145, 225, 186, 60, 84, 179, 254, 250, 112, 82, 179, 9, 0, 41, 89, 197, 126, 81, 182, 121, 235 }, new byte[] { 27, 96, 241, 29, 68, 206, 225, 147, 200, 67, 182, 119, 145, 101, 44, 92, 18, 186, 121, 73, 190, 234, 136, 41, 61, 215, 229, 159, 253, 31, 72, 4, 138, 140, 55, 158, 70, 109, 103, 63, 35, 14, 188, 114, 110, 121, 246, 32, 64, 58, 202, 157, 144, 33, 151, 136, 149, 164, 235, 188, 197, 45, 154, 68, 212, 138, 224, 161, 31, 182, 118, 115, 55, 172, 113, 57, 94, 134, 218, 250, 174, 225, 198, 149, 199, 114, 219, 104, 21, 159, 219, 10, 15, 245, 148, 173, 6, 214, 245, 184, 192, 58, 129, 73, 142, 132, 12, 38, 204, 230, 109, 53, 7, 176, 129, 190, 253, 136, 108, 217, 30, 247, 131, 77, 242, 70, 2, 91 }, 0, "lehoanganh@example.com" },
                    { new Guid("d15fcb08-fcb1-4a55-b012-b2be211ed2c1"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1216), "", false, true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1217), "", new byte[] { 11, 137, 135, 187, 238, 32, 130, 23, 76, 29, 254, 230, 27, 77, 138, 74, 180, 231, 23, 2, 118, 217, 84, 126, 206, 155, 163, 255, 8, 217, 3, 117, 243, 17, 11, 13, 26, 196, 24, 83, 2, 30, 189, 145, 225, 186, 60, 84, 179, 254, 250, 112, 82, 179, 9, 0, 41, 89, 197, 126, 81, 182, 121, 235 }, new byte[] { 27, 96, 241, 29, 68, 206, 225, 147, 200, 67, 182, 119, 145, 101, 44, 92, 18, 186, 121, 73, 190, 234, 136, 41, 61, 215, 229, 159, 253, 31, 72, 4, 138, 140, 55, 158, 70, 109, 103, 63, 35, 14, 188, 114, 110, 121, 246, 32, 64, 58, 202, 157, 144, 33, 151, 136, 149, 164, 235, 188, 197, 45, 154, 68, 212, 138, 224, 161, 31, 182, 118, 115, 55, 172, 113, 57, 94, 134, 218, 250, 174, 225, 198, 149, 199, 114, 219, 104, 21, 159, 219, 10, 15, 245, 148, 173, 6, 214, 245, 184, 192, 58, 129, 73, 142, 132, 12, 38, 204, 230, 109, 53, 7, 176, 129, 190, 253, 136, 108, 217, 30, 247, 131, 77, 242, 70, 2, 91 }, 0, "lehoa@example.com" },
                    { new Guid("db757696-89d6-4f61-84bb-61bc9b87ea05"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1192), "", false, true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1192), "", new byte[] { 11, 137, 135, 187, 238, 32, 130, 23, 76, 29, 254, 230, 27, 77, 138, 74, 180, 231, 23, 2, 118, 217, 84, 126, 206, 155, 163, 255, 8, 217, 3, 117, 243, 17, 11, 13, 26, 196, 24, 83, 2, 30, 189, 145, 225, 186, 60, 84, 179, 254, 250, 112, 82, 179, 9, 0, 41, 89, 197, 126, 81, 182, 121, 235 }, new byte[] { 27, 96, 241, 29, 68, 206, 225, 147, 200, 67, 182, 119, 145, 101, 44, 92, 18, 186, 121, 73, 190, 234, 136, 41, 61, 215, 229, 159, 253, 31, 72, 4, 138, 140, 55, 158, 70, 109, 103, 63, 35, 14, 188, 114, 110, 121, 246, 32, 64, 58, 202, 157, 144, 33, 151, 136, 149, 164, 235, 188, 197, 45, 154, 68, 212, 138, 224, 161, 31, 182, 118, 115, 55, 172, 113, 57, 94, 134, 218, 250, 174, 225, 198, 149, 199, 114, 219, 104, 21, 159, 219, 10, 15, 245, 148, 173, 6, 214, 245, 184, 192, 58, 129, 73, 142, 132, 12, 38, 204, 230, 109, 53, 7, 176, 129, 190, 253, 136, 108, 217, 30, 247, 131, 77, 242, 70, 2, 91 }, 0, "customer2@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Deleted", "IsActive", "ModifiedAt", "ModifiedBy", "Slug", "Title" },
                values: new object[,]
                {
                    { new Guid("2c8eb836-090b-4a18-a869-620d7f527180"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1882), "", false, true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1883), "", "movies", "Movies" },
                    { new Guid("a186203e-0d11-4c22-a45e-58ecfeed368f"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1880), "", false, true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1880), "", "books", "Books" },
                    { new Guid("c236f9f6-2c4c-4ba3-99ed-9cf81ee9bf46"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1884), "", false, true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1885), "", "video-games", "Video Games" }
                });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "Id", "Code", "CreatedAt", "CreatedBy", "DiscountValue", "EndDate", "IsActive", "IsDiscountPercent", "MaxDiscountValue", "MinOrderCondition", "ModifiedAt", "ModifiedBy", "Quantity", "StartDate", "VoucherName" },
                values: new object[,]
                {
                    { new Guid("1cb780e4-366c-4dc2-ba2e-1dd264a9d023"), "SUMMER20000", new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(2231), "", 19.00m, new DateTime(2025, 4, 10, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(2237), true, false, 0m, 199m, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(2232), "", 1000, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(2236), "Summer 20000VND Discount" },
                    { new Guid("e0111a25-6b27-4f71-b5c1-3ad5b9999a8c"), "SUMMER24", new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(2223), "", 24.00m, new DateTime(2025, 4, 10, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(2229), true, true, 80000m, 200000m, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(2223), "", 1000, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(2229), "Summer 24% Discount" }
                });

            migrationBuilder.InsertData(
                table: "ProductAttributes",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("09ec0726-d537-4c92-aaaf-760f19c6999f"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1825), "", new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1826), "", "Publisher" },
                    { new Guid("4150124b-2a58-4d98-8abe-f380e99a6fa9"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1839), "", new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1839), "", "Developer" },
                    { new Guid("50b7176f-4b13-484b-aec4-edf9383b9232"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1829), "", new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1830), "", "Pages" },
                    { new Guid("99bf3d94-a248-46f8-bbcb-0f9ae07ce1af"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1833), "", new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1833), "", "Writers" },
                    { new Guid("a5913406-23e7-4451-a19c-242c974e312e"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1835), "", new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1835), "", "Stars" },
                    { new Guid("b96ab5d0-3155-4688-8fb4-c6427e0661d5"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1831), "", new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1831), "", "Directors" },
                    { new Guid("bd2d16dc-10a9-40b1-b76a-e39f3c015086"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1823), "", new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1823), "", "Author" },
                    { new Guid("c84ec2fc-651b-42e1-b073-022596ac90c0"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1837), "", new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1837), "", "Gerne" },
                    { new Guid("d369dc76-92cf-417a-aea5-17616c87d4ce"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1827), "", new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1828), "", "ISBN" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("43a56b31-2f02-4e9d-88b0-2b3ced2276ba"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1765), "", new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1765), "", "Audiobook" },
                    { new Guid("7c604dd7-d603-4f6a-b5bf-f254bd812787"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1771), "", new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1771), "", "VHS" },
                    { new Guid("934902b5-c2a2-4fbc-97c2-8887ed45d08e"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1776), "", new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1777), "", "Xbox" },
                    { new Guid("b28481c3-51fb-4a94-8558-0ac0ebfb1607"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1763), "", new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1763), "", "E-Book" },
                    { new Guid("dfd52a60-8ccf-4ac2-980c-14ddf41e9a18"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1767), "", new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1767), "", "Stream" },
                    { new Guid("e21526c4-f78b-4eb5-8ae0-919633179582"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1756), "", new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1756), "", "Default" },
                    { new Guid("e2d9219f-c57b-4c59-bea0-6a3af2e655a5"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1773), "", new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1773), "", "PC" },
                    { new Guid("f728c3bf-b4d8-41f6-93ab-7a91cba390be"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1775), "", new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1775), "", "PlayStation" },
                    { new Guid("fbaeaba4-a5bc-487e-b0e5-0967ff543d5d"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1769), "", new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1769), "", "Blu-ray" },
                    { new Guid("ff58b31e-53d5-4216-84a4-0566cb2e9b52"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1760), "", new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1760), "", "Paperback" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AccountId", "CreatedAt", "CreatedBy", "DeliveryAddress", "Email", "IsMain", "ModifiedAt", "ModifiedBy", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("06364e7c-b515-4250-b938-aaaa3725d3ef"), new Guid("db757696-89d6-4f61-84bb-61bc9b87ea05"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1534), "", "20 Nguyễn Trãi, Thanh Xuân, Hà Nội", "lethib@example.com", false, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1535), "", "Lê Thị Bích", "0923456789" },
                    { new Guid("3fc9ca55-0fad-4255-b3b2-6aee979ac786"), new Guid("d15fcb08-fcb1-4a55-b012-b2be211ed2c1"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1586), "", "789 Đường Lý Thường Kiệt, Phường Bắc Lý, TP. Quảng Bình", "lehoa@example.com", true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1586), "", "Lê Thị Hòa", "0934567890" },
                    { new Guid("427ca40d-0d1c-489e-a8e4-839c05187d2e"), new Guid("80cd99a5-f3e4-43f6-a725-f4e07fa7cd7d"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1570), "", "123 Đường Trường Chinh, Phường 14, Quận Tân Bình, TP. Hồ Chí Minh", "vuvankhai@example.com", true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1570), "", "Vũ Văn Khải", "0912345678" },
                    { new Guid("4f7bbe86-ea63-4d2d-8750-077b6d827492"), new Guid("a3339dd7-94b9-4f12-9d18-2ee341b4f35c"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1553), "", "456 Đường Nguyễn Trãi, Phường Bến Thành, Quận 1, TP. Hồ Chí Minh", "minhnguyen@example.com", true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1553), "", "Nguyễn Văn Minh", "0987654321" },
                    { new Guid("530b7ec7-bdea-4c94-b276-ccf9c802a86a"), new Guid("2b25a754-a50e-4468-942c-d65c0bc2c86f"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1525), "", "25 Phình Hồ, Văn Chấn, Yên Bái", "dangnhung72@gmail.com", false, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1525), "", "Đăng Thị Hồng Nhung", "0366702305" },
                    { new Guid("5e093047-7818-4679-a6c9-65fc6561bdfe"), new Guid("ae4c4f03-aa8a-4f37-a7cb-c5bc06e08d74"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1564), "", "456 Đường Nguyễn Thái Học, Phường 10, TP. Cần Thơ", "nguyenan@example.com", true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1564), "", "Nguyễn Thị An", "0976543210" },
                    { new Guid("62ce08ec-7e5c-4361-985e-7bba8d52b450"), new Guid("2b25a754-a50e-4468-942c-d65c0bc2c86f"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1528), "", "22 Ngã Ba Kim, Mù Cang Chải, Yên Bái", "q170302@email.com", true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1528), "", "Nguyễn Quang Hưng", "0344917302" },
                    { new Guid("6b40d359-e7ca-469b-bc7a-cce7d2618a35"), new Guid("3aec8f0b-3a6a-4b5d-8a3a-348ae529001a"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1486), "", "125 Đường Cầu Giấy ,Cầu Giấy, Hà Nội", "johnadmin@example.com", true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1486), "", "John Admin", "1234567891" },
                    { new Guid("6e5c7c13-caf4-46ff-9f82-2071b79b287e"), new Guid("db757696-89d6-4f61-84bb-61bc9b87ea05"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1531), "", "15 Lê Văn Lương, Thanh Xuân, Hà Nội", "nguyenvana@example.com", true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1532), "", "Nguyễn Văn An", "0912345678" },
                    { new Guid("6ec2f29b-ab86-4256-a08d-794aaae5be47"), new Guid("463d52ee-4c4e-40b0-a8f3-e59086878964"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1567), "", "789 Đường Võ Văn Tần, Phường 5, Quận 3, TP. Hồ Chí Minh", "phantuyet@example.com", true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1567), "", "Phan Thị Tuyết", "0901234567" },
                    { new Guid("75196899-735c-4927-ab78-ebba7c3db8ad"), new Guid("3141069d-f4f3-475c-8efc-99e1b4c3e627"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1541), "", "121 Đường Cầu Giấy ,Cầu Giấy, Hà Nội", "johnemployee@example.com", true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1541), "", "John Employee", "1234567892" },
                    { new Guid("91bc5e8a-a67f-4457-8d11-49165e3ac66d"), new Guid("c36aab76-f6cc-46f6-a6c3-730d54b61a48"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1573), "", "234 Đường Hà Huy Tập, Phường Đông Vệ, TP. Thanh Hóa", "lehoanganh@example.com", true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1574), "", "Lê Hoàng Anh", "0923456789" },
                    { new Guid("94c8828b-f127-4333-9583-4f5fa8bfd44a"), new Guid("0e5c838e-f387-4183-a1c1-4c1e802ab180"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1560), "", "123 Đường Lê Lai, Phường Phú Hòa, TP. Thủ Dầu Một, Bình Dương", "tranlan@example.com", true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1560), "", "Trần Thị Lan", "0908765432" },
                    { new Guid("a80ee5b0-0313-402c-a6cf-6279a5961bec"), new Guid("db757696-89d6-4f61-84bb-61bc9b87ea05"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1538), "", "88 Đường Giải Phóng, Hoàng Mai, Hà Nội", "phamvanc@example.com", false, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1538), "", "Phạm Văn Công", "0934567890" },
                    { new Guid("b18504c6-3241-4a6a-97cf-6346cf6c9edb"), new Guid("6060ab5a-ca8b-409c-87b2-363a69f06e66"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1556), "", "789 Đường Lê Văn Sỹ, Phường 13, Quận 3, TP. Hồ Chí Minh", "lethimai@example.com", true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1557), "", "Lê Thị Mai", "0912345679" },
                    { new Guid("bc86cbb0-80c8-4686-8155-52e955f0e91c"), new Guid("3a9477da-b75c-4ef6-9bf6-a93aa5ffaf6f"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1583), "", "456 Đường Phan Chu Trinh, Phường 5, TP. Đà Nẵng", "hoangmai@example.com", true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1583), "", "Hoàng Thị Mai", "0976543210" },
                    { new Guid("de51300c-2954-40b7-ba23-e68681301c85"), new Guid("4b45812f-2f47-41b9-b913-39bed1b02c1d"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1576), "", "123 Đường Nguyễn Văn Linh, Phường Tân Hưng, Quận 7, TP. Hồ Chí Minh", "tranle@example.com", true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1577), "", "Trần Thị Lệ", "0987654321" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "CreatedBy", "Deleted", "Description", "ImageUrl", "IsActive", "ModifiedAt", "ModifiedBy", "Slug", "Title" },
                values: new object[,]
                {
                    { new Guid("00cab8fd-ad0e-433b-8bb0-2c9596809b7b"), new Guid("c236f9f6-2c4c-4ba3-99ed-9cf81ee9bf46"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1946), "", false, "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.", "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1946), "", "day-of-the-tentacle", "Day of the Tentacle" },
                    { new Guid("07acf5bd-e13d-4667-ba8e-70be6785f655"), new Guid("c236f9f6-2c4c-4ba3-99ed-9cf81ee9bf46"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1941), "", false, "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.", "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1941), "", "diablo-ii", "Diablo II" },
                    { new Guid("106e97ab-bbce-44b8-95c4-a287752d8561"), new Guid("c236f9f6-2c4c-4ba3-99ed-9cf81ee9bf46"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1937), "", false, "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.", "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1937), "", "half-life-2", "Half-Life 2" },
                    { new Guid("318f6a20-3c0b-40ca-9cf0-9533e83d3734"), new Guid("a186203e-0d11-4c22-a45e-58ecfeed368f"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1911), "", false, "The Hitchhiker's Guide to the Galaxy is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text adventure game, and 2005 feature film.", "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1911), "", "the-hitchhikers-guide-to-the-galaxy", "The Hitchhiker's Guide to the Galaxy" },
                    { new Guid("321ec52d-5fb6-4b1b-bb35-6f73cf92396d"), new Guid("2c8eb836-090b-4a18-a869-620d7f527180"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1932), "", false, "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.", "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg", true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1933), "", "toy-story", "Toy Story" },
                    { new Guid("4f5c260c-0870-4940-a394-b20c56b3fcca"), new Guid("2c8eb836-090b-4a18-a869-620d7f527180"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1923), "", false, "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.", "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg", true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1923), "", "the-matrix", "The Matrix" },
                    { new Guid("aed54a62-e6e7-4670-ab24-1c84b911deb0"), new Guid("c236f9f6-2c4c-4ba3-99ed-9cf81ee9bf46"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1954), "", false, "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.", "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1955), "", "super-nintendo-entertainment-system", "Super Nintendo Entertainment System" },
                    { new Guid("c7537965-c2cb-4e77-bfc5-6c466c9a3bea"), new Guid("a186203e-0d11-4c22-a45e-58ecfeed368f"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1918), "", false, "Nineteen Eighty-Four (also published as 1984) is a dystopian novel and cautionary tale by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society. Orwell, a democratic socialist, modelled the authoritarian state in the novel on the Soviet Union in the era of Stalinism, and Nazi Germany. More broadly, the novel examines the role of truth and facts within societies and the ways in which they can be manipulated.", "https://upload.wikimedia.org/wikipedia/en/5/51/1984_first_edition_cover.jpg", true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1919), "", "nineteen-eighty-four", "Nineteen Eighty-Four" },
                    { new Guid("ce50c69d-5897-4e3d-8d2d-081114ed1fb0"), new Guid("a186203e-0d11-4c22-a45e-58ecfeed368f"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1914), "", false, "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House). The book was published on August 16, 2011. An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters. In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association and won the 2011 Prometheus Award. A film adaptation, screenwritten by Cline and Zak Penn and directed by Steven Spielberg, was released on March 29, 2018. A sequel novel, Ready Player Two, was released on November 24, 2020, to a widely negative critical reception.", "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg", true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1915), "", "ready-player-one", "Ready Player One" },
                    { new Guid("f2b7ac53-e3e5-4f7c-8094-99530bbde9eb"), new Guid("2c8eb836-090b-4a18-a869-620d7f527180"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1928), "", false, "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.", "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg", true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1929), "", "back-to-the-future", "Back to the Future" },
                    { new Guid("fc67ff65-d124-4350-94fa-8dd1cc0559e1"), new Guid("c236f9f6-2c4c-4ba3-99ed-9cf81ee9bf46"), new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1950), "", false, "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.", "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg", true, new DateTime(2025, 3, 11, 16, 24, 25, 2, DateTimeKind.Local).AddTicks(1951), "", "xbox", "Xbox" }
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
