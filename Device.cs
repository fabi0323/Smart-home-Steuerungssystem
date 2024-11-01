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

        public Device(string name)
        {
            Name = name;
        }

        public abstract void Operate();
    }

    public class Light : Device
    {
        public bool IsOn { get; private set; }

        public Light(string name) : base(name) { }

        public void TurnOn() => IsOn = true;
        public void TurnOff() => IsOn = false;

        public override void Operate()
        {
            IsOn = !IsOn;
            Console.WriteLine($"{Name} light is now {(IsOn ? "On" : "Off")}");
        }
    }

    public class Heater : Device
    {
        public int Temperature { get; private set; }

        public Heater(string name) : base(name) { }

        public void SetTemperature(int temperature) => Temperature = temperature;

        public override void Operate()
        {
            Console.WriteLine($"{Name} heater is set to {Temperature}°C");
        }
    }

    public class Shutter : Device
    {
        public bool IsOpen { get; private set; }

        public Shutter(string name) : base(name) { }

        public void Open() => IsOpen = true;
        public void Close() => IsOpen = false;

        public override void Operate()
        {
            IsOpen = !IsOpen;
            Console.WriteLine($"{Name} shutter is now {(IsOpen ? "Open" : "Closed")}");
        }
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
