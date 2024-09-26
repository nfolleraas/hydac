using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydac_projekt
{
    public class MeetingRoom
    {
        private string roomName;
        private string size;
        private string roomType;
        public string roomAvailability;


        public static MeetingRoom[] meetingRooms = new MeetingRoom[4];

        // Constructor
        static MeetingRoom()
        {
            meetingRooms[0] = new MeetingRoom { roomName = "Kantine", roomType = "1 til 1", size = "Lille", roomAvailability = "Ikke ledig" };
            meetingRooms[1] = new MeetingRoom { roomName = "Stue", roomType = "Konference", size = "Stor", roomAvailability = "Ledig" };
            meetingRooms[2] = new MeetingRoom { roomName = "Bridge East", roomType = "Mindre konference", size = "Mellem", roomAvailability = "Ledig" };
            meetingRooms[3] = new MeetingRoom { roomName = "Bridge West", roomType = "Mindre konference", size = "Mellem", roomAvailability = "Ledig" };

        }
    }
}
