using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTest : MonoBehaviour
{
    //key값을 받아 오브젝트 빛깔을 순환하도록
    
    Renderer cube1; // 색깔을 가지고 있는 애
    int randomColor = 0; // 역할 : 스위치문에서 case의 숫자를 가지고 있는 애

    // Start is called before the first frame update
    void Start()
    {
        cube1 = gameObject.GetComponent<Renderer>();
    }

    //123, 212, 212

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            switch (randomColor)
            {
                case 0:
                    cube1.material.color = Color.black;
                    break;

                case 1:
                    cube1.material.color = Color.blue;
                    break;

                case 2:
                    cube1.material.color = Color.red;
                    break;

                case 3:
                    cube1.material.color = Color.green;
                    break;
            }
        }

        randomColor = Random.Range(0, 4);
    }
}
