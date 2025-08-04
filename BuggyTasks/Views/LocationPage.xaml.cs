using Microsoft.Maui.Controls;
using Microsoft.Maui.ApplicationModel;

namespace BuggyTasks.Views;

public partial class LocationPage : ContentPage
{
    public LocationPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _ = GetLocationAsync(); 
    }

    async Task GetLocationAsync()
    {
        try
        {
            LocationLabel.Text = "Getting location...";
            var location = await Geolocation.GetLastKnownLocationAsync(); 
            if (location != null)
            {
                LocationLabel.Text = $"Latitude: {location.Latitude:F6}\nLongitude: {location.Longitude:F6}";
                Console.WriteLine($"Lat: {location.Latitude}, Long: {location.Longitude}");
            }
            else
            {
                LocationLabel.Text = "Location not available";
            }
        }
        catch (Exception ex)
        {
            LocationLabel.Text = $"Error: {ex.Message}";
            Console.WriteLine($"Error getting location: {ex.Message}");
        }
    }

    async void OnRefreshLocation(object sender, EventArgs e)
    {
        await GetLocationAsync();
    }
}