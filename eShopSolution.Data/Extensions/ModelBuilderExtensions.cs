using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using eShopSolution.Data.Entities;
using eShopSolution.Data.Enum;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { 
                    Key="HomeTitle",
                    Value="This is homepage of eShopSolution"
                },
                new AppConfig() {
                    Key="HomeKeyWord",
                    Value="This is HomeKeyWord of eShopSolution"
                },
                new AppConfig() { 
                    Key="HomeDescription",
                    Value="This is HomeDescription of eShopSolution"
                });

            modelBuilder.Entity<Language>().HasData(
                new Language() { 
                    Name="Tiếng Việt",
                    Id="vi-VN",
                    IsDefault=true
                },
                new Language() {
                    Name="English",
                    Id="en-US", 
                    IsDefault=false
                });

            modelBuilder.Entity<Category>().HasData(
                new Category() {
                    Id=1,
                    IsShownHome=true,
                    ParentId=null, 
                    SortOrder=1,
                    Status=Status.Active,
                },
                new Category()
                {
                    Id=2,
                    IsShownHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Status.Active
                    
                });
            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation()
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Áo nam",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nam",
                    SeoDescription = "Sản phẩm áo thời trang nam",
                    SeoTitle = "Áo thời trang nam"
                },
                new CategoryTranslation()
                {
                     Id = 2,
                     CategoryId = 1,
                     Name = "Men shirt",
                     LanguageId = "en-US",
                     SeoAlias = "men-shirt",
                     SeoDescription = "The shirt for men",
                     SeoTitle = "The shirt for men"
                },
                new CategoryTranslation()
                {
                    Id = 3,
                    CategoryId = 2,
                    Name = "Áo nữ",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nam",
                    SeoDescription = "Sản phẩm áo thời trang nữ",
                    SeoTitle = "Áo thời trang nữ"
                },
                new CategoryTranslation()
                {
                    Id = 4,
                    CategoryId = 2,
                    Name = "Women shirt",
                    LanguageId = "en-US",
                    SeoAlias = "women-shirt",
                    SeoDescription = "The shirt for women",
                    SeoTitle = "The shirt for women"
                }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product() { 
                    Id=1,
                    DateCreated=DateTime.Now,
                    OriginalPrice=100000,
                    Price=200000,
                    Stock=0,
                    ViewCount=0
                });
            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation()
                {
                    Id=1,
                    ProductId = 1,
                    Name = "Áo sơ mi trắng nam Việt Tiến",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-so-mi-trang-nam-viet-tien",
                    SeoDescription = "Áo sơ mi trắng nam Việt Tiến",
                    SeoTitle = "Áo sơ mi trắng nam Việt Tiến",
                    Description = "Áo sơ mi trắng nam Việt Tiến",
                    Details = "Áo sơ mi trắng nam Việt Tiến"
                },
                new ProductTranslation()
                { 
                    Id=2,
                    ProductId = 1,
                    Name = "Viet Tien men's white shirt",
                    LanguageId = "en-US",
                    SeoAlias = "viet-tien-men-white-shirt",
                    SeoDescription = "Viet Tien men's white shirt",
                    SeoTitle = "Viet Tien men's white shirt",
                    Description = "Viet Tien men's white shirt",
                    Details = "Viet Tien men's white shirt"
                }
                );
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory()
                {
                    ProductId=1,
                    CategoryId=1
                }
                );
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "chungjames.international@gmail.com",
                NormalizedEmail = "chungjames.international@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "Chung",
                LastName = "Dang",
                Dob = new DateTime(2023, 11, 20)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
    }
}
