using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStraightController : MonoBehaviour
{
    [SerializeField] private Vector2 moveSpeed;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    private  void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.velocity = moveSpeed;
    }
}
