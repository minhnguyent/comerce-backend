using clothes_backend.Entities.Cart;
using clothes_backend.Entities.Client;
using clothes_backend.Entities.Dal;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Emit;

namespace clothes_backend.Service
{
    public class Context : IdentityDbContext<User>
    {
        public DbSet<Order> orders { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Attri> attries { get; set; }
        public DbSet<Stock> stocks { get; set; }
        public DbSet<_Cart> carts { get; set; }
        public DbSet<_Client> clients { get; set; }

        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        public Context(DbContextOptions options) : base(options)
        {
        }
       
        protected override async void OnModelCreating(ModelBuilder b)
        {

            base.OnModelCreating(b);
            b.ApplyConfiguration(new StockConfig());
            b.Initial();
      
           
            

        }

    }
    public static class Dulieumau
    {
        public static void Initial (this ModelBuilder b)
        {
            //tao admin 
            var adminUser = new User
            {
                firstName =  "admin",
                lastName = "admin",
                Email = "admin@gmail.com",
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName ="admin"
            };

            // Hash the admin user's password
            var passwordHasher = new PasswordHasher<User>();
            var hashedPassword = passwordHasher.HashPassword(adminUser, "Qtm@123");

            adminUser.PasswordHash = hashedPassword;

            b.Entity<User>().HasData(adminUser);

            // Assign the admin role to the admin user
            var adminRole = new IdentityRole { Name = "admin", NormalizedName = "ADMIN" };
            b.Entity<IdentityRole>().HasData(adminRole);

            b.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = adminRole.Id,
                UserId = adminUser.Id
            });

            b.Entity<Category>().HasData(
                new Category { id = 1, name = "ao nam" },
                new Category { id = 2, name = "quan nam" },
                new Category { id =3, name = "ao nu" },
                new Category { id =4, name = "quan nu"},
                new Category { id =5, name = "vay nu" },
                new Category { id =7, name = "tui xach" },
                new Category { id =8, name = "giay" }
            );
            

