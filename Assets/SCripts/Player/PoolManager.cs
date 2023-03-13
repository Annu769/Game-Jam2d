using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PoolObjectsTypes
{
    Player_Bullet,
    Monster1, 
    Monster2
}


[Serializable]
public class PoolInfo
{
    public PoolObjectsTypes type;
    public int amount;
    public GameObject prefab;
    public GameObject prefab_Position;
    [HideInInspector]
    public List<GameObject> pool = new List<GameObject>();
}

public class PoolManager : Singleton<PoolManager>
{

    [SerializeField] private List<PoolInfo> listOfPoolObj;
    

    
   
    void Start()
    {
        for(int i = 0; i < listOfPoolObj.Count; i++)
        {
            AmmountOfGameObject(listOfPoolObj[i]);
        }
        
    }

    void AmmountOfGameObject(PoolInfo info)
    {
        for(int i = 0;i < info.amount; i++)
        {
            GameObject object_Instance = null;
            object_Instance = Instantiate(info.prefab, info.prefab_Position.transform);
            object_Instance.gameObject.SetActive(false);
            info.pool.Add(object_Instance);


        }
    }

    public GameObject GetPooledObject(PoolObjectsTypes types)

    {
        PoolInfo selected = GetPoolObjectType(types);
        List<GameObject> pool = selected.pool;
        GameObject objectInstance = null;
        if(pool.Count > 0)
        {
            objectInstance = pool[pool.Count-1];
            pool.Remove(objectInstance);
        }
        else
        {
            objectInstance = Instantiate(selected.prefab, selected.prefab_Position.transform);
        }
        return objectInstance;


    }
    
    private PoolInfo GetPoolObjectType(PoolObjectsTypes type)
    {
        for(int i = 0; i < listOfPoolObj.Count; i++)
        {
            if (type == listOfPoolObj[i].type)
                return listOfPoolObj[i];
        }
        return null;
    }

    

}


