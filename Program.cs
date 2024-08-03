

using AbstractionPractice;

public class Program
{
    public static void Main(string[] args)
    {

        Company salesman = new Salesman();
        salesman.Mission();

        Console.WriteLine("---------------------");


        Company projectmanager = new ProjectManager();
        projectmanager.Mission();

        Console.WriteLine("----------------");

        Company softwaredev = new SoftWareDeveloper();
        softwaredev.Mission();


    }




}
