using Entityfr.Data.DAL;
using Entityfr.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Entityfr
{
    class Program
    {
        static void Main(string[] args)
        {
            StadionDbContest stadionDbContest = new StadionDbContest();
            bool check = true;
            do
            {
                Console.WriteLine("1.Stadium Elave et");
                Console.WriteLine("2.Stadiuma Bax ");
                Console.WriteLine("3.Id-ye gore Stadiuma bax");
                Console.WriteLine("4.Id-ye gore Stadiuma sil");
                Console.WriteLine("0.Proqrami bitir");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Adi daxil et");
                        string name = Console.ReadLine();
                        Console.WriteLine("Saatliq pulu daxil et");
                        int hourlyPrice = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Capacity  daxil et");
                        int capacity = Convert.ToInt32(Console.ReadLine());

                        Stadion stadions = new Stadion()
                        {

                            Name = name,
                            Hourlyprice = hourlyPrice,
                            Capacity = capacity
                        };
                        stadionDbContest.Stadions.Add(stadions);
                        stadionDbContest.SaveChanges();
                        break;
                    case "2":
                        List<Stadion> list = stadionDbContest.Stadions.ToList();
                        foreach(var item in list)
                        {
                            Console.WriteLine($"{item.Id} {item.Name}  {item.Capacity}  {item.Hourlyprice}");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Id daxil et daxil et");
                        int id = Convert.ToInt32(Console.ReadLine());
                        var stadion1 = stadionDbContest.Stadions.Find(id);
                        Console.WriteLine(stadion1.Name + " " +stadion1.Hourlyprice );
                        break;
                    case "4":
                        Console.WriteLine("Id daxil et daxil et");
                        int idDel = Convert.ToInt32(Console.ReadLine());
                        var stadion2 = stadionDbContest.Stadions.Where(x => x.Id == idDel).FirstOrDefault();
                        stadionDbContest.Stadions.Remove(stadion2);
                        stadionDbContest.SaveChanges();
                        break;
                    case "5":
                        Console.WriteLine("Fullnameni daxil edin");
                        string fullname = Console.ReadLine();
                        Console.WriteLine("Emailinizi daxil edin");
                        string email = Console.ReadLine();
                        User users = new User()
                        {
                            FullName = fullname,
                            Email = email


                        };
                        stadionDbContest.Users.Add(users);
                        stadionDbContest.SaveChanges();
                        break;
                    case "6":
                        List<User> userList = stadionDbContest.Users.ToList();
                        foreach(var item in userList)
                        {
                            Console.WriteLine(item.FullName + " " + item.Email);
                        }
                        break;
                    


                    case "0":
                        check = false;
                        break;



                    default:
                        Console.WriteLine("Dogru secim edin");
                        break;
                }
            } while (check);
        }
    }
}
