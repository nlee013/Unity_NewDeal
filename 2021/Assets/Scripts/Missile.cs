using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    float MissileSpeed = 6;

    //미사일 공장
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        // Vector3 dir = Vector3.up;

        //movement
        transform.Translate(Vector3.up * MissileSpeed * Time.deltaTime);

    }

   
}
