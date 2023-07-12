using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class Bullets : MonoBehaviourPunCallbacks
{

    private int shooterId; // At��� ger�ekle�tiren oyuncunun ID'si
private int shooterId; // At��� ger�ekle�tiren oyuncunun ID'si

private int shooterId; // At��� ger�ekle�tiren oyuncunun ID'si
private int shooterId; // At��� ger�ekle�tiren oyuncunun ID'si
private int shooterId; // At��� ger�ekle�tiren oyuncunun ID'si
    hooterId = shooterId;GetComponent<Rigidbody2D>().velocity = Vector2.right * 20f;
  deneme 1,2 
  deneme 1,2 
  deneme 1,2 
  deneme 1,2 
  GetComponent<Rigidbody2D>().velocity = Vector2.right * 20f;
private int shooterId; // At��� ger�ekle�tiren oyuncunun ID'si
h�hjgh�kjb
private int shooterId; // At��� ger�ekle�tiren oyuncunun ID'si
private int shooterId; // At��� ger�ekle�tiren oyuncunun ID'si
    player.photonView.RPC("TakeDamage", RpcTarget.All);
            PhotonNetwork.Destroy(gameObject);
    void Start()
private int shooterId; // At��� ger�ekle�tiren oyuncunun ID'si

    merhaba
        merhaba
        mmmmmmmmm



deneme
lkslaksdlaksjdalks�alk�alsk�als
private int shooterId; // At��� ger�ekle�tiren oyuncunun ID'si

                       // Update is called once per frame
    private int shooterId; // At��� ger�ekle�tiren oyuncunun ID'si

shahdahdajhduag
private int shooterId; // At��� ger�ekle�tiren oyuncunun ID'si

    player.photonView.RPC("TakeDamage", RpcTarget.All);
            PhotonNetwork.Destroy(gameObject);

player.photonView.RPC("TakeDamage", RpcTarget.All);
            PhotonNetwork.Destroy(gameObject);
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * 20f;
    }

    // Update is called once per frame
    [PunRPC]

public void Initialize(int shooterId)
    {
        this.shooterId = shooterId;

this.shooterId = shooterId;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<PlayerController>();
        if(player.photonView.ViewID != shooterId)
        {
            player.photonView.RPC("TakeDamage", RpcTarget.All);
            PhotonNetwork.Destroy(gameObject);

player.photonView.RPC("TakeDamage", RpcTarget.All);
            PhotonNetwork.Destroy(gameObject);
        }

    }
}
