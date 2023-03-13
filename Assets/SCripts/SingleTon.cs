using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField]
    private bool donDestroy = false;
    static T m_Instance;

    public static T Instace
    {
        get
        {
            if(m_Instance == null)
            {
                m_Instance = GameObject.FindObjectOfType<T>();
                if(m_Instance == null)
                {
                    GameObject singleton = new GameObject(typeof(T).Name);
                    m_Instance = singleton.AddComponent<T>();

                }
            }
            return m_Instance;
        }
    }

    public virtual void Awake()
    {
        if(m_Instance == null)
        {
            m_Instance = this as T;
            
            
            if(donDestroy)
            {
                transform.parent = null;
                DontDestroyOnLoad(this.gameObject);
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}