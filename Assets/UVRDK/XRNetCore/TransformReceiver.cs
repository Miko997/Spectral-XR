using UnityEngine;
using System.Net.Sockets;
using System.Text;

namespace UVRDK.Network {
    /// <summary>
    /// Receives UDP position updates and moves the transform.
    /// </summary>
    public class TransformReceiver : MonoBehaviour {
        public int port = 9000;
        UdpClient client;

        void Start() {
            client = new UdpClient(port);
            client.Client.Blocking = false;
        }

        void Update() {
            if (client == null || client.Available == 0) return;
            var ep = new System.Net.IPEndPoint(System.Net.IPAddress.Any, port);
            byte[] data = client.Receive(ref ep);
            string msg = Encoding.ASCII.GetString(data);
            string[] parts = msg.Split(',');
            if (parts.Length == 3 &&
                float.TryParse(parts[0], out float x) &&
                float.TryParse(parts[1], out float y) &&
                float.TryParse(parts[2], out float z)) {
                transform.position = new Vector3(x, y, z);
            }
        }

        void OnDestroy() {
            client?.Close();
        }
    }
}
