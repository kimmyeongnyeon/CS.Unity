using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Video;

public class csPlanBrokenManager : MonoBehaviour
{
    public enum HitType
    {
        HIT_GROUND,
        SPRAY_WATER,
        SPRAY_SEED
    }

    public Object broken_Prefab;// 땅 파티클 이펙트
    public GameObject broken_Pos;//파티클 위치
    public static csPlanBrokenManager instance = null;
    public bool isInside = false;
   

    public void csPlanBroke()
    {
       // broken_Prefab.transform.position = broken_Prefab.transform.position;



    }

    public void HitGorund()
    {
        hitPlayerAction(HitType.HIT_GROUND);
    }
    public void SpraySeed()
    {
        hitPlayerAction(HitType.SPRAY_SEED);
    }
    public void SprayWater()
    {
        hitPlayerAction(HitType.SPRAY_WATER);
    }
    

    private void hitPlayerAction(HitType hType)
    {
        if (!isInside) 
            return;

        switch(hType)
        {
            case HitType.HIT_GROUND:
                GameObject part = (GameObject)Instantiate(broken_Prefab, transform);
                Destroy(part, 2f);
                break;
            case HitType.SPRAY_SEED:
                csSeedTouch seedTouch = GetComponent<csSeedTouch>();
                seedTouch.SparySeed();
                break;
            case HitType.SPRAY_WATER:
                csPlantGrow plantGrow = GetComponent<csPlantGrow>();
                plantGrow.SprayWater();
                break;
        }
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag.Equals("Player"))
        {
            isInside = true;
        }
    }

    void OnTriggerExit(Collider coll)
    {
        if (coll.tag.Equals("Player"))
        {
            isInside = false;
          
        }
    }

    void start()
    {
        
    }
}
