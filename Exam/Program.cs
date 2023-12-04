using System;
using System.Collections.Generic;
using System.Net.Mail;

public class Program
{
    public static void Main()
    {
        // Menu.Start();
        Kitchen.GetKitchen(1,true);
        ChildrensRoom.GetChildrensRoom(1,true);
        BathRoom.GetBathRoom(1,true);
        BadRoom.GetBedRoom(1,true);



        Console.ReadKey();
    }
}