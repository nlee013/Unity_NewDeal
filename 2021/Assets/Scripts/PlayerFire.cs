using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject missilePrefabs; // �̻��� ������
    public Transform firePosition; // Fire ��ġ


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
