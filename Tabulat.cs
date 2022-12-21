using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop10;
class TabulatPersonnelManager
{
    private static int tabulate;
    public static List<EmployeObject> Finde;
    public static string ListUsers(string find,string findteg,string had)
    {
        List<EmployeObject> checusers = Sterealizer.desteruser<List<EmployeObject>>(Startname.Employee);
        Finde =new List<EmployeObject>();
        string listusers="  Поиск: ";
        tabulate = listusers.Length;
        listusers = Format(listusers, had.Split(" ")[0], had);
        listusers = Format(listusers, had.Split(" ")[1], had);
        listusers = Format(listusers, had.Split(" ")[2], had);
        listusers = Format(listusers, had.Split(" ")[3], had);
        listusers = Format(listusers, had.Split(" ")[4], had);
        listusers = Format(listusers, had.Split(" ")[5], had);
        listusers = Format(listusers, had.Split(" ")[6], had);
        listusers = Format(listusers, had.Split(" ")[7], had);
        listusers = Format(listusers, had.Split(" ")[8], had);
        listusers = listusers + "\n";
        tabulate = 0;
        foreach (EmployeObject checuser in checusers)
        {
            switch(findteg)
            {
                case "ID":
                    if(find == checuser.id.ToString())
                listusers = Formats(listusers, checuser, had);
                    break;
                case "Surname":
                    if (find == checuser.surname)
                        listusers = Formats(listusers, checuser, had);
                    break;
                case "Name":
                    if (find == checuser.name)
                        listusers = Formats(listusers, checuser, had);
                    break;
                case "Patronymic":
                    if (find == checuser.patronymic)
                        listusers = Formats(listusers, checuser, had);
                    break;
                case "born":
                    if (find == checuser.born.ToShortDateString())
                        listusers = Formats(listusers, checuser, had);
                    break;
                case "Serialnumber":
                    if (find == checuser.serialnumber.ToString())
                        listusers = Formats(listusers, checuser, had);
                    break;
                case "Status":
                    if (find == checuser.status)
                        listusers = Formats(listusers, checuser, had);
                    break;
                case "Pay":
                    if (find == checuser.pay.ToString())
                        listusers = Formats(listusers, checuser, had);
                    break;
                case "Iduser":
                    if (find == checuser.iduser.ToString())
                        listusers = Formats(listusers, checuser, had);
                    break;
                case null:
                    listusers = Formats(listusers, checuser, had);
                    break;
                default:
                    if(findteg == checuser.id.ToString() || findteg == checuser.surname || findteg == checuser.name || findteg == checuser.patronymic || find == checuser.pay.ToString()
                        || findteg == checuser.born.ToShortDateString() || findteg == checuser.serialnumber.ToString() || findteg == checuser.status || findteg == checuser.iduser.ToString())
                    listusers = Formats(listusers, checuser, had);
                    break;
            }
        }
        return listusers;
    }
    private static string Formats(string listusers, EmployeObject checuser,string had)
    {
        Finde.Add(checuser);
        listusers = Format(listusers, checuser.id.ToString(), had);
        listusers = Format(listusers, checuser.surname, had);
        listusers = Format(listusers, checuser.name, had);
        listusers = Format(listusers, checuser.patronymic, had);
        listusers = Format(listusers, checuser.born.ToShortDateString(), had);
        listusers = Format(listusers, checuser.serialnumber.ToString(), had);
        listusers = Format(listusers, checuser.status, had);
        listusers = Format(listusers, checuser.pay.ToString(), had);
        listusers = Format(listusers, checuser.iduser.ToString(), had);
        listusers = listusers + "\n";
        tabulate = 0;
        return listusers;
    }
    private static string Format(string speaker,string table,string had)
    {
        for (int i = 0; i < Console.WindowWidth / (had.Split(" ").Length + 1) - tabulate; i++)
            speaker = speaker + " ";
        speaker = speaker + table;
        tabulate = table.Length;
        return speaker;
    }
}
class TabulatAdmin 
{
    private static int tabulate;
    public static List<AutObject> Finde;
    public static string ListUsers(string find, string findteg, string had)
    {
        List<AutObject> checusers = Sterealizer.desteruser<List<AutObject>>(Startname.Users);
        Finde = new List<AutObject>();
        string listusers = "  Поиск: ";
        tabulate = listusers.Length;
        listusers = Format(listusers, had.Split(" ")[0], had);
        listusers = Format(listusers, had.Split(" ")[1], had);
        listusers = Format(listusers, had.Split(" ")[2], had);
        listusers = Format(listusers, had.Split(" ")[3], had);
        listusers = listusers + "\n";
        tabulate = 0;
        foreach (AutObject checuser in checusers)
        {
            switch (findteg)
            {
                case "ID":
                    if (find == checuser.id.ToString())
                        listusers = Formats(listusers, checuser, had);
                    break;
                case "Login":
                    if (find == checuser.login)
                        listusers = Formats(listusers, checuser, had);
                    break;
                case "Password":
                    if (find == checuser.password)
                        listusers = Formats(listusers, checuser, had);
                    break;
                case "Role":
                    if (find == checuser.role.ToString())
                        listusers = Formats(listusers, checuser, had);
                    break;
                case null:
                    listusers = Formats(listusers, checuser, had);
                    break;
                default:
                    if (findteg == checuser.id.ToString() || findteg == checuser.login || findteg == checuser.password || findteg == checuser.role.ToString())
                        listusers = Formats(listusers, checuser, had);
                    break;
            }
        }
        return listusers;
    }
    private static string Formats(string listusers, AutObject checuser, string had)
    {
        Finde.Add(checuser);
        listusers = Format(listusers, checuser.id.ToString(), had);
        listusers = Format(listusers, checuser.login, had);
        listusers = Format(listusers, checuser.password, had);
        listusers = Format(listusers, checuser.role.ToString(), had);
        listusers = listusers + "\n";
        tabulate = 0;
        return listusers;
    }
    private static string Format(string speaker, string table, string had)
    {
        for (int i = 0; i < Console.WindowWidth / (had.Split(" ").Length + 1) - tabulate; i++)
            speaker = speaker + " ";
        speaker = speaker + table;
        tabulate = table.Length;
        return speaker;
    }
}
class TabulatWarehouseManeger 
{
    private static int tabulate;
    public static List<GoodGodObject> Finde;
    public static string ListUsers(string find, string findteg, string had)
    {
        List<GoodGodObject> checusers = Sterealizer.desteruser<List<GoodGodObject>>(Startname.God);
        Finde = new List<GoodGodObject>();
        string listusers = "  Поиск: ";
        tabulate = listusers.Length;
        listusers = Format(listusers, had.Split(" ")[0], had);
        listusers = Format(listusers, had.Split(" ")[1], had);
        listusers = Format(listusers, had.Split(" ")[2], had);
        listusers = Format(listusers, had.Split(" ")[3], had);
        listusers = listusers + "\n";
        tabulate = 0;
        foreach (GoodGodObject checuser in checusers)
        {
            switch (findteg)
            {
                case "ID":
                    if (find == checuser.id.ToString())
                        listusers = Formats(listusers, checuser, had);
                    break;
                case "Login":
                    if (find == checuser.name)
                        listusers = Formats(listusers, checuser, had);
                    break;
                case "Password":
                    if (find == checuser.cost.ToString())
                        listusers = Formats(listusers, checuser, had);
                    break;
                case "Role":
                    if (find == checuser.count.ToString())
                        listusers = Formats(listusers, checuser, had);
                    break;
                case null:
                    listusers = Formats(listusers, checuser, had);
                    break;
                default:
                    if (findteg == checuser.name || findteg == checuser.id.ToString()|| findteg == checuser.count.ToString()|| findteg == checuser.cost.ToString())
                        listusers = Formats(listusers, checuser, had);
                    break;
            }
        }
        return listusers;
    }
    private static string Formats(string listusers, GoodGodObject checuser, string had)
    {
        Finde.Add(checuser);
        listusers = Format(listusers, checuser.id.ToString(), had);
        listusers = Format(listusers, checuser.name, had);
        listusers = Format(listusers, checuser.cost.ToString(), had);
        listusers = Format(listusers, checuser.count.ToString(), had);
        listusers = listusers + "\n";
        tabulate = 0;
        return listusers;
    }
    private static string Format(string speaker, string table, string had)
    {
        for (int i = 0; i < Console.WindowWidth / (had.Split(" ").Length + 1) - tabulate; i++)
            speaker = speaker + " ";
        speaker = speaker + table;
        tabulate = table.Length;
        return speaker;
    }
}
class TabulatBookeepingentry
{
    private static int tabulate;
    public static List<BookeepingentryObject> Finde;
    public static string ListUsers(string find, string findteg, string had)
    {
        List<BookeepingentryObject > checusers = Sterealizer.desteruser<List<BookeepingentryObject>>(Startname.Cost);
        Finde = new List<BookeepingentryObject>();
        string listusers = "  Поиск: ";
        tabulate = listusers.Length;
        listusers = Format(listusers, had.Split(" ")[0], had);
        listusers = Format(listusers, had.Split(" ")[1], had);
        listusers = Format(listusers, had.Split(" ")[2], had);
        listusers = Format(listusers, had.Split(" ")[3], had);
        listusers = Format(listusers, had.Split(" ")[4], had);
        listusers = listusers + "\n";
        tabulate = 0;
        int total = 0;
        foreach (BookeepingentryObject checuser in checusers)
        {
            switch (findteg)
            {
                case "ID":
                    if (find == checuser.id.ToString())
                        listusers = Formats(listusers, checuser, had);
                    break;
                case "Name":
                    if (find == checuser.name)
                        listusers = Formats(listusers, checuser, had);
                    break;
                case "Cost":
                    if (find == checuser.cost.ToString())
                        listusers = Formats(listusers, checuser, had);
                    break;
                case "Data":
                    if (find == checuser.data.ToString())
                        listusers = Formats(listusers, checuser, had);
                    break;
                case "Plus":
                    if (find == checuser.plus.ToString())
                        listusers = Formats(listusers, checuser, had);
                    break;
                case null:
                    listusers = Formats(listusers, checuser, had);
                    if (checuser.plus)
                        total += (int)checuser.cost;
                    else
                        total -= (int)checuser.cost;
                    break;
                default:
                    if (findteg == checuser.name || findteg == checuser.id.ToString() || findteg == checuser.data.ToString() || findteg == checuser.cost.ToString() || findteg == checuser.plus.ToString())
                    {
                        listusers = Formats(listusers, checuser, had);
                        if (checuser.plus)
                            total += (int)checuser.cost;
                        else
                            total -= (int)checuser.cost;
                    }
                    break;
            }
        }
        listusers += "Итог: " + total.ToString();
        return listusers;
    }
    private static string Formats(string listusers, BookeepingentryObject checuser, string had)
    {
        Finde.Add(checuser);
        listusers = Format(listusers, checuser.id.ToString(), had);
        listusers = Format(listusers, checuser.name, had);
        listusers = Format(listusers, checuser.cost.ToString(), had);
        listusers = Format(listusers, checuser.data.ToString(), had);
        listusers = Format(listusers, checuser.plus.ToString(), had);
        listusers = listusers + "\n";
        tabulate = 0;
        return listusers;
    }
    private static string Format(string speaker, string table, string had)
    {
        for (int i = 0; i < Console.WindowWidth / (had.Split(" ").Length + 1) - tabulate; i++)
            speaker = speaker + " ";
        speaker = speaker + table;
        tabulate = table.Length;
        return speaker;
    }
}
class TabulatBy 
{
    private static int tabulate;
    public static List<GoodGodObject> Finde;
    public static string ListUsers(string find, string findteg, string had)
    {
        List<GoodGodObject> checusers = Sterealizer.desteruser<List<GoodGodObject>>(Startname.Bue);
        Finde = new List<GoodGodObject>();
        string listusers ="";
        tabulate = listusers.Length;
        listusers = Format(listusers, had.Split(" ")[0], had);
        listusers = Format(listusers, had.Split(" ")[1], had);
        listusers = Format(listusers, had.Split(" ")[2], had);
        listusers = Format(listusers, had.Split(" ")[3], had);
        listusers = listusers + "\n";
        tabulate = 0;
        foreach (GoodGodObject checuser in checusers)
        {
            listusers = Formats(listusers, checuser, had);
        }
        return listusers;
    }
    private static string Formats(string listusers, GoodGodObject checuser, string had)
    {

        Finde.Add(checuser);
        listusers = Format(listusers, checuser.id.ToString(), had);
        listusers = Format(listusers, checuser.name, had);
        listusers = Format(listusers, checuser.cost.ToString(), had);
        listusers = Format(listusers, checuser.count.ToString(), had);
        listusers = listusers + "\n";
        tabulate = 0;
        return listusers;
    }
    private static string Format(string speaker, string table, string had)
    {
        for (int i = 0; i < Console.WindowWidth / (had.Split(" ").Length + 1) - tabulate; i++)
            speaker = speaker + " ";
        speaker = speaker + table;
        tabulate = table.Length;
        return speaker;
    }
}