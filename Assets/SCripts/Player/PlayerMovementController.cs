using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    private Rigidbody2D _rigidBody;
    private Animator animator;
   [SerializeField] private float speed = 10f;
    private float horizontal;
    private float Vertical;
    private  Vector2 _direction;
    [SerializeField] Transform _bulletPositon;

    // Start is called before the first frame update
    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        //This is use for Player Input  Move Horizontaly
        horizontal = Input.GetAxis("Horizontal");
        // tihs is use for player Input Move Verticaly 
        Vertical = Input.GetAxis("Vertical");

        _direction = new Vector2(horizontal, Vertical);
        _rigidBody.velocity = _direction.normalized * speed;
        PlayerAnimation();

        if (!Input.GetKeyDown(KeyCode.Mouse0))
        {
            return;
        }
        Fire(PoolObjectsTypes.Player_Bullet);


    }

    private void PlayerAnimation()
    {
        if (horizontal < 0)
        {
            animator.SetBool("isFlyingLeft", true);
        }
        else if (horizontal > 0)
        {
            animator.SetBool("isFlyingRight", true);
        }
        else
        {
            animator.SetBool("isFlyingMid", true);
        }

    }

    private void Fire(PoolObjectsTypes type)
    {
        GameObject _Bullet = PoolManager.Instance.GetPooledObject(type);
        if (_Bullet != null)
        {
            _Bullet.transform.position = _bulletPositon.transform.position;
            _Bullet.transform.rotation = _bulletPositon.transform.rotation;
            _Bullet.SetActive(true);
        }
    }
}

