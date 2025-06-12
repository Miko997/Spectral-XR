using UnityEngine;
using System.Net.Sockets;
using System.Text;

namespace UVRDK.Network {
    /// <summary>
    /// Broadcasts this transform's position over UDP each frame.
    /// </summary>
    public class TransformBroadcaster : MonoBehaviour {
        public string remoteHost = "127.0.0.1";
        public int port = 9000;
        UdpClient client;

        void Start() {
            client = new UdpClient();
        }

        void Update() {
            if (client == null) return;
            Vector3 p = transform.position;
            string msg = $"{p.x},{p.y},{p.z}";
            byte[] data = Encoding.ASCII.GetBytes(msg);
            client.Send(data, data.Length, remoteHost, port);
        }

        void OnDestroy() {
            client?.Dispose();
        }
    }
}
