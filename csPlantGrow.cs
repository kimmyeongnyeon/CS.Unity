using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class csPlantGrow : MonoBehaviour
{
    public Object[] plants;
    public int GROW_TIME = 10;
    float beginTime = 0f;
    GameObject gamePlant = null;
    int step = 0;

    public void SprayWater()
    {
        beginTime = Time.time;
        gamePlant = (GameObject)Instantiate(plants[0], transform);

        StartCoroutine(coGrowPlant());
    }

    IEnumerator coGrowPlant()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);

            float nowTime = Time.time;
            int diffTime = (int)(nowTime - beginTime);
            Debug.Log("difftime : " + diffTime);

            // 60초가 지났을 때
            if (diffTime >= GROW_TIME)
            {
                beginTime = Time.time;
                step++;
                if (step < plants.Length)
                {
                    Destroy(gamePlant);
                    gamePlant = (GameObject)Instantiate(plants[step], transform);
                }
                else
                {
                    break;
                }
            }
        }

    }
}
