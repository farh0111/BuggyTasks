using Microsoft.Maui.Controls;

namespace BuggyTasks;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        // Register all routes
        Routing.RegisterRoute("NewTaskPage", typeof(Views.NewTaskPage));
        Routing.RegisterRoute("tasklist", typeof(Views.TaskListPage));
        Routing.RegisterRoute("location", typeof(Views.LocationPage));
        Routing.RegisterRoute("deviceinfo", typeof(Views.DeviceInfoPage));
    }
}