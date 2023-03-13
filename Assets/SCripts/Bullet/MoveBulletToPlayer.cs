using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBulletToPlayer : MonoBehaviour
{
   
    [SerializeField] private GameObject player;
    [SerializeField] private float speed;
    //SerializeField] Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    private void Update()
    {
        BulletMoveToPlayer();
    }

    public void BulletMoveToPlayer()
    {
        
       if(player != null)

            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);


    }

    // Update is called once per frame

}
