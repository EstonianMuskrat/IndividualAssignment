using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

// TODO: Bonus - make this class a Singleton!

[System.Serializable]
public class BulletPoolManager : MonoBehaviour
{
    public GameObject bullet;
    public BulletController bulletCon;
    //TODO: create a structure to contain a collection of bullets

    struct BullColl
    {
        int BltAmnt;
    };

    // Start is called before the first frame update
    void Start()
    {
        bulletCon.manager = this;
        // TODO: add a series of bullets to the Bullet Pool
        Queue<GameObject> BltQ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //TODO: modify this function to return a bullet from the Pool
    public GameObject GetBullet()
    {
        if (BltQ.empty == true)
        {
            return "Empty";
        }
        else
        {
            BltQ.pop();
        }
        return bullet;
    }

    //TODO: modify this function to reset/return a bullet back to the Pool 
    public void ResetBullet(GameObject bullet)
    {
        BlyQ.push(GameObject);
    }
}
