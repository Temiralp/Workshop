using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerController : MonoBehaviourPunCallbacks
{
    private Rigidbody2D rb;
    public GameObject bullet;
    public GameObject bulletPos;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (photonView.IsMine)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector2 movement = new Vector2(moveHorizontal, moveVertical);
            rb.velocity = movement * 10f;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                photonView.RPC("Fire", RpcTarget.All);
            }

        }

        

    }
    [PunRPC]
    public void Fire() {
        if (photonView.IsMine)
        {
         GameObject bulletMove=   PhotonNetwork.Instantiate(bullet.name, bulletPos.transform.position, bulletPos.transform.rotation);
            Bullets bullets = bulletMove.GetComponent<Bullets>();
            bullets.photonView.RPC("Initialize", RpcTarget.All, photonView.ViewID);
        }

    }
    [PunRPC]
    public void TakeDamage()
    {
        // Oyuncunun büyüklüðünü belirli bir miktar küçültür
        transform.localScale -= new Vector3(0.2f, 0.2f, 0);

        // Eðer oyuncunun büyüklüðü 0'a eþit veya daha küçükse oyuncuyu yok eder
        if (transform.localScale.x <= 0)
        {
            if (photonView.IsMine)
            {
                PhotonNetwork.Destroy(gameObject);
            }
        }
    }

}
