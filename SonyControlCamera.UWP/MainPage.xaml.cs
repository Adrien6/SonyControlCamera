using SonyControlCamera.DeviceDiscovery;
using SonyControlCamera.RemoteApi.Camera;
using System;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SonyControlCamera.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public SsdpDiscovery Discovery = new SsdpDiscovery();

        public MainPage()
        {
            this.InitializeComponent();

            Discovery.SonyCameraDeviceDiscovered += SonyDeviceFound;
        }

        public void SonyDeviceFound(object sender, SonyCameraDeviceEventArgs e)
        {
            var endpoints = e.SonyCameraDevice.Endpoints; // Dictionary of each service name and endpoint.
            Uri uri = new Uri(endpoints["camera"]);
            var camera = new CameraApiClient(uri);
        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Discovery.SearchSonyCameraDevices();
        }
    }
}