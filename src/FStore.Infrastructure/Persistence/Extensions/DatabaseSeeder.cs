using FStore.Domain.Enum;

namespace FStore.Infrastructure.Persistence.Extensions
{
    public static class DatabaseSeeder
    {
        // Seeding UserIdentity
        public static void SeedingUserIdentity(ModelBuilder modelBuilder)
        {
            const string defaultPassword = "123456";

            CryptographyHelper.CreatePasswordHash(defaultPassword, out byte[] passwordHash, out byte[] passwordSalt);

            modelBuilder.Entity<Account>().HasData(
               new Account
               {
                   Id = new Guid("3aec8f0b-3a6a-4b5d-8a3a-348ae529001a"),
                   Username = "admin@example.com",
                   PasswordHash = passwordHash,
                   PasswordSalt = passwordSalt,
                   Role = UserRole.Admin
               },
               new Account
               {
                   Id = new Guid("2b25a754-a50e-4468-942c-d65c0bc2c86f"),
                   Username = "customer@example.com",
                   PasswordHash = passwordHash,
                   PasswordSalt = passwordSalt,
                   Role = UserRole.Customer,
               },
               new Account
               {
                   Id = new Guid("db757696-89d6-4f61-84bb-61bc9b87ea05"),
                   Username = "customer2@example.com",
                   PasswordHash = passwordHash,
                   PasswordSalt = passwordSalt,
                   Role = UserRole.Customer,
               },
               new Account
               {
                   Id = new Guid("3141069d-f4f3-475c-8efc-99e1b4c3e627"),
                   Username = "employee@example.com",
                   PasswordHash = passwordHash,
                   PasswordSalt = passwordSalt,
                   Role = UserRole.Employee
               },
               new Account
               {
                   Id = new Guid("a3339dd7-94b9-4f12-9d18-2ee341b4f35c"),
                   Username = "nguyenvanminh@example.com",
                   PasswordHash = passwordHash,
                   PasswordSalt = passwordSalt,
                   Role = UserRole.Customer
               },
               new Account
               {
                   Id = new Guid("6060ab5a-ca8b-409c-87b2-363a69f06e66"),
                   Username = "lethimai@example.com",
                   PasswordHash = passwordHash,
                   PasswordSalt = passwordSalt,
                   Role = UserRole.Customer
               },
               new Account
               {
                   Id = new Guid("0e5c838e-f387-4183-a1c1-4c1e802ab180"),
                   Username = "tranlan@example.com",
                   PasswordHash = passwordHash,
                   PasswordSalt = passwordSalt,
                   Role = UserRole.Customer
               },
               new Account
               {
                   Id = new Guid("ae4c4f03-aa8a-4f37-a7cb-c5bc06e08d74"),
                   Username = "nguyenan@example.com",
                   PasswordHash = passwordHash,
                   PasswordSalt = passwordSalt,
                   Role = UserRole.Customer
               },
               new Account
               {
                   Id = new Guid("463d52ee-4c4e-40b0-a8f3-e59086878964"),
                   Username = "phantuyet@example.com",
                   PasswordHash = passwordHash,
                   PasswordSalt = passwordSalt,
                   Role = UserRole.Customer
               },
               new Account
               {
                   Id = new Guid("80cd99a5-f3e4-43f6-a725-f4e07fa7cd7d"),
                   Username = "vuvankhai@example.com",
                   PasswordHash = passwordHash,
                   PasswordSalt = passwordSalt,
                   Role = UserRole.Customer
               },
               new Account
               {
                   Id = new Guid("c36aab76-f6cc-46f6-a6c3-730d54b61a48"),
                   Username = "lehoanganh@example.com",
                   PasswordHash = passwordHash,
                   PasswordSalt = passwordSalt,
                   Role = UserRole.Customer
               },
               new Account
               {
                   Id = new Guid("4b45812f-2f47-41b9-b913-39bed1b02c1d"),
                   Username = "tranle@example.com",
                   PasswordHash = passwordHash,
                   PasswordSalt = passwordSalt,
                   Role = UserRole.Customer
               },
               new Account
               {
                   Id = new Guid("3a9477da-b75c-4ef6-9bf6-a93aa5ffaf6f"),
                   Username = "hoangmai@example.com",
                   PasswordHash = passwordHash,
                   PasswordSalt = passwordSalt,
                   Role = UserRole.Customer
               },
               new Account
               {
                   Id = new Guid("d15fcb08-fcb1-4a55-b012-b2be211ed2c1"),
                   Username = "lehoa@example.com",
                   PasswordHash = passwordHash,
                   PasswordSalt = passwordSalt,
                   Role = UserRole.Customer
               }
            );

            modelBuilder.Entity<Address>().HasData(
                   new Address
                   {
                       Id = Guid.NewGuid(),
                       AccountId = new Guid("3aec8f0b-3a6a-4b5d-8a3a-348ae529001a"),
                       Name = "John Admin",
                       Email = "johnadmin@example.com",
                       PhoneNumber = "1234567891",
                       AddressLine = "125 Đường Cầu Giấy ,Cầu Giấy, Hà Nội",
                       IsMain = true
                   },
                   new Address
                   {
                       Id = Guid.NewGuid(),
                       AccountId = new Guid("2b25a754-a50e-4468-942c-d65c0bc2c86f"),
                       Name = "Đăng Thị Hồng Nhung",
                       Email = "dangnhung72@gmail.com",
                       PhoneNumber = "0366702305",
                       AddressLine = "25 Phình Hồ, Văn Chấn, Yên Bái",
                       IsMain = false
                   },
                   new Address
                   {
                       Id = Guid.NewGuid(),
                       AccountId = new Guid("2b25a754-a50e-4468-942c-d65c0bc2c86f"),
                       Name = "Nguyễn Quang Hưng",
                       Email = "q170302@email.com",
                       PhoneNumber = "0344917302",
                       AddressLine = "22 Ngã Ba Kim, Mù Cang Chải, Yên Bái",
                       IsMain = true
                   },
                   new Address
                   {
                       Id = Guid.NewGuid(),
                       AccountId = new Guid("db757696-89d6-4f61-84bb-61bc9b87ea05"),
                       Name = "Nguyễn Văn An",
                       Email = "nguyenvana@example.com",
                       PhoneNumber = "0912345678",
                       AddressLine = "15 Lê Văn Lương, Thanh Xuân, Hà Nội",
                       IsMain = true
                   },
                   new Address
                   {
                       Id = Guid.NewGuid(),
                       AccountId = new Guid("db757696-89d6-4f61-84bb-61bc9b87ea05"),
                       Name = "Lê Thị Bích",
                       Email = "lethib@example.com",
                       PhoneNumber = "0923456789",
                       AddressLine = "20 Nguyễn Trãi, Thanh Xuân, Hà Nội",
                       IsMain = false
                   },
                   new Address
                   {
                       Id = Guid.NewGuid(),
                       AccountId = new Guid("db757696-89d6-4f61-84bb-61bc9b87ea05"),
                       Name = "Phạm Văn Công",
                       Email = "phamvanc@example.com",
                       PhoneNumber = "0934567890",
                       AddressLine = "88 Đường Giải Phóng, Hoàng Mai, Hà Nội",
                       IsMain = false
                   },
                   new Address
                   {
                       Id = Guid.NewGuid(),
                       AccountId = new Guid("3141069d-f4f3-475c-8efc-99e1b4c3e627"),
                       Name = "John Employee",
                       Email = "johnemployee@example.com",
                       PhoneNumber = "1234567892",
                       AddressLine = "121 Đường Cầu Giấy ,Cầu Giấy, Hà Nội",
                       IsMain = true
                   },
                   new Address
                   {
                       Id = Guid.NewGuid(),
                       AccountId = new Guid("a3339dd7-94b9-4f12-9d18-2ee341b4f35c"),
                       Name = "Nguyễn Văn Minh",
                       Email = "minhnguyen@example.com",
                       PhoneNumber = "0987654321",
                       AddressLine = "456 Đường Nguyễn Trãi, Phường Bến Thành, Quận 1, TP. Hồ Chí Minh",
                       IsMain = true
                   },
                   new Address
                   {
                       Id = Guid.NewGuid(),
                       AccountId = new Guid("6060ab5a-ca8b-409c-87b2-363a69f06e66"),
                       Name = "Lê Thị Mai",
                       Email = "lethimai@example.com",
                       PhoneNumber = "0912345679",
                       AddressLine = "789 Đường Lê Văn Sỹ, Phường 13, Quận 3, TP. Hồ Chí Minh",
                       IsMain = true
                   },
                   new Address
                   {
                       Id = Guid.NewGuid(),
                       AccountId = new Guid("0e5c838e-f387-4183-a1c1-4c1e802ab180"),
                       Name = "Trần Thị Lan",
                       Email = "tranlan@example.com",
                       PhoneNumber = "0908765432",
                       AddressLine = "123 Đường Lê Lai, Phường Phú Hòa, TP. Thủ Dầu Một, Bình Dương",
                       IsMain = true
                   },
                   new Address
                   {
                       Id = Guid.NewGuid(),
                       AccountId = new Guid("ae4c4f03-aa8a-4f37-a7cb-c5bc06e08d74"),
                       Name = "Nguyễn Thị An",
                       Email = "nguyenan@example.com",
                       PhoneNumber = "0976543210",
                       AddressLine = "456 Đường Nguyễn Thái Học, Phường 10, TP. Cần Thơ",
                       IsMain = true
                   },
                   new Address
                   {
                       Id = Guid.NewGuid(),
                       AccountId = new Guid("463d52ee-4c4e-40b0-a8f3-e59086878964"),
                       Name = "Phan Thị Tuyết",
                       Email = "phantuyet@example.com",
                       PhoneNumber = "0901234567",
                       AddressLine = "789 Đường Võ Văn Tần, Phường 5, Quận 3, TP. Hồ Chí Minh",
                       IsMain = true
                   },
                   new Address
                   {
                       Id = Guid.NewGuid(),
                       AccountId = new Guid("80cd99a5-f3e4-43f6-a725-f4e07fa7cd7d"),
                       Name = "Vũ Văn Khải",
                       Email = "vuvankhai@example.com",
                       PhoneNumber = "0912345678",
                       AddressLine = "123 Đường Trường Chinh, Phường 14, Quận Tân Bình, TP. Hồ Chí Minh",
                       IsMain = true
                   },
                   new Address
                   {
                       Id = Guid.NewGuid(),
                       AccountId = new Guid("c36aab76-f6cc-46f6-a6c3-730d54b61a48"),
                       Name = "Lê Hoàng Anh",
                       Email = "lehoanganh@example.com",
                       PhoneNumber = "0923456789",
                       AddressLine = "234 Đường Hà Huy Tập, Phường Đông Vệ, TP. Thanh Hóa",
                       IsMain = true
                   },
                   new Address
                   {
                       Id = Guid.NewGuid(),
                       AccountId = new Guid("4b45812f-2f47-41b9-b913-39bed1b02c1d"),
                       Name = "Trần Thị Lệ",
                       Email = "tranle@example.com",
                       PhoneNumber = "0987654321",
                       AddressLine = "123 Đường Nguyễn Văn Linh, Phường Tân Hưng, Quận 7, TP. Hồ Chí Minh",
                       IsMain = true
                   },
                   new Address
                   {
                       Id = Guid.NewGuid(),
                       AccountId = new Guid("3a9477da-b75c-4ef6-9bf6-a93aa5ffaf6f"),
                       Name = "Hoàng Thị Mai",
                       Email = "hoangmai@example.com",
                       PhoneNumber = "0976543210",
                       AddressLine = "456 Đường Phan Chu Trinh, Phường 5, TP. Đà Nẵng",
                       IsMain = true
                   },
                   new Address
                   {
                       Id = Guid.NewGuid(),
                       AccountId = new Guid("d15fcb08-fcb1-4a55-b012-b2be211ed2c1"),
                       Name = "Lê Thị Hòa",
                       Email = "lehoa@example.com",
                       PhoneNumber = "0934567890",
                       AddressLine = "789 Đường Lý Thường Kiệt, Phường Bắc Lý, TP. Quảng Bình",
                       IsMain = true
                   }
            );
        }