            b.Entity<Product>().HasData(
                new Product
                {
                    id = 1,
                    name = "Light Murrey Sleeveless Silk Top",
                    price = 1196000,
                    title = "Women",
                    categoryID=3
                },
                new Product
                {
                    id = 2,
                    name = "Purple Floral Silk Shirt",
                    price = 1296000,
                    title = "Jewelery",
                    categoryID = 3

                },
                new Product
                {
                    id = 3,
                    name = "Bowtie Top",
                    price = 1096000,
                    title = "Women",
                    categoryID = 3

                },
                new Product { 
                    id=4, 
                    name= "Nude Illusion Neckline Raw Top",
                    price=1996000,
                    title="Women",
                    categoryID=3,
                },
new Product
                {
                    id = 5,
                    name = "Beige Stripe Woven Top ",
                    price = 1096000,
                    title = "Women",
                    categoryID=3
                },
                new Product
                {
                    id = 6,
                    name = "Light Green Stripe Woven Top",
                    price = 1096000,
                    title = "Women",
                    categoryID = 3

                },
                new Product
                {
                    id = 7,
                    name = "Ochre Stripe Woven Waistcoat",
                    price = 1396000,
                    title = "Women",
                    categoryID = 3

                },
                new Product
                {
                    id = 8,
                    name = "Black Cropped Woven Top",
                    price = 1396000,
                    title = "Women",
                    categoryID = 3

                },
                new Product
                {
                    id = 9,
                    name = "Bateau Collar Silk Top",
                    price = 1196000,
                    title = "Women",
                    categoryID = 3

                },
                new Product
                {
                    id = 10,
                    name = "Bowtie Top",
                    price = 1296000,
                    title = "Women",
                    categoryID = 3

                },
                new Product
                {
                    id = 11,
                    name = "Silk Shirt",
                    price = 1296000,
                    title = "Women",
                    categoryID = 3

                },
                new Product
                {
                    id = 12,
                    name = "White Butterfly Bowtie Top",
                    price = 1196000,
                    title = "Women",
                    categoryID = 3

                },
                new Product
                {
                    id = 13,
                    name = "Dark Violet Split-front Wide Leg Raw Pants",
                    price = 1296000,
                    title = "Women",
                    categoryID = 4

                },
                new Product
                {
                    id = 14,
                    name = "Dark Violet Flare Pants",
                    price = 1296000,
                    title = "Women",
                    categoryID = 4

                },
                new Product
                {
                    id = 15,
                    name = "Mallard Green Wide Leg Silk Pants",
                    price = 1296000,
                    title = "Women",
                    categoryID = 4

                },
                new Product
                {
                    id = 16,
                    name = "Moss Green Wide Leg Silk Pants",
price = 1296000,
                    title = "Women",
                    categoryID = 4

                },
                new Product
                {
                    id = 17,
                    name = "Cream Wide Leg Silk Pants",
                    price = 1296000,
                    title = "Women",
                    categoryID = 4

                },
                new Product
                {
                    id = 18,
                    name = "Brick Silk Pants",
                    price = 1296000,
                    title = "Women",
                    categoryID = 4

                },
                new Product
                {
                    id = 19,
                    name = "Dresspants",
                    price = 1096000,
                    title = "Women",
                    categoryID = 4

                },
                new Product
                {
                    id = 20,
                    name = "Nude Wide Leg Raw Pants",
                    price = 1296000,
                    title = "Women",
                    categoryID = 4

                },
                new Product
                {
                    id = 21,
                    name = "Beige Stripe Wide Leg Woven Pants",
                    price = 1296000,
                    title = "Women",
                    categoryID = 4

                },
                new Product
                {
                    id = 22,
                    name = "Light Green Stripe Woven Pants",
                    price = 1296000,
                    title = "Women",
                    categoryID = 4

                },
                new Product
                {
                    id = 23,
                    name = "Green Stripe Wide Leg Woven Pants",
                    price = 1496000,
                    title = "Women",
                    categoryID = 4

                },
                new Product
                {
                    id = 24,
                    name = "Ochre Stripe Wide Leg Woven Pants",
                    price = 1296000,
                    title = "Women",
                    categoryID = 4
                },
                new Product
                {
                    id = 25,
                    name = "White Daisy Midi Brocade Dress",
                    price = 3296000,
                    title = "Women",
                    categoryID = 5
                },
                new Product
                {
                    id = 26,
                    name = "White Queen Anne Neck Midi Woven Dress",
                    price = 2496000,
                    title = "Women",
                    categoryID = 5
                },
                new Product
                {
                    id = 27,
                    name = "Yellow Strappy Midi Woven Dress",
                    price = 2496000,
                    title = "Women",
                    categoryID = 5
},
                new Product
                {
                    id = 28,
                    name = "Red Chrysanthemum Sleeveless Midi Dress",
                    price = 2996000,
                    title = "Women",
                    categoryID = 5
                },
                new Product
                {
                    id = 29,
                    name = "Multi-coloured Chrysanthemum Mini Dress",
                    price = 2996000,
                    title = "Women",
                    categoryID = 5
                },
                new Product
                {
                    id = 30,
                    name = "Yellow Chrysanthemum Mini Dress",
                    price = 2996000,
                    title = "Women",
                    categoryID = 5
                },
                new Product
                {
                    id = 31,
                    name = "Áo Polo nam Pique Cotton USA thấm hút tối đa (kẻ sọc) - Vàng sọc đen",
                    price = 229000,
                    title = "Men",
                    categoryID = 1
                },
                new Product
                {
                    id = 32,
                    name = "Áo Polo thể thao nam ProMax-S1 Logo thoáng khí - Xanh Navy",
                    price = 239000,
                    title = "Men",
                    categoryID = 1
                },
                new Product
                {
                    id = 33,
                    name = "Áo Polo nam Café - khử mùi hiệu quả - Xanh aqua",
                    price = 329000,
                    title = "Men",
                    categoryID = 1
                },
                new Product
                {
                    id = 34,
                    name = "Áo khoác nỉ nam For Winter (có mũ trùm tiện lợi) - Đen",
                    price = 349000,
                    title = "Men",
                    categoryID = 1
                },
                new Product
                {
                    id = 35,
                    name = "Áo Polo nam co giãn công nghệ Graphene - Xanh bóng đêm",
                    price = 329000,
                    title = "Men",
                    categoryID = 1
                },
                new Product
                {
                    id = 36,
                    name = "Áo thun nam Cotton Compact phiên bản Premium chống nhăn - Xanh Navy",
                    price = 259000,
                    title = "Men",
                    categoryID = 1
                },
                new Product
                {
                    id = 37,
                    name = "Quần shorts chạy bộ Advanced Fast & Free Run",
                    price = 399000,
                    title = "Men",
                    categoryID = 2
                },
                new Product
                {
                    id = 38,
name = "Quần Jeans Clean Denim dáng Regular S2 - Xanh garment",
                    price = 599000,
                    title = "Men",
                    categoryID = 2
                },
                new Product
                {
                    id = 39,
                    name = "Quần short nam thể thao 7",
                    price = 199000,
                    title = "Men",
                    categoryID = 2
                },
                new Product
                {
                    id = 40,
                    name = "Quần Jeans Clean Denim dáng Regular S3 - Xanh đậm",
                    price = 599000,
                    title = "Men",
                    categoryID = 2
                },
                new Product
                {
                    id = 41,
                    name = "Quần Jogger nam túi hộp Cargo Outdoor - Xám",
                    price = 329000,
                    title = "Men",
                    categoryID = 2
                },
                new Product
                {
                    id = 42,
                    name = "Quần short nam thể thao Recycle 7 thoáng khí - Xanh navy",
                    price = 179000,
                    title = "Men",
                    categoryID = 2
                },
                new Product
                {
                    id = 43,
                    name = "Ví Nam Tommy Hilfiger Mens Ranger Passcase Brown 5673/02 Màu Nâu",
                    price = 1090000,
                    title = "Jewelery",
                    categoryID = 7
                },
                new Product
                {
                    id = 44,
                    name = "úi Đeo Chéo Charles & Keith Croc-Effect Chain Strap Crossbody Bag CK2-80700998-4 Màu Đen",
                    price = 1860000,
                    title = "Jewelery",
                    categoryID = 7
                },
                new Product
                {
                    id = 45,
                    name = "Túi Xách Charles & Keith Scarf-Wrapped Top Handle",
                    price = 1880000,
                    title = "Jewelery",
                    categoryID = 7
                },
                new Product
                {
                    id = 46,
                    name = "Ví Nam Tommy Hilfiger Men's Thin Sleek Casual Bifold Wallet with 6 Credit Card Pockets And Removable Id Window",
                    price = 1100000,
                    title = "Jewelery",
                    categoryID = 7
                },
                new Product
                {
                    id = 47,
                    name = "Túi Xách MLB Monogram Embossed Hobo Bag New York Yankees 3ABQS022N-50CRS Màu Trắng",
                    price = 2800000,
                    title = "Jewelery",
                    categoryID = 7
                },
                new Product
                {
                    id = 48,
name = "Ví Nam Tommy Hilfiger Men's Thin Sleek Casual Bifold Wallet Black Dore",
                    price = 1300000,
                    title = "Jewelery",
                    categoryID = 7
                },
                new Product
                {
                    id = 49,
                    name = "Giày Gucci Ace Embroidered Sneaker White Leather",
                    price = 14800000,
                    title = "Jewelery",
                    categoryID = 8
                },
                new Product
                {
                    id = 50,
                    name = "Giày MLB Big Ball Chunky P Boston",
                    price = 1920000,
                    title = "Jewelery",
                    categoryID = 8
                },
                new Product
                {
                    id = 51,
                    name = "Giày Thể Thao Nike Court Vision Low Next Nature",
                    price = 1980000,
                    title = "Jewelery",
                    categoryID = 8
                },
                new Product
                {
                    id = 52,
                    name = "Giày MLB Big Ball Chunky P",
                    price = 1890000,
                    title = "Jewelery",
                    categoryID = 8
                },
                new Product
                {
                    id = 53,
                    name = "Giày Thể Thao Louis Vuitton LV Trainer Màu Đen",
                    price = 48900000,
                    title = "Jewelery",
                    categoryID = 8
                },
                new Product
                {
                    id = 54,
                    name = "Giày Thể Thao MLB Chunky Liner Boston Red",
                    price = 3350000,
                    title = "Jewelery",
                    categoryID = 8
                }
                
                );

