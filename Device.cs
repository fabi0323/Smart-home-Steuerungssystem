using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steuerungssystem
{
    public abstract class Device
    {
        public string Name { get; set; }
        public Device(string name) => Name = name;
    }

    public class Light : Device
    {
        public bool IsOn { get; set; }
        public Light(string name) : base(name) { }
    }

    public class Heater : Device
    {
        public int Temperature { get; set; }
        public Heater(string name) : base(name) { }
    }

    public class Blind : Device
    {
        public int Position { get; set; }
        public Blind(string name) : base(name) { }
    }

    public class Room
    {
        public string Name { get; set; }
        public List<Device> Devices { get; } = new List<Device>();

        public Room(string name) => Name = name;
        public void AddDevice(Device device) => Devices.Add(device);
    }

    public class SmartHomeSystem
    {
        public List<Room> Rooms { get; } = new List<Room>();

        public void AddRoom(Room room) => Rooms.Add(room);
    }
}
