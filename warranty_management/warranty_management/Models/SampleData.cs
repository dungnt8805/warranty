using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace warranty_management.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<WarrantyManagementEntities>
    {
        protected override void Seed(WarrantyManagementEntities context)
        {
            var species = new List<Specie>
                              {
                                  new Specie{Name = "Điện thoại"},
                                  new Specie{Name = "Máy ảnh"},
                                  new Specie{Name = "Tivi"},
                                  new Specie{Name = "Máy quay"},
                                  new Specie{Name = "Laptop"},
                                  new Specie{Name = "Máy tính"},
                                  new Specie{Name = "Máy tính bảng"}
                              };
            var manufacturers = new List<Manufacturer>
                                    {
                                        new Manufacturer {Name = "Apple"},
                                        new Manufacturer {Name = "Samsung"},
                                        new Manufacturer {Name = "Dell"},
                                        new Manufacturer {Name = "Asus"},
                                        new Manufacturer {Name = "Sony"},
                                        new Manufacturer {Name = "HTC"},
                                        new Manufacturer {Name = "HP"},
                                        new Manufacturer {Name = "Toshiba"},
                                        new Manufacturer {Name = "Acer"},
                                        new Manufacturer {Name = "Panasonic"},
                                        new Manufacturer {Name = "Canon"},
                                        new Manufacturer {Name = "Nikon"},
                                        new Manufacturer {Name = "Nokia"},
                                        new Manufacturer {Name = "Blackberry"},
                                        new Manufacturer {Name = "LG"},
                                        new Manufacturer {Name = "Hitachi"},

                                    };
            new List<Production>
                {
                    new Production{Name = "Iphone 6", Manufacturer = manufacturers.Single(g=>g.Name=="Apple"),Specie = species.Single(g=>g.Name=="Điện thoại"),Description = "Đây là chiếc điện thoại Iphone 6",WarrantyTime = 1,WarrantyType = "new"},
                    new Production{Name = "Iphone 6+", Manufacturer = manufacturers.Single(g=>g.Name=="Apple"),Specie = species.Single(g=>g.Name=="Điện thoại"),Description = "Đây là chiếc điện thoại Iphone 6+",WarrantyTime = 1,WarrantyType = "new"},
                    new Production{Name = "Iphone 5", Manufacturer = manufacturers.Single(g=>g.Name=="Apple"),Specie = species.Single(g=>g.Name=="Điện thoại"),Description = "Đây là chiếc điện thoại Iphone 5",WarrantyTime = 1,WarrantyType = "new"},
                    new Production{Name = "Iphone 5s", Manufacturer = manufacturers.Single(g=>g.Name=="Apple"),Specie = species.Single(g=>g.Name=="Điện thoại"),Description = "Đây là chiếc điện thoại Iphone 5s",WarrantyTime = 1,WarrantyType = "new"},
                    new Production{Name = "Iphone 5c", Manufacturer = manufacturers.Single(g=>g.Name=="Apple"),Specie = species.Single(g=>g.Name=="Điện thoại"),Description = "Đây là chiếc điện thoại Iphone 5c",WarrantyTime = 1,WarrantyType = "new"},
                    new Production{Name = "Iphone 4s", Manufacturer = manufacturers.Single(g=>g.Name=="Apple"),Specie = species.Single(g=>g.Name=="Điện thoại"),Description = "Đây là chiếc điện thoại Iphone 4s",WarrantyTime = 1,WarrantyType = "new"},
                    new Production{Name = "Galaxy Note 4", Manufacturer = manufacturers.Single(g=>g.Name=="Samsung"),Specie = species.Single(g=>g.Name=="Điện thoại"),Description = "Đây là chiếc điện thoại Galaxy Note",WarrantyTime = 1,WarrantyType = "repair"},
                    new Production{Name = "Galaxy Note 3", Manufacturer = manufacturers.Single(g=>g.Name=="Samsung"),Specie = species.Single(g=>g.Name=="Điện thoại"),Description = "Đây là chiếc điện thoại Galaxy Note",WarrantyTime = 1,WarrantyType = "repair"},
                    new Production{Name = "Galaxy Note 2", Manufacturer = manufacturers.Single(g=>g.Name=="Samsung"),Specie = species.Single(g=>g.Name=="Điện thoại"),Description = "Đây là chiếc điện thoại Galaxy Note",WarrantyTime = 1,WarrantyType = "repair"},
                    new Production{Name = "Galaxy Note", Manufacturer = manufacturers.Single(g=>g.Name=="Samsung"),Specie = species.Single(g=>g.Name=="Điện thoại"),Description = "Đây là chiếc điện thoại Galaxy Note",WarrantyTime = 1,WarrantyType = "repair"},
                    new Production{Name = "Galaxy S5", Manufacturer = manufacturers.Single(g=>g.Name=="Samsung"),Specie = species.Single(g=>g.Name=="Điện thoại"),Description = "Đây là chiếc điện thoại Galaxy",WarrantyTime = 1,WarrantyType = "repair"},
                    new Production{Name = "Galaxy S4", Manufacturer = manufacturers.Single(g=>g.Name=="Samsung"),Specie = species.Single(g=>g.Name=="Điện thoại"),Description = "Đây là chiếc điện thoại Galaxy",WarrantyTime = 1,WarrantyType = "repair"},
                    new Production{Name = "Galaxy S3", Manufacturer = manufacturers.Single(g=>g.Name=="Samsung"),Specie = species.Single(g=>g.Name=="Điện thoại"),Description = "Đây là chiếc điện thoại Galaxy",WarrantyTime = 1,WarrantyType = "repair"},
                    new Production{Name = "Galaxy S2", Manufacturer = manufacturers.Single(g=>g.Name=="Samsung"),Specie = species.Single(g=>g.Name=="Điện thoại"),Description = "Đây là chiếc điện thoại Galaxy",WarrantyTime = 1,WarrantyType = "repair"},
                    new Production{Name = "Galaxy S", Manufacturer = manufacturers.Single(g=>g.Name=="Samsung"),Specie = species.Single(g=>g.Name=="Điện thoại"),Description = "Đây là chiếc điện thoại Galaxy",WarrantyTime = 1,WarrantyType = "repair"},
                    new Production{Name = "HTC One M1", Manufacturer = manufacturers.Single(g=>g.Name=="HTC"),Specie = species.Single(g=>g.Name=="Điện thoại"),Description = "Đây là chiếc điện thoại HTC One",WarrantyTime = 1,WarrantyType = "repair"},
                    new Production{Name = "HTC One M2", Manufacturer = manufacturers.Single(g=>g.Name=="HTC"),Specie = species.Single(g=>g.Name=="Điện thoại"),Description = "Đây là chiếc điện thoại HTC One",WarrantyTime = 1,WarrantyType = "repair"},
                    new Production{Name = "HTC One M3", Manufacturer = manufacturers.Single(g=>g.Name=="HTC"),Specie = species.Single(g=>g.Name=="Điện thoại"),Description = "Đây là chiếc điện thoại HTC One",WarrantyTime = 1,WarrantyType = "repair"},
                    new Production{Name = "HTC One M4", Manufacturer = manufacturers.Single(g=>g.Name=="HTC"),Specie = species.Single(g=>g.Name=="Điện thoại"),Description = "Đây là chiếc điện thoại HTC One",WarrantyTime = 1,WarrantyType = "repair"},
                    new Production{Name = "Toshiba L808", Manufacturer = manufacturers.Single(g=>g.Name=="Toshiba"),Specie = species.Single(g=>g.Name=="Laptop"),Description = "Máy tính xách tay",WarrantyTime = 1,WarrantyType = "repair"},
                    new Production{Name = "Toshiba L809", Manufacturer = manufacturers.Single(g=>g.Name=="Toshiba"),Specie = species.Single(g=>g.Name=="Laptop"),Description = "Máy tính xách tay",WarrantyTime = 1,WarrantyType = "repair"},
                    new Production{Name = "Toshiba S505", Manufacturer = manufacturers.Single(g=>g.Name=="Toshiba"),Specie = species.Single(g=>g.Name=="Laptop"),Description = "Máy tính xách tay",WarrantyTime = 1,WarrantyType = "repair"},
                    new Production{Name = "Toshiba S504", Manufacturer = manufacturers.Single(g=>g.Name=="Toshiba"),Specie = species.Single(g=>g.Name=="Laptop"),Description = "Máy tính xách tay",WarrantyTime = 1,WarrantyType = "repair"},
                    new Production{Name = "Toshiba S500", Manufacturer = manufacturers.Single(g=>g.Name=="Toshiba"),Specie = species.Single(g=>g.Name=="Laptop"),Description = "Máy tính xách tay",WarrantyTime = 1,WarrantyType = "repair"},
                }.ForEach(a => context.Productions.Add(a));
        }
    }
}