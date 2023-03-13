using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class MonsterController : MonoBehaviour
{

   
    [SerializeField] private Vector2 moveSpeed;
    [SerializeField] float time;
    [SerializeField] float reapeaRate;
    private Rigidbody2D rb;
  
  
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

       

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.velocity = moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerMovementController>() != null)
        {
            GameOverFuctions.Instance.GameIsOver();
            collision.gameObject.SetActive(false);
        }
        else if(collision.gameObject.CompareTag("Wall"))
        {
            GameOverFuctions.Instance.GameIsOver();
        }
    }
}
