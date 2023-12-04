using System;

public class UserFather : UserSmartHome
{
    public bool ChangePassword { get; set; } = true;

    public bool ControlBrightness { get; set; } = true;

    public bool ControlTemperature { get; set; } = true;

    public bool ControlColor { get; set; } = true;

    public bool IncludeMovie { get; set; } = true;

    public bool IncludeGame { get; set; } = true;
}