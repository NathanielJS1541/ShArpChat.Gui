using System.Collections.ObjectModel;
using ShArpChat.Network;

namespace ShArpChat.Gui
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<NetworkInterface> NetworkInterfaces { get; } = [];

        public Command RefreshCommand { get; }

        public MainPage()
        {
            RefreshCommand = new Command(OnRefresh);

            InitializeComponent();
        }

        private void OnRefresh(object sender)
        {
            var networks = NetworkManager.GetSupportedInterfaces();

            NetworkInterfaces.Clear();

            foreach (var network in networks)
            {
                NetworkInterfaces.Add(network);
            }
        }
    }
}