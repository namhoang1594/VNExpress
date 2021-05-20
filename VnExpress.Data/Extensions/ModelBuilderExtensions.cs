using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VnExpress.Data.Entities;

namespace VnExpress.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
               new Category()
               {
                   CategoryId = 1,
                   CategoryName = "Văn hóa",
                   Description = "Mo ta"

               },
               new Category()
               {
                   CategoryId = 2,
                   CategoryName = "Xã hội",
                   Description = "Mo ta"
                   

               },
                new Category()
                {
                    CategoryId = 3,
                    CategoryName = "Kinh tế",
                    Description = "Mo ta"
                });
            modelBuilder.Entity<Post>().HasData(
               new Post()
               {
                   Id = 1,
                   Title = "Tình hình kinh tế thế giới",
                   Author = "Hoàng Nam",
                   DateCreated = DateTime.Now.Date,
                   ShortContent = "Tình hình kinh tế châu á",
                   MainContent = "Tình hình kinh tế EU",
                   Images = "Ảnh",
                   CategoryName = "Văn hóa",
                   CategoryId = 1,

               }, new Post()
               {
                   Id = 2,
                   Title = "Tình hình xã hội thế giới",
                   Author = "Tuấn Anh",
                   DateCreated = DateTime.Now.Date,
                   ShortContent = "Tình hình xã hội châu á",
                   MainContent = "Tình hình xã hội EU",
                   Images = "Ảnh",
                   CategoryName = "Xã hội",
                   CategoryId = 2,

               },
               new Post()
               {
                   Id = 3,
                   Title = "Tình hình văn hóa thế giới",
                   Author = "Văn Trung",
                   DateCreated = DateTime.Now.Date,
                   ShortContent = "Tình hình văn hóa châu á",
                   MainContent = "Tình hình văn hóa EU",
                   Images = "Ảnh",
                   CategoryName = "Kinh tế",
                   CategoryId = 3,

               });
        }
    }
}
