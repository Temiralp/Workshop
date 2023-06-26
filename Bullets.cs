using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class Bullets : MonoBehaviourPunCallbacks
{

    private int shooterId; // Atýþý gerçekleþtiren oyuncunun ID'si
private int shooterId; // Atýþý gerçekleþtiren oyuncunun ID'si

private int shooterId; // Atýþý gerçekleþtiren oyuncunun ID'si
private int shooterId; // Atýþý gerçekleþtiren oyuncunun ID'si
private int shooterId; // Atýþý gerçekleþtiren oyuncunun ID'si
    hooterId = shooterId;GetComponent<Rigidbody2D>().velocity = Vector2.right * 20f;
  hooterId = shooterId;GetComponent<Rigidbody2D>().velocity = Vector2.right * 20f;
  GetComponent<Rigidbody2D>().velocity = Vector2.right * 20f;
  GetComponent<Rigidbody2D>().velocity = Vector2.right * 20f;
private int shooterId; // Atýþý gerçekleþtiren oyuncunun ID'si
hýhjghýkjb
private int shooterId; // Atýþý gerçekleþtiren oyuncunun ID'si
private int shooterId; // Atýþý gerçekleþtiren oyuncunun ID'si
private int shooterId; // Atýþý gerçekleþtiren oyuncunun ID'si
private int shooterId; // Atýþý gerçekleþtiren oyuncunun ID'si
private int shooterId; // Atýþý gerçekleþtiren oyuncunun ID'si

    merhaba
        merhaba
        mmmmmmmmm



deneme
lkslaksdlaksjdalksþalkþalskþals
private int shooterId; // Atýþý gerçekleþtiren oyuncunun ID'si
shahdahdajhduag
private int shooterId; // Atýþý gerçekleþtiren oyuncunun ID'si
private int shooterId; // Atýþý gerçekleþtiren oyuncunun ID'si
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
