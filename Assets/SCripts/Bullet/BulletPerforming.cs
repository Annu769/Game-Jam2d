using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPerforming : MonoBehaviour
{

  
    [SerializeField] private Vector2 moveSpeed;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    private void FixedUpdate()
    {
        rb.velocity = moveSpeed;
    }
    
  
    

    private GameOverFuctions GameOver;
  
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.GetComponent<MonsterController>() != null)
        {
            
            col.gameObject.SetActive(false);

            PoolManager.Instance.ReturnToPool(this.gameObject);
            ScoreUI.Instance.AddScore();
           
        }
        else if (col.gameObject.CompareTag("Wall"))
        {
            this.gameObject.SetActive(false);
        }
    }

  
    

   
   
}
