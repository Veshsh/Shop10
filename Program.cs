
using System.Collections.Generic;
using System.Data;

namespace shop10;
class MainClass
{
    const string autmenutext = "Дпвм";
    public const string autcontent = "  Логин: \n  Пароль: \n  Авторизоваться";
    public const string adminmenutext = "Админ CRUD";
    public const string personnelmanagertext = "Менеджер персонала CRUD";
    public const string warehousemanegertext = "Склад Менеджер CRUD";
    public const string bookeepingentrytext = "Бухгалтер  CRUD";
    public const string сashirtext = "Касир ";
    public const string сashircontent = "  Заказ\n  Оформить\n  Сбросить";
    public const string CRUDcontent = "  Create\n  Dlete Нажмите Enter для удаления\n  Read\n  Update";
    public const string CUAcontent = "  ID: \n  Login: \n  Password: \n  roole: \n  Создать\n1-admin\n2-personnelmanager\n3-\n4-\n5-";
    public const string CUPMcontent = "  ID: \n  Surname: \n  Name: \n  Patronymic: \n  Born: \n  Serialnumber: \n  Status: \n  Iduser: \n  Создать";
    public const string CUWMcontent = "  ID: \n  Name: \n  Cost: \n  Count: \n  Создать";
    public const string CUBPcontent = "  ID: \n  Name: \n  Data: \n  Cost: \n  Pluss: \n  Создать";
    const int autlonge = 3;
    const int CRUDlonge = 4;
    public enum keybinds
    {
        Escape = ConsoleKey.Escape,
        Enter = ConsoleKey.Enter
    }
    public static void Main(string[] args)
    {

        List<AutObject> list = Startname.startname();
        Sterealizer.steruser(list, Startname.Users);
        List<EmployeObject> liste = Startname.startnameempoloe();
        Sterealizer.steruser(liste, Startname.Employee);
        List<GoodGodObject> listee = Startname.startnamegod();
        Sterealizer.steruser(listee, Startname.God);
        List<BookeepingentryObject> listeee = Startname.startnamecost();
        Sterealizer.steruser(listeee, Startname.Cost);

        Console.WindowHeight = Console.LargestWindowHeight;
        Console.WindowWidth = Console.LargestWindowWidth;

        bool keepRunning = true;
        Console.WriteLine("Нажмите CTRL+C для входа в магазин");
        Console.CancelKeyPress += delegate (object? sender, ConsoleCancelEventArgs e)
        {
            e.Cancel = true;
            keepRunning = false;
        };
        while (keepRunning) { }
        /*Основная Программа*/
        while (true)
        {
            Auten();
            switch (Aut.role)
            {
                case 1:
                    Admine();
                    break;
                case 2:
                    PersonnelManagere();
                    break;
                case 3:
                    WarehouseManegere();
                    break;
                case 4:
                    Bookeepingentrye();
                    break;
                case 5:
                    Cashire();
                    break;

            }
            Control.YCursorPos = 2;
        }
    }
    static void Auten()
    {
        bool chec = true;
        Console.Clear();
        Menu.Meni(autmenutext, autcontent);
        while (chec)
        {
            Control.ReadKey(autlonge);
            Control.MenuArrow(autlonge);
            if (Control.key.Key == (ConsoleKey)keybinds.Enter)
                chec = Aut.Read(autlonge);
        }
    }
    static void Admine()
    {
        bool chec = true;
        Console.Clear();
        Menu.Meni(warehousemanegertext + ": " + Aut.username, CRUDcontent);
        while (Control.key.Key != (ConsoleKey)keybinds.Escape || chec)
        {
            Control.ReadKey(CRUDlonge);
            Control.MenuArrow(CRUDlonge);
            chec = Admin.CRUDe();
        }
    }
    static void PersonnelManagere()
    {
        bool chec = true;
        Console.Clear();
        Menu.Meni(personnelmanagertext + ": " + Aut.username, CRUDcontent);
        while (Control.key.Key != (ConsoleKey)keybinds.Escape || chec)
        {
            Control.ReadKey(CRUDlonge);
            Control.MenuArrow(CRUDlonge);
            chec = PersonnelManager.CRUDe();
        }
    }
    static void WarehouseManegere()
    {
        bool chec = true;
        Console.Clear();
        Menu.Meni(warehousemanegertext + ": " + Aut.username, CRUDcontent);
        while (Control.key.Key != (ConsoleKey)keybinds.Escape || chec)
        {
            Control.ReadKey(CRUDlonge);
            Control.MenuArrow(CRUDlonge);
            chec = WarehouseManeger.CRUDe();
        }
    }
    static void Bookeepingentrye()
    {
        bool chec = true;
        Console.Clear();
        Menu.Meni(bookeepingentrytext + ": " + Aut.username, CRUDcontent);
        while (Control.key.Key != (ConsoleKey)keybinds.Escape || chec)
        {
            Control.ReadKey(CRUDlonge);
            Control.MenuArrow(CRUDlonge);
            chec = BookeePingentry.CRUDe();
        }
    }
    static void Cashire()
    {
        List<GoodGodObject> checusers = Sterealizer.desteruser<List<GoodGodObject>>(Startname.God);
        foreach (GoodGodObject item in checusers)
            item.count = 0;
        Sterealizer.steruser(checusers, Startname.Bue);
        bool chec = true;
        Console.Clear();
        Menu.Meni(сashirtext + ": " + Aut.username, сashircontent);
        while (Control.key.Key != (ConsoleKey)keybinds.Escape || chec)
        {
            Control.ReadKey(CRUDlonge);
            Control.MenuArrow(CRUDlonge);
            chec=Cashir.Shop();
        }
    }
}