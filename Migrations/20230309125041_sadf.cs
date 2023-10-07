using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace clothesbackend.Migrations
{
    /// <inheritdoc />
    public partial class sadf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "attries",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    size = table.Column<double>(type: "float", nullable: false),
                    number = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attries", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    size = table.Column<double>(type: "float", nullable: false),
                    number = table.Column<double>(type: "float", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    userId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.id);
                    table.ForeignKey(
                        name: "FK_orders_AspNetUsers_userId",
                        column: x => x.userId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    rate = table.Column<double>(type: "float", nullable: false),
                    count = table.Column<int>(type: "int", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    categoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.id);
                    table.ForeignKey(
                        name: "FK_products_categories_categoryID",
                        column: x => x.categoryID,
                        principalTable: "categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "carts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    product = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    size = table.Column<double>(type: "float", nullable: false),
                    number = table.Column<double>(type: "float", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    clientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carts", x => x.id);
                    table.ForeignKey(
                        name: "FK_carts_clients_clientId",
                        column: x => x.clientId,
                        principalTable: "clients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    productID = table.Column<int>(type: "int", nullable: false),
                    attriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => new { x.productID, x.attriID });
                    table.ForeignKey(
                        name: "FK_Stock_attries_attriID",
                        column: x => x.attriID,
                        principalTable: "attries",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stock_products_productID",
                        column: x => x.productID,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "33081dd1-b8e0-40c3-9fd0-fe38267de494", "9add15e9-c379-4e23-97de-2b56ddc9d525", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "firstName", "lastName" },
                values: new object[] { "ada17e8a-86a9-4b89-8baa-e6da0ca4c053", 0, "157a2d3c-6fe4-4b69-bc6d-05ae3fb1a11b", "admin@gmail.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEEgHUL2GAUw8BkSrF2QY/OnIBGdcBQ7zDpsiyZKUTZs7jsYItd4HIDUWkmJjWUbgQA==", null, false, "07d86591-ffa1-4676-9801-28b3d3db68a0", false, "admin", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "attries",
                columns: new[] { "id", "color", "number", "size" },
                values: new object[,]
                {
                    { 1, "red", 2.0, 38.0 },
                    { 2, "green", 3.0, 40.0 },
                    { 3, "red", 1.0, 39.0 },
                    { 4, "red", 2.0, 41.0 },
                    { 5, "yellow", 2.0, 0.0 },
                    { 6, "red", 5.0, 40.0 },
                    { 7, "pink", 6.0, 38.0 },
                    { 8, "blue", 4.0, 40.0 }
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "ao nam" },
                    { 2, "quan nam" },
                    { 3, "ao nu" },
                    { 4, "quan nu" },
                    { 5, "vay nu" },
                    { 7, "tui xach" },
                    { 8, "giay" }
                });

            migrationBuilder.InsertData(
                table: "clients",
                columns: new[] { "id", "address", "firstName", "lastName", "phoneNumber" },
                values: new object[,]
                {
                    { 1, "nha1", "truong", "minh nguyen", "123456666" },
                    { 2, "nha2", "henry", "Lord", "222333111" },
                    { 3, "nha3", "Anatamo", "Daisuki", "3331112222" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "33081dd1-b8e0-40c3-9fd0-fe38267de494", "ada17e8a-86a9-4b89-8baa-e6da0ca4c053" });

            migrationBuilder.InsertData(
                table: "carts",
                columns: new[] { "id", "clientId", "color", "number", "product", "size", "status" },
                values: new object[,]
                {
                    { 2, 1, "green", 1.0, "Mens Cotton Jacket ", 40.0, 0 },
                    { 3, 2, "red", 1.0, "Mens Cotton Jacket ", 38.0, 0 },
                    { 4, 1, "red", 1.0, "Mens Cotton Jacket ", 38.0, 0 }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "categoryID", "count", "image", "name", "price", "rate", "title" },
                values: new object[,]
                {
                    { 1, 3, 0, null, "Light Murrey Sleeveless Silk Top", 1196000.0, 0.0, "Women" },
                    { 2, 3, 0, null, "Purple Floral Silk Shirt", 1296000.0, 0.0, "Jewelery" },
                    { 3, 3, 0, null, "Bowtie Top", 1096000.0, 0.0, "Women" },
                    { 4, 3, 0, null, "Nude Illusion Neckline Raw Top", 1996000.0, 0.0, "Women" },
                    { 5, 3, 0, null, "Beige Stripe Woven Top ", 1096000.0, 0.0, "Women" },
                    { 6, 3, 0, null, "Light Green Stripe Woven Top", 1096000.0, 0.0, "Women" },
                    { 7, 3, 0, null, "Ochre Stripe Woven Waistcoat", 1396000.0, 0.0, "Women" },
                    { 8, 3, 0, null, "Black Cropped Woven Top", 1396000.0, 0.0, "Women" },
                    { 9, 3, 0, null, "Bateau Collar Silk Top", 1196000.0, 0.0, "Women" },
                    { 10, 3, 0, null, "Bowtie Top", 1296000.0, 0.0, "Women" },
                    { 11, 3, 0, null, "Silk Shirt", 1296000.0, 0.0, "Women" },
                    { 12, 3, 0, null, "White Butterfly Bowtie Top", 1196000.0, 0.0, "Women" },
                    { 13, 4, 0, null, "Dark Violet Split-front Wide Leg Raw Pants", 1296000.0, 0.0, "Women" },
                    { 14, 4, 0, null, "Dark Violet Flare Pants", 1296000.0, 0.0, "Women" },
                    { 15, 4, 0, null, "Mallard Green Wide Leg Silk Pants", 1296000.0, 0.0, "Women" },
                    { 16, 4, 0, null, "Moss Green Wide Leg Silk Pants", 1296000.0, 0.0, "Women" },
                    { 17, 4, 0, null, "Cream Wide Leg Silk Pants", 1296000.0, 0.0, "Women" },
                    { 18, 4, 0, null, "Brick Silk Pants", 1296000.0, 0.0, "Women" },
                    { 19, 4, 0, null, "Dresspants", 1096000.0, 0.0, "Women" },
                    { 20, 4, 0, null, "Nude Wide Leg Raw Pants", 1296000.0, 0.0, "Women" },
                    { 21, 4, 0, null, "Beige Stripe Wide Leg Woven Pants", 1296000.0, 0.0, "Women" },
                    { 22, 4, 0, null, "Light Green Stripe Woven Pants", 1296000.0, 0.0, "Women" },
                    { 23, 4, 0, null, "Green Stripe Wide Leg Woven Pants", 1496000.0, 0.0, "Women" },
                    { 24, 4, 0, null, "Ochre Stripe Wide Leg Woven Pants", 1296000.0, 0.0, "Women" },
                    { 25, 5, 0, null, "White Daisy Midi Brocade Dress", 3296000.0, 0.0, "Women" },
                    { 26, 5, 0, null, "White Queen Anne Neck Midi Woven Dress", 2496000.0, 0.0, "Women" },
                    { 27, 5, 0, null, "Yellow Strappy Midi Woven Dress", 2496000.0, 0.0, "Women" },
                    { 28, 5, 0, null, "Red Chrysanthemum Sleeveless Midi Dress", 2996000.0, 0.0, "Women" },
                    { 29, 5, 0, null, "Multi-coloured Chrysanthemum Mini Dress", 2996000.0, 0.0, "Women" },
                    { 30, 5, 0, null, "Yellow Chrysanthemum Mini Dress", 2996000.0, 0.0, "Women" },
                    { 31, 1, 0, null, "Áo Polo nam Pique Cotton USA thấm hút tối đa (kẻ sọc) - Vàng sọc đen", 229000.0, 0.0, "Men" },
                    { 32, 1, 0, null, "Áo Polo thể thao nam ProMax-S1 Logo thoáng khí - Xanh Navy", 239000.0, 0.0, "Men" },
                    { 33, 1, 0, null, "Áo Polo nam Café - khử mùi hiệu quả - Xanh aqua", 329000.0, 0.0, "Men" },
                    { 34, 1, 0, null, "Áo khoác nỉ nam For Winter (có mũ trùm tiện lợi) - Đen", 349000.0, 0.0, "Men" },
                    { 35, 1, 0, null, "Áo Polo nam co giãn công nghệ Graphene - Xanh bóng đêm", 329000.0, 0.0, "Men" },
                    { 36, 1, 0, null, "Áo thun nam Cotton Compact phiên bản Premium chống nhăn - Xanh Navy", 259000.0, 0.0, "Men" },
                    { 37, 2, 0, null, "Quần shorts chạy bộ Advanced Fast & Free Run", 399000.0, 0.0, "Men" },
                    { 38, 2, 0, null, "Quần Jeans Clean Denim dáng Regular S2 - Xanh garment", 599000.0, 0.0, "Men" },
                    { 39, 2, 0, null, "Quần short nam thể thao 7", 199000.0, 0.0, "Men" },
                    { 40, 2, 0, null, "Quần Jeans Clean Denim dáng Regular S3 - Xanh đậm", 599000.0, 0.0, "Men" },
                    { 41, 2, 0, null, "Quần Jogger nam túi hộp Cargo Outdoor - Xám", 329000.0, 0.0, "Men" },
                    { 42, 2, 0, null, "Quần short nam thể thao Recycle 7 thoáng khí - Xanh navy", 179000.0, 0.0, "Men" },
                    { 43, 7, 0, null, "Ví Nam Tommy Hilfiger Mens Ranger Passcase Brown 5673/02 Màu Nâu", 1090000.0, 0.0, "Jewelery" },
                    { 44, 7, 0, null, "úi Đeo Chéo Charles & Keith Croc-Effect Chain Strap Crossbody Bag CK2-80700998-4 Màu Đen", 1860000.0, 0.0, "Jewelery" },
                    { 45, 7, 0, null, "Túi Xách Charles & Keith Scarf-Wrapped Top Handle", 1880000.0, 0.0, "Jewelery" },
                    { 46, 7, 0, null, "Ví Nam Tommy Hilfiger Men's Thin Sleek Casual Bifold Wallet with 6 Credit Card Pockets And Removable Id Window", 1100000.0, 0.0, "Jewelery" },
                    { 47, 7, 0, null, "Túi Xách MLB Monogram Embossed Hobo Bag New York Yankees 3ABQS022N-50CRS Màu Trắng", 2800000.0, 0.0, "Jewelery" },
                    { 48, 7, 0, null, "Ví Nam Tommy Hilfiger Men's Thin Sleek Casual Bifold Wallet Black Dore", 1300000.0, 0.0, "Jewelery" },
                    { 49, 8, 0, null, "Giày Gucci Ace Embroidered Sneaker White Leather", 14800000.0, 0.0, "Jewelery" },
                    { 50, 8, 0, null, "Giày MLB Big Ball Chunky P Boston", 1920000.0, 0.0, "Jewelery" },
                    { 51, 8, 0, null, "Giày Thể Thao Nike Court Vision Low Next Nature", 1980000.0, 0.0, "Jewelery" },
                    { 52, 8, 0, null, "Giày MLB Big Ball Chunky P", 1890000.0, 0.0, "Jewelery" },
                    { 53, 8, 0, null, "Giày Thể Thao Louis Vuitton LV Trainer Màu Đen", 48900000.0, 0.0, "Jewelery" },
                    { 54, 8, 0, null, "Giày Thể Thao MLB Chunky Liner Boston Red", 3350000.0, 0.0, "Jewelery" }
                });

            migrationBuilder.InsertData(
                table: "Stock",
                columns: new[] { "attriID", "productID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 6, 1 },
                    { 7, 1 },
                    { 3, 2 },
                    { 4, 2 },
                    { 2, 3 },
                    { 5, 3 },
                    { 6, 4 },
                    { 8, 4 },
                    { 1, 5 },
                    { 3, 5 },
                    { 4, 6 },
                    { 5, 6 },
                    { 6, 7 },
                    { 7, 7 },
                    { 1, 8 },
                    { 8, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_carts_clientId",
                table: "carts",
                column: "clientId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_userId",
                table: "orders",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_products_categoryID",
                table: "products",
                column: "categoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_attriID",
                table: "Stock",
                column: "attriID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "carts");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "clients");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "attries");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
