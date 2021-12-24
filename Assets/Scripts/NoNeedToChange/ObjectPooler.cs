using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Object pooling that reuses game objects
/// without instantiating and destroying objects.
/// </summary>
public class ObjectPooler : MonoBehaviour
{
    public GameObject pooledObject;     //Object prefab to reuse
    public int amount;                  //Amount of objects to create in the begining of the scene

    private List<GameObject> poolList;  //List of pooled objects ready to be enabled

    /// <summary>
    /// Create and cache objects in the begining
    /// of the scene
    /// </summary>
    private void Start()
    {
        poolList = new List<GameObject>();
        for (int i = 0; i < amount; i++)
        {
            GameObject target = Instantiate(pooledObject);
            target.SetActive(false);
            poolList.Add(target);
        }
    }

    /// <summary>
    /// Get an object from the pool list
    /// If no object remains in the list,
    /// then create one and add it to the list
    /// </summary>
    /// <returns>Next object in the list</returns>
    public GameObject GetPooledObject()
    {
        if (poolList == null)
            poolList = new List<GameObject>();

        for (int i = 0; i < poolList.Count; i++)
        {
            if (poolList[i] != null && !poolList[i].activeInHierarchy)
                return poolList[i];
        }

        GameObject extra = Instantiate(pooledObject);
        extra.SetActive(false);
        poolList.Add(extra);
        return extra;
    }
}