            b.Entity<Attri>().HasData(
                new Attri { id=1,color="red",number=2,size=38},
                new Attri { id = 2, color = "green", number = 3, size = 40 },
                new Attri { id = 3, color = "red", number = 1, size = 39 },
                new Attri { id = 4, color = "red", number = 2, size = 41 },
                new Attri { id = 5, color = "yellow", number = 2 },
                new Attri { id = 6, color = "red", number = 5, size = 40 },
                new Attri { id = 7, color = "pink", number = 6, size = 38 },
                new Attri { id = 8, color = "blue", number = 4, size = 40 }
                );
            b.Entity<Stock>().HasData(
                new Stock { productID=1,attriID=1},
                new Stock { productID = 1, attriID = 2 },
                new Stock { productID=1, attriID=6},
                new Stock { productID = 1, attriID = 7 },
                new Stock { productID = 2, attriID = 3 },
                new Stock { productID = 2, attriID = 4 },
                new Stock { productID = 3, attriID = 5 },
                new Stock { productID = 3, attriID = 2 },
                new Stock { productID = 4, attriID = 6 },
                new Stock { productID = 4, attriID = 8 },
                new Stock { productID = 5, attriID = 1 },
                new Stock { productID = 5, attriID = 3 },
                new Stock { productID = 6, attriID = 4 },
                new Stock { productID = 6, attriID = 5 },
                new Stock { productID = 7, attriID = 6 },
                new Stock { productID = 7, attriID = 7 },
                new Stock { productID = 8, attriID = 8 },
                new Stock { productID = 8, attriID = 1 }
                );
            b.Entity<_Client>().HasData(
                new _Client { id = 1, address = "nha1", firstName = "truong", lastName = "minh nguyen", phoneNumber = "123456666" },
                new _Client { id = 2, address = "nha2", firstName = "henry", lastName = "Lord", phoneNumber = "222333111" },
                new _Client { id = 3, address = "nha3", firstName = "Anatamo", lastName = "Daisuki", phoneNumber = "3331112222" }

                );
            b.Entity<_Cart>().HasData(
                new _Cart { id=4,clientId=1,color="red",product= "Mens Cotton Jacket ",size=38,number=1 },
                new _Cart { id=2,clientId=1,color="green",product= "Mens Cotton Jacket ",size=40,number=1 },
                new _Cart { id=3,clientId=2,color="red",product= "Mens Cotton Jacket ",size=38,number=1 }
                );
        }
    }
}