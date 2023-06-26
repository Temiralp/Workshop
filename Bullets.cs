using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class Bullets : MonoBehaviourPunCallbacks
{
    private int shooterId; // Atýþý gerçekleþtiren oyuncunun ID'si

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
