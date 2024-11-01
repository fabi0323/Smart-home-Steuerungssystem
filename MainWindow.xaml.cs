using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Steuerungssystem
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SmartHomeSystem smartHomeSystem = new SmartHomeSystem();

        public MainWindow()
        {
            InitializeComponent();
            LoadSampleData();
            UpdateRoomList();
        }

        private void LoadSampleData()
        {
            // Load some initial sample data for demonstration
            var livingRoom = new Room("Living Room");
            livingRoom.AddDevice(new Light("Ceiling Light"));
            livingRoom.AddDevice(new Heater("Heater"));
            livingRoom.AddDevice(new Blind("Window Blind"));

            var kitchen = new Room("Kitchen");
            kitchen.AddDevice(new Light("Kitchen Light"));

            smartHomeSystem.AddRoom(livingRoom);
            smartHomeSystem.AddRoom(kitchen);
        }

        private void UpdateRoomList()
        {
            RoomListBox.ItemsSource = smartHomeSystem.Rooms.Select(r => r.Name).ToList();
        }

        private void UpdateDeviceList(Room selectedRoom)
        {
            DeviceListBox.ItemsSource = selectedRoom.Devices.Select(d => d.Name).ToList();
        }

        private void OnRoomSelected(object sender, SelectionChangedEventArgs e)
        {
            if (RoomListBox.SelectedItem != null)
            {
                var roomName = RoomListBox.SelectedItem.ToString();
                var selectedRoom = smartHomeSystem.Rooms.FirstOrDefault(r => r.Name == roomName);
                if (selectedRoom != null)
                {
                    UpdateDeviceList(selectedRoom);
                }
            }
        }

        private void OnAddRoomClick(object sender, RoutedEventArgs e)
        {
            var roomName = PromptDialog("Enter Room Name:");
            if (!string.IsNullOrEmpty(roomName))
            {
                var newRoom = new Room(roomName);
                smartHomeSystem.AddRoom(newRoom);
                UpdateRoomList();
            }
        }

        private void OnAddDeviceClick(object sender, RoutedEventArgs e)
        {
            if (RoomListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a room first.");
                return;
            }

            var roomName = RoomListBox.SelectedItem.ToString();
            var selectedRoom = smartHomeSystem.Rooms.FirstOrDefault(r => r.Name == roomName);

            var deviceType = PromptDialog("Enter Device Type (Light, Heater, Blind):");
            var deviceName = PromptDialog("Enter Device Name:");

            if (!string.IsNullOrEmpty(deviceType) && !string.IsNullOrEmpty(deviceName))
            {
                Device device = null;
                if (deviceType == "Light")
                    device = new Light(deviceName);
                else if (deviceType == "Heater")
                    device = new Heater(deviceName);
                else if (deviceType == "Blind")
                    device = new Blind(deviceName);

                if (device != null)
                {
                    selectedRoom.AddDevice(device);
                    UpdateDeviceList(selectedRoom);
                }
                else
                {
                    MessageBox.Show("Invalid device type.");
                }
            }
        }

        // Simple input dialog to get user input (without Microsoft.VisualBasic.Interaction)
        private string PromptDialog(string message)
        {
            var inputDialog = new InputDialog(message);
            if (inputDialog.ShowDialog() == true)
            {
                return inputDialog.Input;
            }
            return null;
        }
    }
}
