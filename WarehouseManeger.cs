using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop10;

internal class WarehouseManeger : CRUD
{
    const string readmenutext = "Склад Менеджер Read";
    const string createmenutext = "Склад Менеджер Create";
    const string updatemenutext = "Склад Менеджер Update";
    public static GoodGodObject ChoseUser = null;
    private static int ChoseUserpos;
    private static int ChoseUserposDelit = -1;
    private const string hadtabulate = "ID Name Cost Count";

    public static bool CRUDe()
    {
        if (Control.key.Key == (ConsoleKey)MainClass.keybinds.Enter)
            switch (Control.YCursorPos - 1)
            {
                case 1:
                    Create();
                    Control.YCursorPos = 2;
                    return true;
                case 2:
                    if (ChoseUser != null)
                        Dlete();
                    return true;
                case 3:
                    Read();
                    Control.YCursorPos = 2;
                    return true;
                case 4:
                    if (ChoseUser != null)
                        Update();
                    Control.YCursorPos = 2;
                    return true;
            }
        return false;
    }
    private static void Create()
    {
        Console.Clear();
        Menu.Meni(createmenutext + ": " + Aut.username, MainClass.CUWMcontent);
        GoodGodObject newe = new GoodGodObject();
        while (Control.key.Key != (ConsoleKey)MainClass.keybinds.Escape)
        {
           ChoseUserpos = Menu.MenuCUWM(newe, ChoseUserpos, false);//false Create
        }
        Console.Clear();
        Menu.Meni(MainClass.warehousemanegertext + ": " + Aut.username, MainClass.CRUDcontent);
    }
    private static void Dlete()
    {

        if (Control.key.Key == (ConsoleKey)MainClass.keybinds.Enter && ChoseUserposDelit != ChoseUserpos)
        {
            List<GoodGodObject> checusers = Sterealizer.desteruser<List<GoodGodObject>>(Startname.God);
            checusers.RemoveAt(ChoseUserpos);
            ChoseUserposDelit = ChoseUserpos;
            Sterealizer.steruser(checusers, Startname.God);
        }
    }
    private static void Read()
    {
        string find = null;
        string findteg = null;
        string text = null;
        Console.Clear();
        Menu.Meni(readmenutext + ": " + Aut.username, TabulatWarehouseManeger.ListUsers(find, findteg, hadtabulate));
        while (Control.key.Key != (ConsoleKey)MainClass.keybinds.Escape)
        {
            Control.ReadKey(TabulatWarehouseManeger.Finde.Count + 1);
            Control.MenuArrow(TabulatWarehouseManeger.Finde.Count + 1);
            if (Control.key.Key == (ConsoleKey)MainClass.keybinds.Enter && Control.YCursorPos - 2 != 0)
            {
                ChoseUser = TabulatWarehouseManeger.Finde[Control.YCursorPos - 3];
                ChoseUserpos = Control.YCursorPos - 3;
            }
            else if (Control.key.Key == (ConsoleKey)MainClass.keybinds.Enter && Control.YCursorPos - 2 == 0)
            {
                Console.SetCursorPosition(9, Control.YCursorPos);
                text = Console.ReadLine();
                findteg = text.Split(": ")[0];
                if (text.Split(": ").Length == 2)
                    find = text.Split(": ")[1];
                Console.Clear();
                Menu.Meni(readmenutext + ": " + Aut.username, TabulatWarehouseManeger.ListUsers(find, findteg, hadtabulate));
            }
        }
        Console.Clear();
        Menu.Meni(MainClass.warehousemanegertext + ": " + Aut.username, MainClass.CRUDcontent);
    }
    private static void Update()
    {

        Console.Clear();
        Menu.Meni(updatemenutext + ": " + Aut.username, MainClass.CUWMcontent);
        GoodGodObject newe = new GoodGodObject();
        while (Control.key.Key != (ConsoleKey)MainClass.keybinds.Escape)
        {
            ChoseUserpos = Menu.MenuCUWM(newe, ChoseUserpos, true);//true Update
        }
        Console.Clear();
        Menu.Meni(MainClass.warehousemanegertext + ": " + Aut.username, MainClass.CRUDcontent);
    }
}

