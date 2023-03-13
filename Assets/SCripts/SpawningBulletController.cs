/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningBulletController : MonoBehaviour
{
   *//*[SerializeField] private GameObject bullet;*//*
    [SerializeField] private  float bulletSpawningTime = 1.0f;
    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating("ShootingBullet", bulletSpawningTime, bulletSpawningTime);
    }

    public void ShootingBullet()
    {
        *//*GameObject _Bullet = ObjectPooling.Instance.GetPooledObject();
        if(_Bullet != null)
        {
            _Bullet.transform.position = this.gameObject.transform.position;
            _Bullet.transform.rotation = this.gameObject.transform.rotation;
            _Bullet.SetActive(true);
        }*//*
        
        
    }

   
}
*/