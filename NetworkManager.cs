using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    public GameObject playerPrefab; // Oyuncu odaya kat�ld���nda olu�turulacak oyuncu prefab'�
    private string gameVersion = "1"; // Oyunun s�r�m�, uyumluluk ama�lar� i�in kullan�l�r

    void Start()
    {
        // T�m client'lar i�in sahneyi otomatik olarak senkronize eder
        PhotonNetwork.AutomaticallySyncScene = true;
        Connect();
    }

    void Connect()
    {
        // E�er Photon sunucusuna zaten ba�l�ysak bir odaya kat�l�r
        if (PhotonNetwork.IsConnected)
        {
            JoinRoom();
        }
        else
        {
            // E�er ba�l� de�ilsek, Photon sunucusuna ba�lan�r ve oyun s�r�m�n� ayarlar
            PhotonNetwork.ConnectUsingSettings();
            PhotonNetwork.GameVersion = gameVersion;
        }
    }

    public override void OnConnectedToMaster()
    {
        // Master sunucusuna ba�land���m�zda log atar ve odaya kat�l�r
        Debug.Log("Connected to Master");
        JoinRoom();
    }

    void JoinRoom()
    {
        // Oda se�eneklerini ayarlar, bu durumda maksimum oyuncu say�s� 2 olacak �ekilde
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 4;
        // "Room1" isimli bir odaya kat�l�r veya oday� olu�turur
        PhotonNetwork.JoinOrCreateRoom("Room1", roomOptions, TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        // Odaya kat�ld���nda log atar ve oyuncu objesini olu�turur
        Debug.Log("Joined Room");
        PhotonNetwork.Instantiate(playerPrefab.name, new Vector2(0, 0), Quaternion.identity);
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        // Ba�lant� kesildi�inde sebebini log atar
        Debug.Log($"Disconnected due to: {cause}");
    }
}