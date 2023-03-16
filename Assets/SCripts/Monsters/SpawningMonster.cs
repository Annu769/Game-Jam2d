using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum MonsterType
{
    Monster1,
    Monster2
}
public class SpawningMonster : MonoBehaviour
{
    [SerializeField] private MonsterType monsterType;
    [SerializeField] private float time;
    [SerializeField] private float reapeatRate;

    private void Start()
    {
        InvokeRepeating("TypeOfMonsterSpawning", time, reapeatRate);
    }

    private void TypeOfMonsterSpawning()
    {
        switch(monsterType)
        {
            case MonsterType.Monster1:
                StartCoroutine(SpawnMonster(PoolObjectsTypes.Monster1));
                break;

            case MonsterType.Monster2:
                StartCoroutine(SpawnMonster(PoolObjectsTypes.Monster2));  
                break;
                //default:break;
        }
    }

    private IEnumerator SpawnMonster(PoolObjectsTypes type)
    {
        yield return new WaitForSeconds(3);
        GameObject obj = PoolManager.Instance.GetPooledObject(type);
        if(obj != null)
        {
            obj.transform.position = this.transform.position;
            obj.transform.rotation = this.transform.rotation;
            obj.SetActive(true);
        }

       
    }

   
   
}
