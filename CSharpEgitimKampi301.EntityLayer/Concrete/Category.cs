using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }
    }
}

/*
 Field-Variable-Property
 */

/*
 int x; --> Field bir değişken direkt sınıfın içine tanımlanırsa bu field
 
public int y {get; set;} eğer sonuna get ve set alırsa bu property

bir metod içinde tanımlanırsa variable
void test()
{
    int z;
}
 */

//CodeFirst yaklaşımında değerler veritabanına gönderilirken bunların Property olarak gönderilmesi gerekir