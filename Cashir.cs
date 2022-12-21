using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace shop10;

internal class Cashir
{
    const string readmenutext = "Касса";
    private const string hadtabulate = "ID Name Cost Count";
    private static int ChoseUserpos;
    public static bool Shop()
    {
        if (Control.key.Key == (ConsoleKey)MainClass.keybinds.Enter)
            switch (Control.YCursorPos - 1)
            {
                case 1:
                    Warehouse();
                    Control.YCursorPos = 2;
                    return true;
                case 2:
                    Control.YCursorPos = 2;
                    Chec();
                    return true;
                case 3:
                    List<GoodGodObject> checusers = Sterealizer.desteruser<List<GoodGodObject>>(Startname.God);
                    foreach (GoodGodObject item in checusers)
                        item.count = 0;
                    Sterealizer.steruser(checusers, Startname.Bue);
                    return true;
            }
        return false;
    }
    private static void Warehouse()
    {
        string find = null;
        string findteg = null;
        string text = null;
        Console.Clear();
        Menu.Meni(readmenutext + ": " + Aut.username, TabulatBy.ListUsers(find, findteg, hadtabulate));
        while (Control.key.Key != (ConsoleKey)MainClass.keybinds.Escape)
        {

            Control.ReadKey(TabulatBy.Finde.Count + 1);
            Control.MenuArrow(TabulatBy.Finde.Count + 1);
            if (Control.key.Key == (ConsoleKey)MainClass.keybinds.Enter && Control.YCursorPos - 2 != 0)
            {
                ChoseUserpos = Control.YCursorPos - 3;
            }
            else if ((Control.key.Key ==ConsoleKey.LeftArrow || Control.key.Key == ConsoleKey.RightArrow) && Control.YCursorPos - 2 != 0)
            {
                List<GoodGodObject> checusers = Sterealizer.desteruser<List<GoodGodObject>>(Startname.God);
                List<GoodGodObject> checuserse = Sterealizer.desteruser<List<GoodGodObject>>(Startname.Bue);
                switch (Control.key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if(checuserse[ChoseUserpos].count>0)
                        checuserse[ChoseUserpos].count--;
                    break;
                    case ConsoleKey.RightArrow:
                        if (checuserse[ChoseUserpos].count < checusers[ChoseUserpos].count)
                            checuserse[ChoseUserpos].count++;
                    break;
                }
                Sterealizer.steruser(checuserse,Startname.Bue);
                Menu.Meni(readmenutext + ": " + Aut.username, TabulatBy.ListUsers(find, findteg, hadtabulate));
            }
        }
        Console.Clear();
        Menu.Meni(MainClass.сashirtext + ": " + Aut.username, MainClass.сashircontent);
    }
    private static void Chec()
    {
        List<GoodGodObject> checusers = Sterealizer.desteruser<List<GoodGodObject>>(Startname.Bue);
        List<GoodGodObject> checusersee = Sterealizer.desteruser<List<GoodGodObject>>(Startname.God);
        List<BookeepingentryObject> bookee = Sterealizer.desteruser<List<BookeepingentryObject>>(Startname.Cost);
        while (Control.key.Key != (ConsoleKey)MainClass.keybinds.Escape)
        {
            Console.Clear();
                Console.WriteLine("чек:");
            uint total = 0;
            for (int i = 0; i < checusers.Count; i++)

                if (checusers[i].count == 0)
                    checusers.RemoveAt(i);
                else
                {
                    Console.WriteLine(checusers[i].name + " " + checusers[i].cost + "руб. " + checusers[i].count + "шт. " + Convert.ToString(checusers[i].count * checusers[i].cost) + "руб. Всего");
                    total += checusers[i].count * checusers[i].cost;
                }
            Console.WriteLine("Итог: "+total);
            BookeepingentryObject newe = new BookeepingentryObject();
            newe.id = 1;
            newe.name = "buy";
            newe.cost = total;
            newe.data = DateTime.Now;
            newe.plus = true;
            bookee.Add(newe);
            Control.ReadKey(0);
        }
        for (int i = 0; i < checusers.Count; i++)
            checusersee[i].count-=checusers[i].count;
        Sterealizer.steruser(checusersee, Startname.God);
        Sterealizer.steruser(checusers, Startname.Bue);
        Sterealizer.steruser(bookee, Startname.Cost);
        Console.Clear();
        Menu.Meni(MainClass.сashirtext + ": " + Aut.username, MainClass.сashircontent);
    }
}
