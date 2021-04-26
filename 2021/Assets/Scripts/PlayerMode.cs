using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMode : MonoBehaviour
{
    //velocity
    public float speed = 7;

    //missile prefab
    public GameObject missilePrefabs;

    [SerializeField]
    //missile starting position
    public GameObject firePosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = Vector3.right * h + Vector3.up * v;

        //movement
        transform.Translate(dir * speed * Time.deltaTime);

        if (Input.GetMouseButton(0))
        {
            Fire();
        }
    }

    void Fire()
    {
        Instantiate(missilePrefabs, firePosition.transform.position, firePosition.transform.rotation);
    }

}
