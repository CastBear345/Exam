using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

public class ControlRoomsImages
{
    // Метод для работы с прогрузкой изображений комнат
    public static void ControlRoomImage(Room room)
    {
        if (room.Name is "Гостиная")
        {
            LivingRoom.GetLivingRoom(1, true);
        }
    }
}