        // Seeding Catalog

        public static void SeedingCatalog(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductType>().HasData(
               new ProductType
               {
                   Id = new Guid("e21526c4-f78b-4eb5-8ae0-919633179582"),
                   Name = "Default",
               },
               new ProductType
               {
                   Id = new Guid("ff58b31e-53d5-4216-84a4-0566cb2e9b52"),
                   Name = "Paperback",
               },
               new ProductType
               {
                   Id = new Guid("b28481c3-51fb-4a94-8558-0ac0ebfb1607"),
                   Name = "E-Book",
               },
               new ProductType
               {
                   Id = new Guid("43a56b31-2f02-4e9d-88b0-2b3ced2276ba"),
                   Name = "Audiobook",
               },
               new ProductType
               {
                   Id = new Guid("dfd52a60-8ccf-4ac2-980c-14ddf41e9a18"),
                   Name = "Stream",
               },
               new ProductType
               {
                   Id = new Guid("fbaeaba4-a5bc-487e-b0e5-0967ff543d5d"),
                   Name = "Blu-ray",
               },
               new ProductType
               {
                   Id = new Guid("7c604dd7-d603-4f6a-b5bf-f254bd812787"),
                   Name = "VHS",
               },
               new ProductType
               {
                   Id = new Guid("e2d9219f-c57b-4c59-bea0-6a3af2e655a5"),
                   Name = "PC",
               },
               new ProductType
               {
                   Id = new Guid("f728c3bf-b4d8-41f6-93ab-7a91cba390be"),
                   Name = "PlayStation",
               },
               new ProductType
               {
                   Id = new Guid("934902b5-c2a2-4fbc-97c2-8887ed45d08e"),
                   Name = "Xbox",
               }
               );

            modelBuilder.Entity<ProductAttribute>().HasData(
                new ProductAttribute
                {
                    Id = new Guid("bd2d16dc-10a9-40b1-b76a-e39f3c015086"),
                    Name = "Author",
                },
                new ProductAttribute
                {
                    Id = new Guid("09ec0726-d537-4c92-aaaf-760f19c6999f"),
                    Name = "Publisher",
                },
                new ProductAttribute
                {
                    Id = new Guid("d369dc76-92cf-417a-aea5-17616c87d4ce"),
                    Name = "ISBN"
                },
                new ProductAttribute
                {
                    Id = new Guid("50b7176f-4b13-484b-aec4-edf9383b9232"),
                    Name = "Pages"
                },
                new ProductAttribute
                {
                    Id = new Guid("b96ab5d0-3155-4688-8fb4-c6427e0661d5"),
                    Name = "Directors"
                },
                new ProductAttribute
                {
                    Id = new Guid("99bf3d94-a248-46f8-bbcb-0f9ae07ce1af"),
                    Name = "Writers"
                },
                new ProductAttribute
                {
                    Id = new Guid("a5913406-23e7-4451-a19c-242c974e312e"),
                    Name = "Stars"
                },
                new ProductAttribute
                {
                    Id = new Guid("c84ec2fc-651b-42e1-b073-022596ac90c0"),
                    Name = "Gerne"
                },
                new ProductAttribute
                {
                    Id = new Guid("4150124b-2a58-4d98-8abe-f380e99a6fa9"),
                    Name = "Developer"
                }
                );

            modelBuilder.Entity<Category>().HasData(
              new Category
              {
                  Id = new Guid("a186203e-0d11-4c22-a45e-58ecfeed368f"),
                  Title = "Books",
                  Slug = "books"
              },
              new Category
              {
                  Id = new Guid("2c8eb836-090b-4a18-a869-620d7f527180"),
                  Title = "Movies",
                  Slug = "movies"
              },
              new Category
              {
                  Id = new Guid("c236f9f6-2c4c-4ba3-99ed-9cf81ee9bf46"),
                  Title = "Video Games",
                  Slug = "video-games"
              }
            );

            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = new Guid("318f6a20-3c0b-40ca-9cf0-9533e83d3734"),
                Title = "The Hitchhiker's Guide to the Galaxy",
                Slug = "the-hitchhikers-guide-to-the-galaxy",
                Description = "The Hitchhiker's Guide to the Galaxy is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text adventure game, and 2005 feature film.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                CategoryId = new Guid("a186203e-0d11-4c22-a45e-58ecfeed368f")
            },
            new Product
            {
                Id = new Guid("ce50c69d-5897-4e3d-8d2d-081114ed1fb0"),
                Title = "Ready Player One",
                Slug = "ready-player-one",
                Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House). The book was published on August 16, 2011. An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters. In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association and won the 2011 Prometheus Award. A film adaptation, screenwritten by Cline and Zak Penn and directed by Steven Spielberg, was released on March 29, 2018. A sequel novel, Ready Player Two, was released on November 24, 2020, to a widely negative critical reception.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                CategoryId = new Guid("a186203e-0d11-4c22-a45e-58ecfeed368f")
            },
            new Product
            {
                Id = new Guid("c7537965-c2cb-4e77-bfc5-6c466c9a3bea"),
                Title = "Nineteen Eighty-Four",
                Slug = "nineteen-eighty-four",
                Description = "Nineteen Eighty-Four (also published as 1984) is a dystopian novel and cautionary tale by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society. Orwell, a democratic socialist, modelled the authoritarian state in the novel on the Soviet Union in the era of Stalinism, and Nazi Germany. More broadly, the novel examines the role of truth and facts within societies and the ways in which they can be manipulated.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/51/1984_first_edition_cover.jpg",
                CategoryId = new Guid("a186203e-0d11-4c22-a45e-58ecfeed368f")
            },
            new Product
            {
                Id = new Guid("4f5c260c-0870-4940-a394-b20c56b3fcca"),
                CategoryId = new Guid("2c8eb836-090b-4a18-a869-620d7f527180"),
                Title = "The Matrix",
                Slug = "the-matrix",
                Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
            },
            new Product
            {
                Id = new Guid("f2b7ac53-e3e5-4f7c-8094-99530bbde9eb"),
                CategoryId = new Guid("2c8eb836-090b-4a18-a869-620d7f527180"),
                Title = "Back to the Future",
                Slug = "back-to-the-future",
                Description = "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg",
            },
            new Product
            {
                Id = new Guid("321ec52d-5fb6-4b1b-bb35-6f73cf92396d"),
                CategoryId = new Guid("2c8eb836-090b-4a18-a869-620d7f527180"),
                Title = "Toy Story",
                Slug = "toy-story",
                Description = "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg",

            },
            new Product
            {
                Id = new Guid("106e97ab-bbce-44b8-95c4-a287752d8561"),
                CategoryId = new Guid("c236f9f6-2c4c-4ba3-99ed-9cf81ee9bf46"),
                Title = "Half-Life 2",
                Slug = "half-life-2",
                Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",

            },
            new Product
            {
                Id = new Guid("07acf5bd-e13d-4667-ba8e-70be6785f655"),
                CategoryId = new Guid("c236f9f6-2c4c-4ba3-99ed-9cf81ee9bf46"),
                Title = "Diablo II",
                Slug = "diablo-ii",
                Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
            },
            new Product
            {
                Id = new Guid("00cab8fd-ad0e-433b-8bb0-2c9596809b7b"),
                CategoryId = new Guid("c236f9f6-2c4c-4ba3-99ed-9cf81ee9bf46"),
                Title = "Day of the Tentacle",
                Slug = "day-of-the-tentacle",
                Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg"
            },
            new Product
            {
                Id = new Guid("fc67ff65-d124-4350-94fa-8dd1cc0559e1"),
                CategoryId = new Guid("c236f9f6-2c4c-4ba3-99ed-9cf81ee9bf46"),
                Title = "Xbox",
                Slug = "xbox",
                Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
            },
            new Product
            {
                Id = new Guid("aed54a62-e6e7-4670-ab24-1c84b911deb0"),
                CategoryId = new Guid("c236f9f6-2c4c-4ba3-99ed-9cf81ee9bf46"),
                Title = "Super Nintendo Entertainment System",
                Slug = "super-nintendo-entertainment-system",
                Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
            }

        );

            modelBuilder.Entity<ProductVariant>().HasData(
               new ProductVariant
               {
                   ProductId = new Guid("318f6a20-3c0b-40ca-9cf0-9533e83d3734"),
                   ProductTypeId = new Guid("ff58b31e-53d5-4216-84a4-0566cb2e9b52"),
                   Price = 9.99m,
                   OriginalPrice = 19.99m
               },
               new ProductVariant
               {
                   ProductId = new Guid("318f6a20-3c0b-40ca-9cf0-9533e83d3734"),
                   ProductTypeId = new Guid("b28481c3-51fb-4a94-8558-0ac0ebfb1607"),
                   Price = 7.99m
               },
               new ProductVariant
               {
                   ProductId = new Guid("318f6a20-3c0b-40ca-9cf0-9533e83d3734"),
                   ProductTypeId = new Guid("43a56b31-2f02-4e9d-88b0-2b3ced2276ba"),
                   Price = 19.99m,
                   OriginalPrice = 29.9m
               },
               new ProductVariant
               {
                   ProductId = new Guid("ce50c69d-5897-4e3d-8d2d-081114ed1fb0"),
                   ProductTypeId = new Guid("ff58b31e-53d5-4216-84a4-0566cb2e9b52"),
                   Price = 7.99m,
                   OriginalPrice = 14.99m
               },
               new ProductVariant
               {
                   ProductId = new Guid("c7537965-c2cb-4e77-bfc5-6c466c9a3bea"),
                   ProductTypeId = new Guid("ff58b31e-53d5-4216-84a4-0566cb2e9b52"),
                   Price = 6.99m
               },
               new ProductVariant
               {
                   ProductId = new Guid("4f5c260c-0870-4940-a394-b20c56b3fcca"),
                   ProductTypeId = new Guid("dfd52a60-8ccf-4ac2-980c-14ddf41e9a18"),
                   Price = 3.99m
               },
               new ProductVariant
               {
                   ProductId = new Guid("4f5c260c-0870-4940-a394-b20c56b3fcca"),
                   ProductTypeId = new Guid("fbaeaba4-a5bc-487e-b0e5-0967ff543d5d"),
                   Price = 9.99m
               },
               new ProductVariant
               {
                   ProductId = new Guid("4f5c260c-0870-4940-a394-b20c56b3fcca"),
                   ProductTypeId = new Guid("7c604dd7-d603-4f6a-b5bf-f254bd812787"),
                   Price = 19.99m
               },
               new ProductVariant
               {
                   ProductId = new Guid("f2b7ac53-e3e5-4f7c-8094-99530bbde9eb"),
                   ProductTypeId = new Guid("dfd52a60-8ccf-4ac2-980c-14ddf41e9a18"),
                   Price = 3.99m
               },
               new ProductVariant
               {
                   ProductId = new Guid("321ec52d-5fb6-4b1b-bb35-6f73cf92396d"),
                   ProductTypeId = new Guid("dfd52a60-8ccf-4ac2-980c-14ddf41e9a18"),
                   Price = 2.99m
               },
               new ProductVariant
               {
                   ProductId = new Guid("106e97ab-bbce-44b8-95c4-a287752d8561"),
                   ProductTypeId = new Guid("e2d9219f-c57b-4c59-bea0-6a3af2e655a5"),
                   Price = 19.99m,
                   OriginalPrice = 29.99m
               },
               new ProductVariant
               {
                   ProductId = new Guid("106e97ab-bbce-44b8-95c4-a287752d8561"),
                   ProductTypeId = new Guid("f728c3bf-b4d8-41f6-93ab-7a91cba390be"),
                   Price = 6.99m
               },
               new ProductVariant
               {
                   ProductId = new Guid("106e97ab-bbce-44b8-95c4-a287752d8561"),
                   ProductTypeId = new Guid("934902b5-c2a2-4fbc-97c2-8887ed45d08e"),
                   Price = 4.99m,
                   OriginalPrice = 5.99m
               },
               new ProductVariant
               {
                   ProductId = new Guid("07acf5bd-e13d-4667-ba8e-70be6785f655"),
                   ProductTypeId = new Guid("e2d9219f-c57b-4c59-bea0-6a3af2e655a5"),
                   Price = 9.99m,
                   OriginalPrice = 24.99m,
               },
               new ProductVariant
               {
                   ProductId = new Guid("00cab8fd-ad0e-433b-8bb0-2c9596809b7b"),
                   ProductTypeId = new Guid("e2d9219f-c57b-4c59-bea0-6a3af2e655a5"),
                   Price = 14.99m
               },
               new ProductVariant
               {
                   ProductId = new Guid("fc67ff65-d124-4350-94fa-8dd1cc0559e1"),
                   ProductTypeId = new Guid("e21526c4-f78b-4eb5-8ae0-919633179582"),
                   Price = 159.99m,
                   OriginalPrice = 299.99m
               },
               new ProductVariant
               {
                   ProductId = new Guid("aed54a62-e6e7-4670-ab24-1c84b911deb0"),
                   ProductTypeId = new Guid("e21526c4-f78b-4eb5-8ae0-919633179582"),
                   Price = 79.99m,
                   OriginalPrice = 139.99m
               }
        );
            modelBuilder.Entity<ProductValue>().HasData(
                  new ProductValue
                  {
                      ProductId = new Guid("318f6a20-3c0b-40ca-9cf0-9533e83d3734"),
                      ProductAttributeId = new Guid("bd2d16dc-10a9-40b1-b76a-e39f3c015086"),
                      Value = "Douglas Adams"
                  },
                  new ProductValue
                  {
                      ProductId = new Guid("318f6a20-3c0b-40ca-9cf0-9533e83d3734"),
                      ProductAttributeId = new Guid("09ec0726-d537-4c92-aaaf-760f19c6999f"),
                      Value = "Random House Worlds; Reissue edition (June 23, 1997)"
                  },
                  new ProductValue
                  {
                      ProductId = new Guid("318f6a20-3c0b-40ca-9cf0-9533e83d3734"),
                      ProductAttributeId = new Guid("d369dc76-92cf-417a-aea5-17616c87d4ce"),
                      Value = "978-0345418913"
                  },
                  new ProductValue
                  {
                      ProductId = new Guid("318f6a20-3c0b-40ca-9cf0-9533e83d3734"),
                      ProductAttributeId = new Guid("50b7176f-4b13-484b-aec4-edf9383b9232"),
                      Value = "208 pages"
                  },
                  new ProductValue
                  {
                      ProductId = new Guid("ce50c69d-5897-4e3d-8d2d-081114ed1fb0"),
                      ProductAttributeId = new Guid("bd2d16dc-10a9-40b1-b76a-e39f3c015086"),
                      Value = "Ernest Cline"
                  },
                  new ProductValue
                  {
                      ProductId = new Guid("ce50c69d-5897-4e3d-8d2d-081114ed1fb0"),
                      ProductAttributeId = new Guid("09ec0726-d537-4c92-aaaf-760f19c6999f"),
                      Value = "Random House Publishing Group; 32089th edition (June 5, 2012)"
                  },
                  new ProductValue
                  {
                      ProductId = new Guid("ce50c69d-5897-4e3d-8d2d-081114ed1fb0"),
                      ProductAttributeId = new Guid("d369dc76-92cf-417a-aea5-17616c87d4ce"),
                      Value = "978-0307887443"
                  },
                  new ProductValue
                  {
                      ProductId = new Guid("ce50c69d-5897-4e3d-8d2d-081114ed1fb0"),
                      ProductAttributeId = new Guid("50b7176f-4b13-484b-aec4-edf9383b9232"),
                      Value = "384 pages"
                  },
                  new ProductValue
                  {
                      ProductId = new Guid("c7537965-c2cb-4e77-bfc5-6c466c9a3bea"),
                      ProductAttributeId = new Guid("bd2d16dc-10a9-40b1-b76a-e39f3c015086"),
                      Value = "George Orwell"
                  },
                  new ProductValue
                  {
                      ProductId = new Guid("c7537965-c2cb-4e77-bfc5-6c466c9a3bea"),
                      ProductAttributeId = new Guid("09ec0726-d537-4c92-aaaf-760f19c6999f"),
                      Value = "Hawk Press (May 12, 1994)"
                  },
                  new ProductValue
                  {
                      ProductId = new Guid("c7537965-c2cb-4e77-bfc5-6c466c9a3bea"),
                      ProductAttributeId = new Guid("d369dc76-92cf-417a-aea5-17616c87d4ce"),
                      Value = "978-9388318563"
                  },
                  new ProductValue
                  {
                      ProductId = new Guid("c7537965-c2cb-4e77-bfc5-6c466c9a3bea"),
                      ProductAttributeId = new Guid("50b7176f-4b13-484b-aec4-edf9383b9232"),
                      Value = "242 pages"
                  },
                  new ProductValue
                  {
                      ProductId = new Guid("4f5c260c-0870-4940-a394-b20c56b3fcca"),
                      ProductAttributeId = new Guid("b96ab5d0-3155-4688-8fb4-c6427e0661d5"),
                      Value = "Lana Wachowski, Lilly Wachowski"
                  },
                  new ProductValue
                  {
                      ProductId = new Guid("4f5c260c-0870-4940-a394-b20c56b3fcca"),
                      ProductAttributeId = new Guid("99bf3d94-a248-46f8-bbcb-0f9ae07ce1af"),
                      Value = "Lana Wachowski, Lilly Wachowski"
                  },
                  new ProductValue
                  {
                      ProductId = new Guid("4f5c260c-0870-4940-a394-b20c56b3fcca"),
                      ProductAttributeId = new Guid("a5913406-23e7-4451-a19c-242c974e312e"),
                      Value = "Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss"
                  },
                  new ProductValue
                  {
                      ProductId = new Guid("f2b7ac53-e3e5-4f7c-8094-99530bbde9eb"),
                      ProductAttributeId = new Guid("b96ab5d0-3155-4688-8fb4-c6427e0661d5"),
                      Value = "Robert Zemeckis"
                  },
                  new ProductValue
                  {
                      ProductId = new Guid("f2b7ac53-e3e5-4f7c-8094-99530bbde9eb"),
                      ProductAttributeId = new Guid("99bf3d94-a248-46f8-bbcb-0f9ae07ce1af"),
                      Value = "Robert Zemeckis, Bob Gale"
                  },
                  new ProductValue
                  {
                      ProductId = new Guid("f2b7ac53-e3e5-4f7c-8094-99530bbde9eb"),
                      ProductAttributeId = new Guid("a5913406-23e7-4451-a19c-242c974e312e"),
                      Value = "Michael J. Fox, Christopher Lloyd, Lea Thompson"
                  },
                  new ProductValue
                  {
                      ProductId = new Guid("321ec52d-5fb6-4b1b-bb35-6f73cf92396d"),
                      ProductAttributeId = new Guid("b96ab5d0-3155-4688-8fb4-c6427e0661d5"),
                      Value = "John Lasseter"
                  },
                  new ProductValue
                  {
                      ProductId = new Guid("321ec52d-5fb6-4b1b-bb35-6f73cf92396d"),
                      ProductAttributeId = new Guid("99bf3d94-a248-46f8-bbcb-0f9ae07ce1af"),
                      Value = "John Lasseter, Pete Docter, Andrew Stanton"
                  },
                  new ProductValue
                  {
                      ProductId = new Guid("321ec52d-5fb6-4b1b-bb35-6f73cf92396d"),
                      ProductAttributeId = new Guid("a5913406-23e7-4451-a19c-242c974e312e"),
                      Value = "Tom Hanks, Tim Allen, Don Rickles"
                  },
                  new ProductValue
                  {
                      ProductId = new Guid("106e97ab-bbce-44b8-95c4-a287752d8561"),
                      ProductAttributeId = new Guid("c84ec2fc-651b-42e1-b073-022596ac90c0"),
                      Value = "Action"
                  },
                  new ProductValue
                  {
                      ProductId = new Guid("106e97ab-bbce-44b8-95c4-a287752d8561"),
                      ProductAttributeId = new Guid("4150124b-2a58-4d98-8abe-f380e99a6fa9"),
                      Value = "Valve"
                  },
                  new ProductValue
                  {
                      ProductId = new Guid("106e97ab-bbce-44b8-95c4-a287752d8561"),
                      ProductAttributeId = new Guid("09ec0726-d537-4c92-aaaf-760f19c6999f"),
                      Value = "Valve"
                  },
                  new ProductValue
                  {
                      ProductId = new Guid("07acf5bd-e13d-4667-ba8e-70be6785f655"),
                      ProductAttributeId = new Guid("c84ec2fc-651b-42e1-b073-022596ac90c0"),
                      Value = "Action, Role-playing"
                  },
                  new ProductValue
                  {
                      ProductId = new Guid("07acf5bd-e13d-4667-ba8e-70be6785f655"),
                      ProductAttributeId = new Guid("4150124b-2a58-4d98-8abe-f380e99a6fa9"),
                      Value = "Blizzard North"
                  },
                  new ProductValue
                  {
                      ProductId = new Guid("07acf5bd-e13d-4667-ba8e-70be6785f655"),
                      ProductAttributeId = new Guid("09ec0726-d537-4c92-aaaf-760f19c6999f"),
                      Value = "Blizzard Entertainment"
                  },
                  new ProductValue
                  {
                      ProductId = new Guid("00cab8fd-ad0e-433b-8bb0-2c9596809b7b"),
                      ProductAttributeId = new Guid("c84ec2fc-651b-42e1-b073-022596ac90c0"),
                      Value = "Graphic Adventure"
                  },
                  new ProductValue
                  {
                      ProductId = new Guid("00cab8fd-ad0e-433b-8bb0-2c9596809b7b"),
                      ProductAttributeId = new Guid("4150124b-2a58-4d98-8abe-f380e99a6fa9"),
                      Value = "LucasArts"
                  },
                  new ProductValue
                  {
                      ProductId = new Guid("00cab8fd-ad0e-433b-8bb0-2c9596809b7b"),
                      ProductAttributeId = new Guid("09ec0726-d537-4c92-aaaf-760f19c6999f"),
                      Value = "LucasArts"
                  }
            );
        }

        // Seeding Coupon

        public static void SeedingCoupon(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coupon>().HasData(
                new Coupon
                {
                    Id = Guid.NewGuid(),
                    Code = "SUMMER24",
                    VoucherName = "Summer 24% Discount",
                    IsDiscountPercent = true,
                    DiscountValue = 24.00m,
                    MinOrderCondition = 200000,
                    MaxDiscountValue = 80000,
                    Quantity = 1000,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(30),
                },
                 new Coupon
                 {
                     Id = Guid.NewGuid(),
                     Code = "SUMMER20000",
                     VoucherName = "Summer 20000VND Discount",
                     IsDiscountPercent = false,
                     DiscountValue = 19.00m,
                     MinOrderCondition = 199m,
                     MaxDiscountValue = 0,
                     Quantity = 1000,
                     StartDate = DateTime.Now,
                     EndDate = DateTime.Now.AddDays(30),
                 }
              );

        }
    }
}
