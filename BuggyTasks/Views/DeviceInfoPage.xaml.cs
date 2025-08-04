using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices;

namespace BuggyTasks.Views;

public partial class DeviceInfoPage : ContentPage
{
    public DeviceInfoPage()
    {
        InitializeComponent();
        DisplayDeviceInfo();
    }

    void DisplayDeviceInfo()
    {
        ModelLabel.Text = $"Model: {DeviceInfo.Model}";
        PlatformLabel.Text = $"Platform: {DeviceInfo.Platform}";
        VersionLabel.Text = $"Version: {DeviceInfo.Version}";
    }
}