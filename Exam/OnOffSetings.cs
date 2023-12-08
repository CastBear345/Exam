using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    internal class OnOffSetings
    {
        public static int index {  get; set; }

        public static int ReadNumber(string inputMessage)
        {
            Console.WriteLine(inputMessage);
            string value = Console.ReadLine();
            if (int.TryParse(value, out int number))
            {
                return number;
            }

            Console.WriteLine("huinya davai po novoy");
            return ReadNumber(inputMessage);
        }

        public static void RoomIndex(int index)
        {
            if (index == 1)
            {
                LivingRoom.GetLivingRoom();
            }
            else if (index == 2)
            {
                Kitchen.GetKitchen();
            }
            else if (index == 3)
            {
                ChildrensRoom.GetChildrensRoom();
            }
            else if (index == 4)
            {
                BathRoom.GetBathRoom();
            }
            else if (index == 5)
            {
                BedRoom.GetBedRoom();
            }
        }
        public static void HuiZnaet(int room, int device, Action Back)
        {
           RoomIndex(room);

            do {
                int num = OnOffSetings.ReadNumber("* ведите 1 для включения\n" + "* ведите 2 для выключения\n" + "* ведите 3 для возврата в предыдущее меню\n");
                Console.Clear();
                bool set = true;
                if (num == 1)
                {
                    if (room == 1)
                    {
                        LivingRoom.GetLivingRoom(device, set);
                    } else if (room == 2)
                    {
                        Kitchen.GetKitchen(device, set);
                    } else if (room == 3)
                    {
                        ChildrensRoom.GetChildrensRoom(device, set);
                    } else if (room == 4)
                    {
                        BathRoom.GetBathRoom(device, set);
                    } else if (room == 5)
                    {
                        BedRoom.GetBedRoom(device, set);
                    }
                    
                }
                else if (num == 2)
                {
                    set = false;
                    if (room == 1)
                    {
                    
                        LivingRoom.GetLivingRoom(device, set);
                        
                    }
                    else if (room == 2)
                    {
                        Kitchen.GetKitchen(device, set);
                    }
                    else if (room == 3)
                    {
                        ChildrensRoom.GetChildrensRoom(device, set);
                    }
                    else if (room == 4)
                    {
                        BathRoom.GetBathRoom(device, set);
                    }
                    else if (room == 5)
                    {
                        BedRoom.GetBedRoom(device, set);
                    }

                   

                } else if (num == 3)
                {
                    Back();
                   
                }
            } while (room == 3);
            Console.Clear();
           Back();


        }

        public static void HuiZnaet(int room, int device, bool bide, Action Back)
        {
            RoomIndex(room);

            do
            {
                int num = OnOffSetings.ReadNumber("* ведите 1 для включения\n" + "* ведите 2 для выключения\n" + "* ведите 3 для возврата в предыдущее меню\n");
                Console.Clear();
                bool set = true;
                if (num == 1)
                {
                    if (room == 1)
                    {
                        LivingRoom.GetLivingRoom(device, set);
                    }
                    else if (room == 2)
                    {
                        Kitchen.GetKitchen(device, set);
                    }
                    else if (room == 3)
                    {
                        ChildrensRoom.GetChildrensRoom(device, set);
                    }
                    else if (room == 4)
                    {
                        BathRoom.GetBathRoom(device, set, bide);
                    }
                    else if (room == 5)
                    {
                        BedRoom.GetBedRoom(device, set);
                    }

                }
                else if (num == 2)
                {
                    set = false;
                    if (room == 1)
                    {

                        LivingRoom.GetLivingRoom(device, set);

                    }
                    else if (room == 2)
                    {
                        Kitchen.GetKitchen(device, set);
                    }
                    else if (room == 3)
                    {
                        ChildrensRoom.GetChildrensRoom(device, set);
                    }
                    else if (room == 4)
                    {
                        BathRoom.GetBathRoom(device, set, bide);
                    }
                    else if (room == 5)
                    {
                        BedRoom.GetBedRoom(device, set);
                    }



                }
                else if (num == 3)
                {
                    Back();

                }
            } while (room == 3);
            Console.Clear();
            Back();


        }

    }
}
