using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public Material backgroundMaterial;

    [Range(0f, 1f)]
    public float moveSpeed = 0.25f;




    void Start()
    {
        
    }

    void Update()
    {
        //1. 움직이는 방향
        Vector2 dir = Vector2.up;

        //2. offset 조절 P = P0 + vt
        backgroundMaterial.mainTextureOffset += dir * moveSpeed * Time.deltaTime;
    }
}
