namespace ass2.Migrations
{
    using ass2.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ass2.Data.ass2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ass2.Data.ass2Context";
        }

        protected override void Seed(ass2.Data.ass2Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var Cuisine_name = new List<Cuisine>
            {

                new Cuisine { Cuisines = "Zhejiang" },
                new Cuisine {Cuisines = "Sichuan"},
                new Cuisine {Cuisines = "Shandong"},
                new Cuisine {Cuisines = "Guangdong"},
                new Cuisine {Cuisines = "Hunan"},
                new Cuisine {Cuisines = "Fujian"},
                new Cuisine {Cuisines = "Jiangsu"},
                new Cuisine {Cuisines = "Anhui"}
            };
            Cuisine_name.ForEach(c => context.Cuisines.AddOrUpdate(p => p.Cuisines, c));
            context.SaveChanges();
            var Dishes = new List<Dish>
            {
                new Dish {Name = "Boiled cabbage",Taste = "salty",Price = 40,Score = 9,ID=Cuisine_name.Single(c=>c.Cuisines == "Sichuan").Id},
                new Dish {Name = "Fuqi feipian",Taste = "hot",Price = 25,Score = 8,ID=Cuisine_name.Single(c=>c.Cuisines == "Sichuan").Id},
                new Dish {Name = "GongBao chicken",Taste = "hot",Price = 20,Score = 7,ID=Cuisine_name.Single(c=>c.Cuisines == "Sichuan").Id},
                new Dish {Name = "Dongpo joint",Taste = "sweet",Price = 30,Score = 9,ID=Cuisine_name.Single(c=>c.Cuisines == "Sichuan").Id},
                
                new Dish {Name = "Tangcu liji",Taste = "sour",Price = 20,Score = 9,ID=Cuisine_name.Single(c=>c.Cuisines == "Shandong").Id},
                new Dish {Name = "Tangcu fish",Taste = "sour",Price = 30,Score = 7,ID=Cuisine_name.Single(c=>c.Cuisines == "Shandong").Id},
                new Dish {Name = "Yipin toufu",Taste = "salty",Price = 20,Score = 7,ID=Cuisine_name.Single(c=>c.Cuisines == "Shandong").Id},
                new Dish {Name = "Sixi wanzi",Taste = "salty",Price = 30,Score = 8,ID=Cuisine_name.Single(c=>c.Cuisines == "Shandong").Id},

                new Dish {Name = "Baiqie chicken",Taste = "salty",Price = 25,Score = 7,ID=Cuisine_name.Single(c=>c.Cuisines == "Guangdong").Id},
                new Dish {Name = "Hongshao Pigeon",Taste = "salty",Price = 30,Score = 8,ID=Cuisine_name.Single(c=>c.Cuisines == "Guangdong").Id},
                new Dish {Name = "Gulao meat",Taste = "sour",Price = 30,Score = 9,ID=Cuisine_name.Single(c=>c.Cuisines == "Guangdong").Id},
                new Dish {Name = "baizhuo xia",Taste = "salty",Price = 25,Score = 8,ID=Cuisine_name.Single(c=>c.Cuisines == "Guangdong").Id},

                new Dish {Name = "Hongshao meat",Taste = "sweet",Price = 30,Score = 9,ID=Cuisine_name.Single(c=>c.Cuisines =="Jiangsu").Id},
                new Dish {Name = "Yanshui duck",Taste = "salty",Price = 25,Score = 7,ID=Cuisine_name.Single(c=>c.Cuisines =="Jiangsu").Id},
                new Dish {Name = "Xiefen shizitou",Taste = "salty",Price = 35,Score = 8,ID=Cuisine_name.Single(c=>c.Cuisines =="Jiangsu").Id},
                new Dish {Name = "Songshu fish",Taste = "sour",Price = 35,Score = 9,ID=Cuisine_name.Single(c=>c.Cuisines =="Jiangsu").Id},

                new Dish {Name = "Fotiaoqiang",Taste = "salty",Price = 40,Score = 9,ID=Cuisine_name.Single(c=>c.Cuisines =="Fujian").Id},
                new Dish {Name = "Lizhi meat",Taste = "sweet",Price = 25,Score = 8,ID=Cuisine_name.Single(c=>c.Cuisines =="Fujian").Id},
                new Dish {Name = "Haili jian",Taste = "salty",Price = 20,Score = 7,ID=Cuisine_name.Single(c=>c.Cuisines =="Fujian").Id},
                new Dish {Name = "Rou yan",Taste = "salty",Price = 30,Score = 8,ID=Cuisine_name.Single(c=>c.Cuisines =="Fujian").Id},

                new Dish {Name = "Longjing xiaren",Taste = "salty",Price = 30,Score = 7,ID=Cuisine_name.Single(c=>c.Cuisines =="Zhejiang").Id},
                new Dish {Name = "Dongpo meat",Taste = "sweet",Price = 25,Score = 8,ID=Cuisine_name.Single(c=>c.Cuisines =="Zhejiang").Id},
                new Dish {Name = "Heye meat",Taste = "salty",Price = 25,Score = 8,ID=Cuisine_name.Single(c=>c.Cuisines =="Zhejiang").Id},
                new Dish {Name = "Xihu fish",Taste = "sour",Price = 20,Score = 7,ID=Cuisine_name.Single(c=>c.Cuisines =="Zhejiang").Id},

                new Dish {Name = "Duojiao fish",Taste = "hot",Price = 35,Score = 8,ID=Cuisine_name.Single(c=>c.Cuisines =="Hunan").Id},
                new Dish {Name = "Lawei meat",Taste = "sweet",Price = 30,Score = 8,ID=Cuisine_name.Single(c=>c.Cuisines =="Hunan").Id},
                new Dish {Name = "kouwei xia",Taste = "hot",Price = 35,Score = 9,ID=Cuisine_name.Single(c=>c.Cuisines =="Hunan").Id},
                new Dish {Name = "Dongan duck",Taste = "hot",Price = 25,Score = 7,ID=Cuisine_name.Single(c=>c.Cuisines =="Hunan").Id},

                new Dish {Name = "Huizhou duck",Taste = "salty",Price = 25,Score = 7,ID=Cuisine_name.Single(c=>c.Cuisines =="Anhui").Id},
                new Dish {Name = "Zhonghe soup",Taste = "salty",Price = 20,Score = 8,ID=Cuisine_name.Single(c=>c.Cuisines =="Anhui").Id},
                new Dish {Name = "Mizhi hongyu",Taste = "sweet",Price = 20,Score = 7,ID=Cuisine_name.Single(c=>c.Cuisines =="Anhui").Id},
                new Dish {Name = "Lihongzhang zahui",Taste = "salt",Price = 35,Score = 9,ID=Cuisine_name.Single(c=>c.Cuisines =="Anhui").Id},

            };
            Dishes.ForEach(c => context.Dishes.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();
        }
    }
}
