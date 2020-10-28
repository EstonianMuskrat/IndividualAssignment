using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// TODO: Bonus - make this class a Singleton!

[System.Serializable]
public class BulletPoolManager : MonoBehaviour
{
    public GameObject bullet;
    public int BlltAmnt;
    //TODO: create a structure to contain a collection of bullets
    private Queue<GameObject> Ammo;

    // Start is called before the first frame update
    void Start()
    {
        // TODO: add a series of bullets to the Bullet Pool
        Ammo = new Queue<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    pivate void CreateBllPool()
    {
        for (int i = 0; i < BllAmnt; i++)
        {
            var tBull = Instantiate(bullet);
            tBull.transform.parent = transform;
            tBull.SetActive(false);
        }
    }

    //TODO: modify this function to return a bullet from the Pool

    public GameObject GetBullet()
    {
        GameObject tBull;
        if (BltQ.empty == true)
        {
            tBull = Instantiate(bullet);
            tBull.transform.parent = transform;
        }
        else
        {
            tBull = BltQ.Dequeue();
            tBull.SetActive(true);
        }
        return tBull;
    }

    //TODO: modify this function to reset/return a bullet back to the Pool 
    public void ResetBullet(GameObject bullet)
    {
        Instantiate BlyQ.push(GameObject);
    }
}
