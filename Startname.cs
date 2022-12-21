using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop10;

internal class Startname
{
    public const string Users = "\\source\\repos\\shop10\\users.json";
    public const string Employee = "\\source\\repos\\shop10\\employee.json";
    public const string God = "\\source\\repos\\shop10\\GodGood.json";
    public const string Cost = "\\source\\repos\\shop10\\BookeePingentry.json";
    public const string Bue = "\\source\\repos\\shop10\\bu.json";
    public static List<BookeepingentryObject> startnamecost()
    {
        BookeepingentryObject user1 = new BookeepingentryObject();
        user1.id = 121;
        user1.name = "sdrre";
        user1.cost = 2;
        user1.data = new DateTime(1212, 12, 12);
        user1.plus=true;
        BookeepingentryObject user2 = new BookeepingentryObject();
        user2.id = 12;
        user2.name = "sudrre";
        user2.cost = 4;
        user2.data= new DateTime(1212, 12, 12);
        user2.plus=true;
        List<BookeepingentryObject> listuser = new List<BookeepingentryObject>();
        listuser.Add(user1);
        listuser.Add(user2);
        return listuser;
    }
    public static List<AutObject> startname()
    {
        AutObject user1 = new AutObject();
        user1.id = 121;
        user1.login = "admin";
        user1.password = " ";
        user1.role = 1;
        AutObject user2 = new AutObject();
        user2.id = 11;
        user2.login = "user1";
        user2.password = " ";
        user2.role = 2;
        AutObject user3 = new AutObject();
        user3.id = 12;
        user3.login = "user2";
        user3.password = " ";
        user3.role = 3;
        AutObject user4 = new AutObject();
        user4.id = 21;
        user4.login = "user3";
        user4.password = " ";
        user4.role = 4;
        AutObject user5 = new AutObject();
        user5.id = 22;
        user5.login = "user4";
        user5.password = " ";
        user5.role = 5;
        List<AutObject> listuser = new List<AutObject>();
        listuser.Add(user1);
        listuser.Add(user2);
        listuser.Add(user3);
        listuser.Add(user4);
        listuser.Add(user5);
        return listuser;
    }
    public static List<EmployeObject> startnameempoloe()
    {
        EmployeObject user1 = new EmployeObject();
        user1.id = 111;
        user1.surname = "Uii";
        user1.name = "Ui";
        user1.patronymic = "Uiii";
        user1.born = new DateTime(1212, 12, 12);
        user1.serialnumber = 1234123456;
        user1.status = "бомж";
        user1.pay = 10;
        user1.iduser = 121;

        EmployeObject user2 = new EmployeObject();
        user2.id = 111;
        user2.surname = "Eii";
        user2.name = "Ei";
        user2.patronymic = "Eiii";
        user2.born = new DateTime(1212, 12, 12);
        user2.serialnumber = 1234123456;
        user2.status = "бомж";
        user2.pay = 2;
        user2.iduser = 11;

        EmployeObject user3 = new EmployeObject();
        user3.id = 111;
        user3.surname = "Eii";
        user3.name = "Ei";
        user3.patronymic = "Eiii";
        user3.born = new DateTime(1212, 12, 12);
        user3.serialnumber = 1234123456;
        user3.status = "бомж";
        user3.pay = 2;
        user3.iduser = 12;

        EmployeObject user4 = new EmployeObject();
        user4.id = 111;
        user4.surname = "Eii";
        user4.name = "Ei";
        user4.patronymic = "Eiii";
        user4.born = new DateTime(1212, 12, 12);
        user4.serialnumber = 1234123456;
        user4.status = "бомж";
        user4.pay = 2;
        user4.iduser = 21;

        EmployeObject user5 = new EmployeObject();
        user5.id = 111;
        user5.surname = "Eii";
        user5.name = "Ei";
        user5.patronymic = "Eiii";
        user5.born = new DateTime(1212, 12, 12);
        user5.serialnumber = 1234123456;
        user5.status = "бомж";
        user5.pay = 2;
        user5.iduser = 22;
        List<EmployeObject> listuser = new List<EmployeObject>();
        listuser.Add(user1);
        listuser.Add(user2);
        listuser.Add(user3);
        listuser.Add(user4);
        listuser.Add(user5);
        return listuser;
    }
    public static List<GoodGodObject> startnamegod()
    {
        GoodGodObject user1 = new GoodGodObject();
        user1.id = 121;
        user1.name = "sd";
        user1.cost = 2;
        user1.count = 1;
        GoodGodObject user2 = new GoodGodObject();
        user2.id = 12;
        user2.name = "sud";
        user2.cost = 4;
        user2.count = 6;
        List<GoodGodObject> listuser = new List<GoodGodObject>();
        listuser.Add(user1);
        listuser.Add(user2);
        return listuser;
    }
}
