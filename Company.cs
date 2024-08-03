using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionPractice
{
    public abstract class Company
    {
        //Her çalışan için ad, soyad, departman gibi ortak özellikler bulunmaktadır
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Department { get; set; }

        //Ancak her çalışanın görevi (pozisyonu)
        //farklı olabilir (Örneğin, Yazılım Geliştirici, Proje Yöneticisi, Satış Temsilcisi).
        public virtual string? title => "Line Collegue";

        //Gorev metodunu çağırdığımızda her çalışan kendi yaptığı işi konsol ekranında söyleyecek.
        public abstract void Mission();

    }

    public class SoftWareDeveloper : Company
    {
        public override string? title => "Software Developer";

        public override void Mission()
        {
            Console.WriteLine($" I work as a {title} ");
        }


    }


    public class ProjectManager : Company
    {
        public override string? title => "Project Manager";

        public override void Mission()
        {
            Console.WriteLine($" I work as a {title} ");
        }


    }



    public class Salesman: Company
    {

        public override string? title => "Salesman";

        public override void Mission()
        {
            Console.WriteLine($" I work as a {title} ");
        }


    }




















}
