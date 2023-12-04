using System;
using System.Collections.Generic;

public class Permission
{
    public void GivePermission()
    {
        Console.WriteLine("У вас есть права на эту функциональность");
    }

    public void NoPermission()
    {
        Console.WriteLine("У вас нет прав на эту функциональность");
    }
}


