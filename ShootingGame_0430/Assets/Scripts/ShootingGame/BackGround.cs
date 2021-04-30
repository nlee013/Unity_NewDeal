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
        //1. �����̴� ����
        Vector2 dir = Vector2.up;

        //2. offset ���� P = P0 + vt
        backgroundMaterial.mainTextureOffset += dir * moveSpeed * Time.deltaTime;
    }
}
