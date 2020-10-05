using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilledChange : MonoBehaviour
{
    public Texture[] textures;// 이미지 배열 선언
    private MeshRenderer meshRenderer;

 
 void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PLAYER")
        {
            Debug.Log(collision.gameObject.tag.ToString());
            meshRenderer.material.mainTexture = textures[0];
        }
    }

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        //meshRenderer.material.mainTexture = textures[0];
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
