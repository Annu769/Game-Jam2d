using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPerforming : MonoBehaviour
{


   
    private GameOverFuctions GameOver;
  
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.GetComponent<MonsterController>() != null)
        {
            
            col.gameObject.SetActive(false);
           
            gameObject.SetActive(false);
            ScoreUI.Instance.AddScore();
           
        }
        else if (col.gameObject.CompareTag("Wall"))
        {
            this.gameObject.SetActive(false);
        }
    }

  
    

   
   
}
