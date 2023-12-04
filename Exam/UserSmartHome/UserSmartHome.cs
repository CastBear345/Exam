using System;
using System.Globalization;
using System.IO;

public class UserSmartHome
{
    public bool PassageToChildrenRoom { get; set; } = true;

    public bool PassageToKitchen { get; set; } = true;

    public bool PassageToBathroom { get; set; } = true;

    public bool PassageToBadroom { get; set; } = true;

    public bool PassageToLivingRoom { get; set; } = true;

    public bool Bathe { get; set; } = true;

    public bool FlushToilet { get; set; } = true;
}