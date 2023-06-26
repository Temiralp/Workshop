using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    public GameObject playerPrefab; // Oyuncu odaya katýldýðýnda oluþturulacak oyuncu prefab'ý
    private string gameVersion = "1"; // Oyunun sürümü, uyumluluk amaçlarý için kullanýlýr

    void Start()
    {
        // Tüm client'lar için sahneyi otomatik olarak senkronize eder
        PhotonNetwork.AutomaticallySyncScene = true;
        Connect();
    }

    void Connect()
    {
        // Eðer Photon sunucusuna zaten baðlýysak bir odaya katýlýr
        if (PhotonNetwork.IsConnected)
        {
            JoinRoom();
        }
        else
        {
            // Eðer baðlý deðilsek, Photon sunucusuna baðlanýr ve oyun sürümünü ayarlar
            PhotonNetwork.ConnectUsingSettings();
            PhotonNetwork.GameVersion = gameVersion;
        }
    }

    public override void OnConnectedToMaster()
    {
        // Master sunucusuna baðlandýðýmýzda log atar ve odaya katýlýr
        Debug.Log("Connected to Master");
        JoinRoom();
    }

    void JoinRoom()
    {
        // Oda seçeneklerini ayarlar, bu durumda maksimum oyuncu sayýsý 2 olacak þekilde
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 4;
        // "Room1" isimli bir odaya katýlýr veya odayý oluþturur
        PhotonNetwork.JoinOrCreateRoom("Room1", roomOptions, TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        // Odaya katýldýðýnda log atar ve oyuncu objesini oluþturur
        Debug.Log("Joined Room");
        PhotonNetwork.Instantiate(playerPrefab.name, new Vector2(0, 0), Quaternion.identity);
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        // Baðlantý kesildiðinde sebebini log atar
        Debug.Log($"Disconnected due to: {cause}");
    }
}