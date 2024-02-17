// See https://aka.ms/new-console-template for more information


using LinqProject.Business.Concretes;
using LinqProject.DataAccess.Concretes;
using LinqProject.Entities.Concretes;



ProductManager productManager = new ProductManager(new ProductDal());

foreach(Product product in productManager.GetAll())
{
    Console.WriteLine(product.Name);
}

Console.WriteLine("-----------------Ekleme-----------------------");

Product product1 = new Product(6, 1, "Monster Abra Notebook", "32 GB RAM", 50000, 4);
productManager.Add(product1);

foreach (Product product in productManager.GetAll())
{
    Console.WriteLine($"Ürün adı:{product.Name}\nÜrün açıklaması:{product.Description}\n");
}

Console.WriteLine("-----------------Silme-----------------------");

productManager.Delete(1);

foreach (Product product in productManager.GetAll())
{
    Console.WriteLine($"Ürün adı:{product.Name}\nÜrün açıklaması:{product.Description}\n");
}

Console.WriteLine("-----------------Güncelleme-----------------------");

Product updatedProduct = new Product(6, 1, "Monster Abra Notebook", "32 GB RAM | 1TB SSD", 55000, 3);

productManager.Update(updatedProduct);

foreach (Product product in productManager.GetAll())
{
    Console.WriteLine($"Ürün adı:{product.Name}\nÜrün açıklaması:{product.Description}\n");
}
