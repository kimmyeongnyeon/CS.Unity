using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csSeedTouch : MonoBehaviour
{
    public GameObject Seed;
    public int GROW_TIME = 5;
    public float DestoryTime = 3.0f;
    public void SparySeed()
    {
        GameObject seedObj = Instantiate(Seed, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        Destroy(seedObj, DestoryTime);
    }
}
