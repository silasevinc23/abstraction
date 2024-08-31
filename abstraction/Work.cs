using abstraction;
using System;

//Düşünün ki bir şirketin çalışanlarını temsil eden bir program yazıyorsunuz.

//Her çalışan için ad, soyad, departman gibi ortak özellikler bulunmaktadır

//Ancak her çalışanın görevi (pozisyonu) farklı olabilir (Örneğin, Yazılım Geliştirici, Proje Yöneticisi, Satış Temsilcisi).

//Gorev metodunu çağırdığımızda her çalışan kendi yaptığı işi konsol ekranında söyleyecek.

//Örneğin

//Hasan Çıldırmış şirketin Proje yönetcisi, kendisi üzerinden Gorev() abstract metodu çağırıldığında konsol ekranında

//" Proje yöneticisi olarak çalışıyorum. " yazdırılmasını istiyoruz.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    public abstract class Work
    {
        public string name {  get; set; }
        public string surname { get; set; }
        public string department { get; set; }
        public string position { get; set; }

         public abstract void Gorev();

    }
}

public class SoftwareEngineer : Work
{
    public override void Gorev()
    {
        Console.WriteLine("I work as a software engineer");
    }
}

public class ProjectManager : Work
{
    public override void Gorev()
    {
        Console.WriteLine("I work as a project manager");
    }
}

public class SalesRepresentative: Work
{
    public override void Gorev()
    {
        Console.WriteLine("I work as a sales representative");
    }
}