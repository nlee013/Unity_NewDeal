using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject missilePrefabs; // 미사일 프리팹
    public Transform firePosition; // Fire 위치


    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }

    void Fire()
    {
        Instantiate(missilePrefabs, firePosition.transform.position, firePosition.transform.rotation);
    }
}
